using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.Name = "putu";
            person1.Age = 19;
            person1.InfoPerson();

            //inthertance
            karyawan karyawan1 = new karyawan();
            karyawan1.Name = "putu";
            karyawan1.Age = 20;
            karyawan1.InfoPerson();
            karyawan1.InfoPerson("Dosen");

            Console.ReadKey();
        }
    }
}
        
