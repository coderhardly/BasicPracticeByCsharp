using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndEventDemo
{
   public class ClickEvent
    {
        public event Action<object, EventArgs> clickEvent;
        public void Click(EventArgs e)
        {
            if (clickEvent != null)
            {
                clickEvent(this, e);
            }
        }
    }
    public class ClickEventArgs : EventArgs
    {
        public string description = "clickParamater";
    }
}
