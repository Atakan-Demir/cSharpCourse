using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Value Types (Tam Sayılar) //

            /***********************************************************/

            // short , -32.768 ila 32.767 arasında değer alır
            //16 bit yer kaplar
            short number1 = -32768;
            Console.WriteLine("Short : {0}",number1);

            // int , -2.147.483.648 ila 2.147.483.647 arası değer alır
            // 32 bit yer kaplar
            int number2 = 2147483647;
            Console.WriteLine("İnt : {0}", number2);

            // long , -9.223.372.036.854.775.808 ila 9.223.372.036.854.775.807 arası değer alır
            // 64 bit yer kaplar
            long number3 = 9223372036854775807;
            Console.WriteLine("Long : {0}", number3);

            // byte , 0 ila 255 arasında değer alır
            byte number4 = 255;
            Console.WriteLine("Byte : {0}", number4);

            /***********************************************************/

            // Boolean //
            bool condition = false;
            Console.WriteLine("Bool : {0}", condition);
            /***********************************************************/

            // Strings //

            // Char tek karakter alır
            // int değerine çevrilebilir, ascii cod table daki değerini alır
            char character = 'a';
            Console.WriteLine("Char : {0}", character);
            Console.WriteLine("Char To İnt : {0}", (int)character);

            // string birden çok char alır
            string city = "Ankara";
            Console.WriteLine("String : {0}", city);

            /***********************************************************/

            // Floats // 

            // hem tam sayı hemde ondalıklı sayı alabilir
            double number5 = 14.6;
            Console.WriteLine("Double : {0}", number5);

            // int ve long da olduğu gibi double ve decimal de de daha hassas
            // değerler için kullanılı ve sonuna 'm' konur
            decimal number6 = 14.6m;
            Console.WriteLine("Decimal : {0}", number6);

            /***********************************************************/

            // enum //
            Console.WriteLine("Days.Friday : {0}", Days.Friday);
            // index sırasını verir
            Console.WriteLine("Days.Friday to İnt : {0}", (int)Days.Friday);


            Console.ReadLine();
        }
    }

    // Özel enum veri tipi tanımlama
    // Magic String
    enum Days
    {
        Monday,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday
    }
}
