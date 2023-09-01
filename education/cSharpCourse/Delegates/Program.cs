using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates // Elciler
{
    // elcilik olusturuldu
    public delegate void MyDelegate();
    
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
    }
}
