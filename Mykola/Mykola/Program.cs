using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mykola
{
    class Car
    {
        public object Percon { get; set; }
        public int Chear { get; set; }
        public int Nomber { get; set; }

        public Car(object p,int c,int n)
        {
            Percon = p;
            Chear = c;
            Nomber = n;
        }
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
