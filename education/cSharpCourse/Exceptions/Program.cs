using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exceptions // Hata Yonetimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ExeptionIntro();

            //TryCatch();

            //ActionDemo();

            //>>> Func ile Calismak <<<
            // <parametre,parametre,cikti>
            Func<int, int, int> add = Topla;
            Console.WriteLine(add(3, 5));

            // parametresiz delegate 
            Func<int> getRandomNumber = delegate ()
            {
                Random random = new Random();
                return random.Next(1, 100);
            };


            // lambda kullanimi
            Func<int> getRandomNumber2=()=> new Random().Next(1,100);

            Console.WriteLine(getRandomNumber());
            Thread.Sleep(1000); // 1 saniye bekle
            Console.WriteLine(getRandomNumber2());

            Console.ReadLine();
        }

        static int Topla(int x,int y)
        {
            return x + y;
        }

        private static void ActionDemo()
        {
            //method (action delegasyonu)
            HandleException(() =>
            {
                Find();
            });
        }

        private static void TryCatch()
        {
            try
            {
                Find();
            }
            catch (RecordNotFoundException exeption)
            {
                Console.WriteLine(exeption.Message);
            }
        }

        //parametresiz method blogu - Action Delegasyonu
        //burada method blogu action a denk gelir ve try-catch icinde action Invoke edilir.
        private static void HandleException(Action action)
        {
            try
            {
                action.Invoke(); // gelen kod blogunu calistir demek
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private static void Find()
        {
            List<string> students = new List<string> { "Atakan", "Ahmet", "Derin" };

            if (!students.Contains("Ali"))
            {
                throw new RecordNotFoundException("Record Not Found!");
            }
            else
            {
                Console.WriteLine("Record Found!");
            }
        }

        private static void ExeptionIntro()
        {
            /*>>>BUTUN HATALAR Exeption 'dan inherite edilir<<<*/
            try
            {
                string[] students = new string[3] { "Atakan", "Derin", "Ahmet" };
                students[3] = "Alim";
            }
            catch (DivideByZeroException err) // 0 a bolunme hatasi ise
            {
                Console.WriteLine(err.Message);
            }
            catch (IndexOutOfRangeException) // eger alınan hata bu ise
            {
                Console.WriteLine();
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message); // hata mesajini verir
                Console.WriteLine(err.InnerException); // varsa daha detayli bilgi verir
            }
        }
    }
}
