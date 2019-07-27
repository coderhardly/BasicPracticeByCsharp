using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndEventDemo
{
    class Program
    {
        static void Main(string[] args)
        {  //委托和事件的比较，事件是阉割的委托实例
            Ios ios = new Ios(3500);
            ios.Iosdele = () => { Console.WriteLine("delegate1"); };
            ios.Iosdele+= () => { Console.WriteLine("delegate2"); };
            ios.Iosdele += () => { Console.WriteLine("delegate3"); };
            ios.Iosdele.Invoke();//委托实例可以在类外被调用，而事件不可以
            //ios.IosEvent = () => { Console.WriteLine("event0"); };
            ios.IosEvent += () => { Console.WriteLine("event1"); };
            ios.IosEvent+= () => { Console.WriteLine("event2"); };
            ios.IosEvent-= () =>{ Console.WriteLine("event2"); };
           
            //标准的点击事件
            ClickEvent en = new ClickEvent();
            ClickEventArgs eventArgs = new ClickEventArgs();
            en.clickEvent += Btn_click;
            en.Click(eventArgs);
            //利用观察者模式案例
            PeopleJia jia = new PeopleJia(ios);
            PeopleTwo two = new PeopleTwo(ios);
            ios.Price = 3200;
            Console.ReadKey();

        }
        //自己写的业务代码
        public static void Btn_click(Object Senter,EventArgs e)
        {
            Console.WriteLine("click proces");
            Console.WriteLine(e.GetType().GetProperties());
        }
    }
}
