using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumratorDemo
{
   public class YieldEnumrator
    {
        public string[] data = { "wewe", "3232", "wqeqw" };
        /// <summary>
        /// 获取枚举器
        /// </summary>
        /// <returns></returns>
        public IEnumerator<string> GetEnumerator()
        {
            return YiledGetEnumable();
        }
        /// <summary>
        /// 迭代器产生枚举器
        /// </summary>
        /// <returns></returns>
        public IEnumerator<string> YiledGetEnumable()
        {
            for(int i = 0; i < data.Length; i++)
            
                yield return data[i];
        }
    }
}
