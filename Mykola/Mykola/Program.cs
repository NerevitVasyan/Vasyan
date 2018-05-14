using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mykola
{
    class User
    {
        public string Login { get; set; }
        private int Password { get; set; }
    }

    class Person
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mykola");
            Console.WriteLine("Vitaly");
            Console.WriteLine("zxczxc");
        }
    }
}
