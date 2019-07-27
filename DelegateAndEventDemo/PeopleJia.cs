using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndEventDemo
{
    public class PeopleJia
    {
        public PeopleJia(Ios ios)
        {
            ios.IosEvent += () =>
            {
                Console.WriteLine("jia said desCrementer");
            };
        }
    }
}
