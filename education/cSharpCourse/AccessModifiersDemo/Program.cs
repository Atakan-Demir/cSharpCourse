using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccessModifiers; // import

namespace AccessModifiersDemo
{
    internal class Program
    {
        // once referanslara 'AccessModifiers' i ekle
        // sonra using ile import et
        static void Main(string[] args)
        {
            // class public olmadigi icin erisilemiyor
            // Coruse course = new Coruse();

            // Rider class'i publictir bu sebepten dolayi erisilebilmistir  
            Rider rider = new Rider();
        }
    }
}
