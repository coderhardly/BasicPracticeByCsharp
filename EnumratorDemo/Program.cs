using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumratorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            EableEnumerator eableEnumerator = new EableEnumerator();
            var ie = eableEnumerator.GetEnumerator();
            Console.WriteLine("通过枚举器类来循环可枚举类型");
            while (ie.MoveNext())
            {
                Console.WriteLine(ie.Current);
            }
            foreach(var item in eableEnumerator)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("通过迭代器来循环可枚举类型");
            YieldEnumrator yieldEnumrator = new YieldEnumrator();
            foreach(var item in yieldEnumrator)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
