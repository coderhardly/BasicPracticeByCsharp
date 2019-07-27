using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumratorDemo
{
    /// <summary>
    /// 枚举器类
    /// </summary>
    public class MyEnumrator<T> : IEnumerator
    {
        public T[] Arr;
        public int position=-1;
        public MyEnumrator(T[] myarr){
            Arr = new T[myarr.Length];
            for(int i = 0; i < myarr.Length; i++)
            {
                Arr[i] = myarr[i];
            }
            }
        public object Current {
            get
            {
                return (position > Arr.Length || position < 0) ? default(T) : Arr[position];
            }

        }
        public bool MoveNext()
        {
            if (position < Arr.Length - 1)
            {
                position++;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Reset()
        {
            position = -1;
        }
    }
}
