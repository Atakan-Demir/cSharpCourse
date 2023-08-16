using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (IsPrimeNumber(6))
            {
                Console.WriteLine("This is prime number");
            }
            else
            {
                Console.WriteLine("This is not a prime number");
            }

            /*
            // for
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(i);
            }

            // while
            int number = 100;
            while (number >= 0)
            {
                number--;
                Console.WriteLine(number);
            }

            // do while
            int number2 = 10;
            do
            {
                Console.WriteLine(number2);
                number2--;
            } while (number2>=11);

            // foreach
            string[] students = { "Engin", "Atakan", "Emral" };
            foreach (var student in students)
            {
                //student = "başka bir string"  >>> foreach dongu icinde degisken degistirmeye izin vermez
                Console.WriteLine(student);
            }
            */




            Console.ReadLine();
        }

        private static bool IsPrimeNumber(int num)
        {
            bool result = true;

            for (int i = 2; i < num - 1; i++)
            {
                if (num % i == 0)
                {
                    result = false;
                    break;
                }

            }
            return result;

        }
    }
}
