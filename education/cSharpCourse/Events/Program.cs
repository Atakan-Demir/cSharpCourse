using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //stok da 50 adet var
            Product harddisk = new Product(50)
            {
                ProductName = "Hard Disk"
            };

            Product phone = new Product(50)
            {
                ProductName = "Phone"
            };
            // phone StockControlEvent olayina abone oldu
            phone.StockControlEvent += Phone_StockControlEvent;
            for (int i = 0; i < 10; i++)
            {
                //satislar yapiliyor
                harddisk.Sell(10);
                phone.Sell(10);

                Console.ReadLine();
            }

            Console.ReadLine();
        }

        private static void Phone_StockControlEvent()
        {
            Console.WriteLine("Phone about to finish !!!");
        }
    }
}
