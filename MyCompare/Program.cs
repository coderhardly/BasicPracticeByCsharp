using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCompare
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine( MyCompare("ab", "ab"));
            int a = 'B' - 'b';
            Console.WriteLine(a);
            Console.ReadKey();
        }
        //自己实现一个字符串比较函数
        static int MyCompare(string a,string b)
        {
            var c = a.ToCharArray();
            var d = b.ToCharArray();
            int i = 0;
            while(i<c.Length&&i<b.Length ){
                if (c[i] == d[i])
                {
                    i++;
                }
                else
                {
                    return (c[i]+32) - (d[i]+32);
                }
            }
            if (i < c.Length || i < d.Length)
            {
                return c.Length - b.Length;
            }
            return 0;
        }
    }
}
