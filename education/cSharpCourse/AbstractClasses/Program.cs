using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ayni interface'ler gibi abstract classlar da Turetilemez!
            // ornek; Database database = new Database();

            Database database = new Oracle();
            database.Add();
            database.Delete();

            Database database2 = new SqlServer();
            database2.Add();
            database2.Delete();

            Console.ReadLine();
        }
    }

    // abstract 
    // bu ornekte butun veri tabanlari nda ekleme isleminin ayni oldugunu, silme islemlerinin
    // farkli oldugunu varsayiyoruz. Dolayisi ile butun cocuklara silme methodunun implementasyonunu
    // zorunlu tutuyoruz.
    abstract class Database
    {
        public void Add()
        {
            // 
            Console.WriteLine("Added by default");
        }

        public abstract void Delete(); // sanal method
    }

    class SqlServer : Database
    {
        // bu cocuk soyut methodu uygulamak zorunda kalmistir. Aksi takdirde hata verir ve altini cizer
        public override void Delete()
        {
            Console.WriteLine("Deleted by Sql");
        }
    }

    class Oracle : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by Oracle");
        }
    }
}
