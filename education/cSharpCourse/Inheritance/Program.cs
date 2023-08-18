using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance // Kalitim - Miras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[3]
            {
                new Person
                {
                    FirstName = "Atakan"
                },
                new Customer
                {
                    FirstName = "Ahmet"
                },
                new Student
                {
                    FirstName = "Alim"
                }
            };

            foreach (var person in persons)
            {
                Console.WriteLine(person.FirstName);
            }

            Console.ReadLine();
        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    // Customer'in ebeveyni Person'dur. Customer babasinin ozelliklerini tasir. Ancak her cocuk babasi degildir.
    // kendi bireysel ozellikleri de vardir. Person'un ozellikleri haricinde Customer'in 'City' property si de vardir.
    class Customer : Person 
    {
        public string City { get; set; }
    }

    class Student : Person
    {
        public string Departmant { get; set; }
    }

}   

