using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceAndValueType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //deger tip 
            int number1 = 10;
            int number2 = 20;
            number2 = number1;
            number1 = 30;

            Console.WriteLine(number2); // 10 cikacaktir cunku 16. satirda number1'in o anki degeri number2'ye atandi

            // referans tip
            string[] cities1 = new string[] {"Ankara","Adana","Afyon"}; //101: bellekteki referans adresi
            string[] cities2 = new string[] {"Bursa","Bolu","Balıkesir"}; //102: bellekteki referans adresi

            // asagida yapilan islem bellek teki 'cities2' referansinin 'cities1'in referansini almasini saglar
            // dolayisiyla 102 referansinda tutulan veriler gider
            // cunku artik 'cities2' bellekte 101 adresini isaret ediyordur
            cities2 = cities1;
            cities1[0] = "İstanbul";
            Console.WriteLine(cities2[0]);


            // 'new' leme isleme bellek icin bir yuktur. eger iki degisken ayni referansi gosterecek ise
            // dt = new yapmaya gerek yoktur. Bu verimliligi arttirir.
            DataTable dt;
            DataTable dt2 = new DataTable();
            dt = dt2;

            Console.ReadLine();
        }
    }
}
