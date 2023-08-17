using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //intro();

            string sentence = "My name is Atakan Demir";

            var result = sentence.Length; // Kac karakter
            var result2 = sentence.Clone(); // Artik bellekte farkli hucreleri isaret ediyorlar
            sentence = "My name is Dünya Demir";

            bool result3 = sentence.EndsWith("r"); // Bu string 'r' ile bitiyor mu? 
            bool result4 = sentence.EndsWith("My name"); // Bu string 'My name' ile basliyor mu? 

            var result5 = sentence.IndexOf("name"); // 'name' kacinci indexten baslar ; bulamazsa -1 dondurur
                                                    // soldan ilk bulduğu indexi dondurur

            var result6 = sentence.LastIndexOf("name"); // aramaya sagdan baslar

            var result7 = sentence.Insert(0,"Hello, "); // bir string ifadeye baska bir stringi enjekte etmek icin kullanilir
            var result8 = sentence.Substring(3); // 3. karakterden itibaren al demek 
            var result9 = sentence.Substring(3,4); // 3. karakterden itibaren 4 tane al demek 

            var result10 = sentence.ToLower(); // butun karakterleri kucuge cevirir
            var result11 = sentence.ToUpper(); // butun karakterleri buyuge cevirir

            var result12 = sentence.Replace(" ","-"); // metin icindeki karakterleri baska karakterlerle degistirme

            var result13 = sentence.Remove(2); // 2. indexten itibaren sil
            var result14 = sentence.Remove(2,5); // 2. indexten 5'e kadar sil

            Console.WriteLine(result14);

            Console.ReadLine();
        }

        private static void intro()
        {
            string city = "Ankara";

            //Console.WriteLine(city[0]);

            foreach (var item in city)
            {
                Console.WriteLine(item);
            }

            string city2 = "İstanbul";
            string result = city + city2;
            Console.WriteLine(result);

            // format
            Console.WriteLine(String.Format("{0} {1}", city, city2));
        }
    }
}
