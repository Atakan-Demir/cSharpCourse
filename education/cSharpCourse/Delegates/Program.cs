using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates // Elciler
{
    // elcilik olusturuldu
    public delegate void MyDelegate();
    public delegate void MyDelegate2(string text);
    // geri deger donduren bir delege varsa en sonki islemin degerini dondurur
    public delegate int MyDelegate3(int sayi1,int sayi2);
    
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            //customerManager.SendMessage();
            //customerManager.ShowAlert();

            // elciye gorev verildi
            MyDelegate myDelegate = customerManager.SendMessage;
            //elciye gorev eklendi
            myDelegate += customerManager.ShowAlert;
            // elcinin gorevi iptal ediliyor
            myDelegate -= customerManager.SendMessage;
            // elci gorevini yapiyor 
            myDelegate();


            MyDelegate2 myDelegate2 = customerManager.WriteMessage;
            myDelegate2 += customerManager.WriteAlert;
            myDelegate2("Say my name!");


            Matematik matematik = new Matematik();
            MyDelegate3 myDelegate3 = matematik.Topla;
            myDelegate3 += matematik.Carp;
            var sonuc = myDelegate3(2, 3);
            Console.WriteLine(sonuc);

            Console.ReadLine();
        }
    }
    public class CustomerManager
    {
        public void SendMessage()
        {
            Console.WriteLine("Hello!");
        }
        public void ShowAlert()
        {
            Console.WriteLine("Be careful!");
        }
        public void WriteMessage(string message)
        {
            Console.WriteLine(message);
        }
        public void WriteAlert(string alert)
        {
            Console.WriteLine(alert);
        }
    }
    public class Matematik
    {
        public int Topla(int sayi1,int sayi2)
        {
            return sayi1 + sayi2;
        }
        public int Carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }
    }
}
