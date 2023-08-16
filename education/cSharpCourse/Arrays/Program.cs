using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] students = new string[3];
            students[0] = "Engin";
            students[1] = "Derin";
            students[2] = "Sa1ihl";
            

            string[] students2 = {"Engin","Derin","Salih"};

            foreach (var student in students2)
            {

                //Console.WriteLine(student);
                
            }

            // Cok boyutlu diziler

            string[,] regions = new string[5, 3]//5 satir 3 sutun
            {
                {"İstanbul","Edirne","Balıkesir" },
                {"Ankara","Konya","Kırıkkale" },
                {"Antalya","Adana","Mersin" },
                {"Rize","Trabzon","Samsun" },
                {"İzmir","Muğla","Manisa" }
            };

            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i,j]);
                }
                Console.WriteLine("*******");
            }


            Console.WriteLine();
            Console.ReadLine();

        }

    }
}
