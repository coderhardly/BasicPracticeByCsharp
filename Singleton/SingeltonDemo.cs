using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
   public class SingeltonDemo
    {
        private static SingeltonDemo singeltonDemo;
        private static SingeltonDemo singeltonDemo2;
        private static SingeltonDemo singeltonDemo3;
        public static Object sy = new object();
        private SingeltonDemo()
        {

        }
        //非多线程
        public static SingeltonDemo GetInstance()
        {
            if (singeltonDemo == null)
            {
                singeltonDemo = new SingeltonDemo();
            }
            return singeltonDemo;
        }
        //考虑多线程，但每次都加锁，耗资源
        public static SingeltonDemo GetInstance1()
        {
            lock (sy)
            {
                if (singeltonDemo2 == null)
                {
                    singeltonDemo2 = new SingeltonDemo();
                }
            }
            return singeltonDemo2;
        }
        public static SingeltonDemo GetInstance3()
        {
            if (singeltonDemo3 == null)
            {
                lock (sy)
                {
                    if (singeltonDemo3 == null)
                    {
                        singeltonDemo3 = new SingeltonDemo();
                    }
                }
            }
            return singeltonDemo2;
        }
    }
}
