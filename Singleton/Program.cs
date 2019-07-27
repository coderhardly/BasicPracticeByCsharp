using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            SingeltonDemo s1 = SingeltonDemo.GetInstance();
            SingeltonDemo s2 = SingeltonDemo.GetInstance();
            if (s1 == s2)
            {
                Console.WriteLine("equal");
            }
            object obj1 = null;
            object obj2 = null;
            Thread thread1 = new Thread(() =>
              {
                  obj1 = SingeltonDemo.GetInstance1();
              });
            
            thread1.Start();
            Thread thread2 = new Thread(() =>
            {
                obj2= SingeltonDemo.GetInstance1();
            });
            thread2.Start();
            thread1.Join();
            thread2.Join();
            if (obj2 != null && obj1 != null && obj2 == obj1)
            {
                Console.WriteLine("equal2");
            }
            Console.Read();
        }
    }
}
