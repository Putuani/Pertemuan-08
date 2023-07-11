using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance1
{
    public class Person
    {

  
       //Property
       public string Name;
       public int Age;

       //constructor
       public Person(string Name, int Age)
       {
            this.Name = Name;
            this.Age = Age;
       }

       public Person()
       {

       }

       //Fungsi
       public void InfoPerson()
       {
            Console.WriteLine("Nama saya {0}, dan umur saya {0}, tahun", this.Name, this.Age);
       }
    }

        // class turunan
        public class karyawan : Person
        {
            //property class turunan
            public string karyawanID { set; get; }
            public string subject { set; get; }

            //overide method
            public void InfoPerson(string subject)
            {
                //this
                this.subject = subject;
                Console.WriteLine("Nama saya {0}, dan umur saya {0}, tahun", this.subject);
            }
        }

    
}
