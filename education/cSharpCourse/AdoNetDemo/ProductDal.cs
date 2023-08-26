using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetDemo
{
    public class ProductDal // Data Access layer - veri erisim katmani
    {
        // @ isareti tirnagin icini tamamen string kabul eder. Olmazsa '\' dan kaynakli hata alinabilir.
        SqlConnection _connection = new SqlConnection(@"server=(localdb)\mssqllocaldb;initial catalog=ETrade;integrated security=true");
        // server = hangi servere baglanilacagi verilir.
        // initial catalog = O serverdaki hangi veritabanina baglanilacagi verilir.
        // integrated security = veritabanina Windows Authentication ile baglan demek.

        // uzaktaki bir sunucuya baglanmak icin "integrated security =false;uid=atakan;password=12345;" gibi...


        private void ConnectionControl()
        {
            if (_connection.State == ConnectionState.Closed) // baglanti kapaliysa ac
            {
                _connection.Open(); // baglanti acilir
            }
        }

        // dataTable ile calismak
        public DataTable GetAll1()
        {
            ConnectionControl();

            SqlCommand command = new SqlCommand("Select * from Products", _connection);

            SqlDataReader reader = command.ExecuteReader();

            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            reader.Close();
            _connection.Close();
            return dataTable;
        }

       

        public List<Product> GetAll2()
        {
            ConnectionControl();

            SqlCommand command = new SqlCommand("Select * from Products", _connection);

            SqlDataReader reader = command.ExecuteReader();

            List<Product> products = new List<Product>();
            
            while (reader.Read()) //gelen kayitlari tek tek oku. Okuyabildikce oku
            {
                Product product = new Product
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Name = reader["Name"].ToString(),
                    StockAmount = Convert.ToInt32(reader["StockAmount"]),
                    UnitPrice = Convert.ToDecimal(reader["UnitPrice"])
                };
                products.Add(product);
            }

            reader.Close();
            _connection.Close();
            return products;
        }

        public void Add(Product product)
        {
            ConnectionControl();

            SqlCommand command = new SqlCommand("Insert into Products values(@name,@unitPrice,@stockAmount)", _connection);

            command.Parameters.AddWithValue("@name", product.Name);
            command.Parameters.AddWithValue("@unitPrice", product.UnitPrice);
            command.Parameters.AddWithValue("@stockAmount", product.StockAmount);

            command.ExecuteNonQuery(); // ayni zamanda kontrol icin etkilenen kayit sayisini dondurur. Ornek 1'dir.

            _connection.Close();
        }

        public void Update(Product product)
        {
            ConnectionControl();

            SqlCommand command = new SqlCommand(
                // 'where' anahtarini kullanmak cok onemlidir. Kullanilmazsa butun tabloyu gunceller. Ayirmak icin Id belirtilir
                "Update Products set Name=@name, UnitPrice=@unitPrice, StockAmount=@stockAmount where Id=@id", _connection);

            command.Parameters.AddWithValue("@name", product.Name);
            command.Parameters.AddWithValue("@unitPrice", product.UnitPrice);
            command.Parameters.AddWithValue("@stockAmount", product.StockAmount);
            command.Parameters.AddWithValue("@id", product.Id);

            command.ExecuteNonQuery(); // ayni zamanda kontrol icin etkilenen kayit sayisini dondurur. Ornek 1'dir.

            _connection.Close();
        }

        public void Delete(int id)
        {
            ConnectionControl();

            SqlCommand command = new SqlCommand(
                // 'where' anahtarini kullanmak cok onemlidir. Kullanilmazsa butun tabloyu SILER!! Ayirmak icin Id belirtilir
                "Delete from Products where Id=@id", _connection);

            command.Parameters.AddWithValue("@id", id);

            command.ExecuteNonQuery(); // ayni zamanda kontrol icin etkilenen kayit sayisini dondurur. Ornek 1'dir.

            _connection.Close();
        }
    }
}
