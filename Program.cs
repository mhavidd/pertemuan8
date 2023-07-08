using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pewarisan
{
    class Program
    {
        static void Main(string[] args)
        {
            Person Person1 = new Person();
            Person1.Name = "Meysi";
            Person1.Age = 19;
            Person1.InfoPerson();

            Karyawan Karyawan1 = new Karyawan();
            Karyawan1.Name = "Havid";
            Karyawan1.Age = 21;
            Karyawan1.InfoPerson();
            Karyawan1.InfoPerson("Dosen", "2211320");

            Console.ReadLine();
        }
    }
}
