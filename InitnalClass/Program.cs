using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitnalClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DrieveClass.a);
            Console.WriteLine(DrieveClass.b);
            DrieveClass drieve = new DrieveClass();
            
            Console.WriteLine(drieve.c);
            Console.WriteLine(drieve.d);
            Console.WriteLine(drieve.e);
           
            Console.ReadKey();
        }
    }
}
