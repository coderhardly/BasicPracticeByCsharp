using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndEventDemo
{
   public  class PeopleTwo
    {
        public   PeopleTwo(Ios ios)
        {
            ios.IosEvent += () =>
            {
               Console.WriteLine("yi said descrementer");
            };
        }
    }
}
