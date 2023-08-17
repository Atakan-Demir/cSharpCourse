using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Customer //Musteri ozelliklerinin tutulacagi alan. 
    {
        //---> Genel Kullanim | property<---//


        /*
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        */



        //---> encapsulation (kapsulleme) <---//
        public int Id { get; set; }

        private string _firstName;
            // deger alip pkurken baska seyler yapmak istersek kapsulleme teknigini kullanmamız gerekir
        public string FirstName 
        { 
            get { return "Mr." + _firstName; } 
            set { _firstName = value; } 
        }
        public string LastName { get; set; }
        public string City { get; set; }

    }
}
