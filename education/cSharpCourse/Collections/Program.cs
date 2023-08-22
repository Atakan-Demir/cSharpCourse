using System;
using System.Collections; // import
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ArrayList();
            //List();

            Dictionary<string,string> dictionary = new Dictionary<string,string>();
            dictionary.Add("book", "kitap");
            dictionary.Add("pencil", "kalem");
            dictionary.Add("computer", "bilgisayar");

            Console.WriteLine(dictionary["computer"]);
            

            foreach (var item in dictionary)
            {
                Console.WriteLine(item.Key);
            }

            // Console.WriteLine(dictionary["glass"]);    >> hata olusur cunku 'glass' anahtari mevcut degil

            Console.WriteLine(dictionary.ContainsKey("glass")); // Programi hataya dusurmez. 'glass' anahtari var mi diye sorar. true-false
            Console.WriteLine(dictionary.ContainsKey("computer"));
            
            Console.ReadLine();
        }

        private static void List()
        {
            //>>> Tip guvenli koleksiyonlarla calismak <<<

            List<string> cities = new List<string>();
            cities.Add("İstanbul");
            cities.Add("Ankara");



            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }

            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer { Id = 1, FirstName = "Atakan" });
            customers.Add(new Customer { Id = 2, FirstName = "Ahmet" });
            /*
            foreach (var customer in customers)
            {
                Console.WriteLine(customer.FirstName);
            }
            */
            //>>> Collection ozellik ve methodlariyla calısmak 1 <<<

            Console.WriteLine(cities.Contains("Ankara")); // bu deger listede varmi? true-false
            var count = customers.Count; // eleman sayisi
            var customer1 = new Customer
            {
                Id = 3,
                FirstName = "Salih"
            };
            customers.Add(customer1);

            customers.AddRange(new Customer[2] // diziler halinde de eklemeler yapilabilir
            {
                new Customer { Id = 4,FirstName="Ali"},
                new Customer { Id = 5,FirstName="Ayşe"}
            });

            var index = customers.IndexOf(customer1); // kacinci indexte oldugunu bastan aramaya baslar
            Console.WriteLine("index : {0}", index);

            var index2 = customers.LastIndexOf(customer1); // kacinci indexte oldugunu sondan aramaya baslar
            Console.WriteLine("index : {0}", index2);

            customers.Insert(0, customer1); // verilen index numarasinda nlisteye ekleme yapar. Add() liste sonuna ekler. Insert() istenilen yere ekler

            customers.Remove(customer1); // ilk buldugunu siler. bulmaazsa birsey yapmaz

            customers.RemoveAll(c => c.FirstName == "Salih"); // musterilerden adi 'Salih' olan herkesi sil


            customers.Clear(); // listeyi temizler
            foreach (var customer in customers)
            {
                Console.WriteLine(customer.FirstName);
            }
        }

        private static void ArrayList()
        {
            ArrayList cities = new ArrayList();
            cities.Add("Ankara");
            cities.Add("Adana");
            cities.Add("İstanbul");
            //Console.WriteLine(cities[2]);
            cities.Add(1);
            cities.Add('A');

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }
        }
    }

    class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
    }
}
