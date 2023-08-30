using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // generic methodlar
            Utilities utilities = new Utilities();
            List<string> result = utilities.BuildList<string>("Ankara", "İzmir", "Adana");
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            List<Customer> reslt2 = utilities.BuildList<Customer>(new Customer { FirstName="Atakan" }, new Customer { FirstName= "Ahmet"});

            foreach (var item in reslt2)
            {
                Console.WriteLine(item.FirstName);
            }

            Console.ReadLine();
        }   

    }
    class Utilities
    {
        // hangi tiple calisilacaksa o tiple dondur. Generic Method
        public List<T> BuildList<T>(params T[] items)
        {
            return new List<T>(items);
        }

    }
    interface IProductDal : IRepository<Product>
    {

    }
    class Product : IEntity
    {

    }
    interface ICustomerDal:IRepository<Customer>
    {

    }
    class Customer : IEntity
    {
        public string FirstName { get; set; }
    }
    interface IEntity
    {

    }
    // siklikla yaptigimiz operasyonlari nesne bazli olarak degistirebilecegimiz, ben bu nesneyle calisacagim diyebilecegimiz bir yapiya 
    // isaret eder. Grneric yapi ; 
    interface IRepository<T> where T : class,IEntity, new() 
                                             // generic kisitlari: T degiskenine 'string','int' gibi degerler gonderilmesini engellemek icin
                                            // bir kisit tanimliyoruz. Bu T'nin sadece bir 'class' olabilecegini soyler
                                           // Referans tipler yerine 'string' gibi tiplerinde kullanilmasini istemiyorsak new lene bilir olmasi
                                          // sartini veriyoruz. 'new()'. 
                                          // sadece deger tipleri koymak istersek T:struct kullanilir
    {
        List<T> GetAll();
        T Get(int id);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }

    class ProductDal : IProductDal
    {
        public void Add(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        public Product Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }


    class CustomerDal : ICustomerDal
    {
        public void Add(Customer entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Customer entity)
        {
            throw new NotImplementedException();
        }

        public Customer Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Customer entity)
        {
            throw new NotImplementedException();
        }
    }
}
