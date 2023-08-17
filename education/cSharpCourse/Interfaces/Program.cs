using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //InterfacesIntro();
            //GercekHayatInterfaceKukkanimi1();

            // Interface lerden nesne turetilemez 'new IPerson()'. Onun Yerine Customer ve Student Turetilebilir.
            IPerson person = new Customer();


            // Asagidaki ornekteki amac Sirketin butun veritabanlarina islem yaptirtmaktir.
            ICustomerDal[] customerDals = new ICustomerDal[3]
            {
                new SqlServerCustomerDal(),
                new OracleCustomerDal(),
                new MySqlCustomerDal()
            };

            foreach (var customerDal in customerDals)
            {
                customerDal.Add();   
            }

        }

        private static void GercekHayatInterfaceKukkanimi1()
        {
            CustomerManager manager = new CustomerManager();
            manager.Add(new SqlServerCustomerDal());
            manager.Add(new OracleCustomerDal());
        }

        private static void InterfacesIntro()
        {
            PersonManager personManager = new PersonManager();
            personManager.Add(new Customer
            {
                Id = 1,
                FirstName = "Atakan",
                LastName = "Demir",
                Adress = "İstanbul"
            });

            Student student = new Student
            {
                Id = 1,
                FirstName = "Ahmet",
                LastName = "Ozcan",
                Departmant = "AKDÜ"
            };

            personManager.Add(student);
        }
    }

    // classlar somut intefaceler soyuttur. Ornek olarak Customer ve Student classlarimiz var. Bunlarin ikiside
    // ayri classlardir ama neticede ikisi de bir 'kisi' dir. IPerson yazılması 'Interface Person' anlamına gelir.
    // bu yuzden 'Person' un basina 'I' konulur. Bu zorunlu degildir ancak profesyonellik acisindan onemlidir.
    interface IPerson
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }
    class Customer : IPerson
    {
        //--
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        //--
        public string Adress { get; set; } // IPerson interface inin ozellikleri haricinde Customer'a ozel olan property
    }
    class Student : IPerson
    {
        //--
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        //--
        public string Departmant { get; set; } // IPerson interface inin ozellikleri haricinde Student'a ozel olan property
    }

    class PersonManager
    {
        /* Add(veri Turu) ; 'veri Turu' nu Customer yada Student verirsek diger classtan olusturulan nesneleri
         * gonredemeyiz. Ancak iki class da ': IPerson' ile implemente edildigi icin 'veri Turu' 'IPerson' olursa
         * iki class icin de kullanılabilir bir method olmus olur. Interface yapısı burda onem arz etmektedir.
         */ 
        public void Add(IPerson person) 
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
