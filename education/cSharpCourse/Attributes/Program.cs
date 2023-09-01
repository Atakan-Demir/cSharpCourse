using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes // Oz nitelikler 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer { Id = 1, LastName = "Demir", Age = 22 };
            CustomerDal customerDal = new CustomerDal();
            customerDal.Add(customer);

            Console.ReadLine();
        }
    }
    [ToTable("Customers")]// iki tabloyada bak
    [ToTable("TblCustomers")]
    class Customer
    {
        public int Id { get; set; }
        [RequiredProperty]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }
    class CustomerDal
    {
        [Obsolete("Dont use Add, instead use AddNew Method")]
        public void Add(Customer customer)
        {
            Console.WriteLine("{0},{1},{2},{3} added!", customer.Id, customer.FirstName, customer.LastName, customer.Age);
        }
        public void AddNew(Customer customer)
        {
            Console.WriteLine("{0},{1},{2},{3} added!", customer.Id, customer.FirstName, customer.LastName, customer.Age);
        }
    }

    //[AttributeUsage(AttributeTargets.All)] herseye kullanilabilir demek
    [AttributeUsage(AttributeTargets.Property,AllowMultiple = true)]// Sadece Ozelliklerin ustune kullanilabilir demek
    //AllowMultiple = true : birden fazla kullanilip kullanilamayacagini belirler
    class RequiredPropertyAttribute : Attribute
    {

    }
    [AttributeUsage(AttributeTargets.Class,AllowMultiple =true)]// Sadece Class larin ustune kullanilabilir demek
    //[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property)] Class ve Prop lara kullanilabilir demek
    class ToTableAttribute : Attribute
    {
        private string _tableName;

        public ToTableAttribute(string tableName)
        {
            _tableName = tableName;
        }
    }
}
