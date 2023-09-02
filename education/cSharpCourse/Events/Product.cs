using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    // elci
    public delegate void StockControl();
    public class Product
    {
        private int _stock;
        public Product(int stock)
        {
            _stock = stock;
        }

        //event tanimlama
        public event StockControl StockControlEvent;
        public string ProductName { get; set; }
        public int Stock
        {
            get { return _stock; }
            set
            {
                _stock = value;
                //sart saglanirsa StockControlEvent i calistir
                if (value<=15 &&  StockControlEvent != null)
                {
                    StockControlEvent();
                }
            }
        }


        public void Sell(int amount)
        {
            Stock -= amount;
            Console.WriteLine("{1} Stock amount: {0}", Stock,ProductName);
        }
    }
}
