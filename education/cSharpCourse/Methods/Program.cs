using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = 10;
            int number2 = 20;
            int number3 ;
            //add();
            var result = add3(ref number1, number2);
            var result2 = add3_out(out number3, number2);
            Console.WriteLine(result);
            Console.WriteLine(result2);

            Console.WriteLine(Multiply(2,4));
            Console.WriteLine(Multiply(2, 4,8));

            Console.WriteLine(add4(2, 8, 10, 1));

            Console.ReadLine();
        }
        // void : git bir yere bişey yaz yada git bir yere işlem yap demek
        
        static void add() 
        {
            Console.WriteLine("Added!");
        }

        // Temel olarak birkaç keyframe vardır. Örnek geri döner tip değerine
        // 'void' yerine 'int' vermek o method dan 'int' türünde değer döneceğini
        // belirtir ve bu önemlidir.

        // number2 verilmezse defualt olarak 30 değerini al demek için 'int number2 = 30'
        static int add2(int number1,  int number2)
        {
            return number1 + number2;
        }

        // bu methodda Main() deki number1 değişkenini değer olarak değil
        // referans olarak gönderdik ve içeride yapılan değişiklik number1'in
        //gerçek değerini de kalıcı olarak etkiledi
        // Methodun içinde bir kere set edilmesi gerekir
        static int add3(ref int number1, int number2)
        {
            number1 = 30;
            return (number1 + number2);
        }

        // 'out' keyframe kullanılabilir. 'ref' den farkı gönderilen değişkenin
        // değerinin olma zorunluluğu yoktur
        static int add3_out(out int number3, int number2)
        {
            number3 = 30;
            return (number3 + number2);
        }

        // Method Overloading
        static int Multiply(int  number1, int number2)
        {
            return number1 * number2;
        }
        static int Multiply(int number1, int number2, int number3)
        {
            return number1 * number2 * number3;
        }

        // params keyframe ile çalışmak

        static int add4(params int[] numbers)
        {
            return numbers.Sum();
        }
    }

}
