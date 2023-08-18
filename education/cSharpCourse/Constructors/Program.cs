using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // constructor kullanimi
            CustomerManager manager = new CustomerManager(26);
            manager.List();

            Product product = new Product { Id = 1, Name = "Laptop" };
            Product product2 = new Product(2, "Computer");

            //enjecte islemi yapildi simdi kullan
            EmployeeManager employeeManager = new EmployeeManager(new DatabaseLogger());
            employeeManager.Add();


            PersonManager personManager = new PersonManager("product");
            personManager.Add();

            Teacher.Number = 10;

            Utilities.Validate();

            Manager.DoSomething();
            Manager m = new Manager();
            m.DoSomething2();


            Console.ReadLine();

        }
    }

    class CustomerManager
    {

        private int _count = 15;
        public CustomerManager(int count) // birincil constructor
        {
            _count = count;
        }
        public CustomerManager() // Constructor overloading
        {

        }
        public void List()
        {
            Console.WriteLine("Listed {0} items", _count);
        }
    }

    // ikici kullanim ornegi
    class Product
    {
        public Product()
        {

        }
        private int _id;
        private string _name;

        public Product(int id, string name)
        {
            _id = id;
            _name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

    }

    // consturactor injection
    interface ILogger
    {
        void Log();
    }

    class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to file");
        }
    }
    class DatabaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to database");
        }
    }

    class EmployeeManager
    {
        // onemli nokta. ILogger i constructor enjekte edicez

        private ILogger _logger;
        public EmployeeManager(ILogger logger)
        {
            _logger = logger;
        }

        public void Add()
        {
            _logger.Log();
            Console.WriteLine("Added!");
        }

    }

    // >>> base sinifa parametre gonderme <<<
    class BaseClass
    {
        private string _entity;
        public BaseClass(string entity)
        {
            _entity = entity;
        }
        public void Message()
        {
            Console.WriteLine("{0} message", _entity);
        }
    }
    class PersonManager : BaseClass
    {
        // base'e veriyi gondermek icin asagidaki yapiyi kullanicagiz.
        public PersonManager(string entity):base(entity)
        {

        }

        public void Add()
        {
            Console.WriteLine("Added!");
            Message();
        }

    }


    // >>> static class ve methodlar <<<
    /* static siniflar turerilemez
     * Bellekte bir adet olusturulur ve herkes kullanir.
     * Teacher.Number demek ulasmak icin yeterlidir
     * prop lari da 'static' olmak zorundadir
     * static nesneler ortak nesnelerdir
     */
    static class Teacher
    {
        public static int Number { get; set; }
    }
    static class Utilities
    {
        public static void Validate()
        {
            Console.WriteLine("Validation is done");
        }
    }

    // classlarin proplari da static olabilir
    
    class Manager
    {
        public static void DoSomething()
        {
            Console.WriteLine("Done");
        }
        public void DoSomething2()
        {
            Console.WriteLine("Done2");
        }
    }
}
