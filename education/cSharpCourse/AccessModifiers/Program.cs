using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    // Erisim Bildirgecleri ile calismak
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

    // private : sadece tanimlandigi blok icinde erisilebilir
    // protected : Miras islemlerinde de kullanilabilmesi icin private yerine protected kullanilir
    // public : disaridan baska projeler icin de erisimi mumkun kilar
    // internal : bagli bulundugu proje icerisinde referans ihtiyaci duymadan kullanilir.


    class Customer
    {
        protected int Id { get; set; }
        
        public void Save()
        {

        }
        public void Delete()
        {

        }
    }

    class Student : Customer
    {
        public void Save2()
        {
            Id = 1;
        }
    }

    // bir class'in default Access Modifier'i 'internal' dir.
    internal class Course
    {
        public string Name { get; set; }
    }

    // baska bir projeden de erisilebilmesini istiyorsak public olarak tanimlamaliyiz
    public class Rider
    {
        public string Name { get; set; }
    }
}
