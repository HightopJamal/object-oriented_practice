using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdxModule6
{   abstract class Person
    {
        private string firstname;
        private string lastname;
        private string streetaddress;
        private int zip;
        private string city;

        public string First
        {
            get
            {
                return firstname;
            }
            set
            {
                firstname = value; 
            }
        }

        public string Last
        {
            get { return lastname; }
            set { lastname = value; }
        }

        public string 

        public Person(string firstname, string lastname, string streetaddress, int zip, string city)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.streetaddress = streetaddress;
            this.city = city;
            this.zip = zip;
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
