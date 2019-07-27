using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumratorDemo
{
    /// <summary>
    /// 可枚举类
    /// </summary>
   public class EableEnumerator
    {
        public string [] data = {"212","323","323"};
        public IEnumerator GetEnumerator()
        {
            return new MyEnumrator<string>(data);
        }
    }
}
