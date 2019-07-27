
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace InitnalClass
{
   public class BaseClass
    {
        public static int a;
        public static int b;
        public int c;
        public int d;
        static BaseClass()
        {
            a = 1;
            b = 2;
        }
        public BaseClass()
        {
            c = 3;
            d = 4;
        }
    }
}