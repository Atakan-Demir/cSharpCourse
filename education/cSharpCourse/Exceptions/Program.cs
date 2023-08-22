using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions // Hata Yonetimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ExeptionIntro();


            try
            {
                Find();
            }
            catch (RecordNotFoundException exeption)
            {
                Console.WriteLine(exeption.Message);
            }

            //method (action delegasyonu)
            HandleException(() =>
            {
                Find();
            });

            Console.ReadLine();
        }

        //parametresiz method blogu - Action Delegasyonu
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
