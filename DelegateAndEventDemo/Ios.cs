using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndEventDemo
{
    public  delegate void Iosdele();
    public class Ios
    {
        public Iosdele Iosdele;
        public event Iosdele IosEvent;
        public Ios(int price)
        {
            _price = price;
        }
        public int _price;
        public int Price
        {
            set
            {
                if (this._price > value)
                {
                    IosEvent.Invoke();
                }
            }
            get
            {
                return _price;
            }
        }
    }
}
