using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Program
    {   /// <summary>
    /// 利用抽象类和接口实现观察者模式，利用事件实现见事件代码
    /// </summary>
    /// <param name="args"></param>
        static void Main(string[] args)
        {
            ConcreteSubject subject = new ConcreteSubject();
            subject.Attach(new ConcerteObserver(subject, "jia"));
            subject.Attach(new ConcerteObserver(subject, "binf"));
            subject.Attach(new ConcerteObserver(subject, "yi"));
            subject.SubjectStste = "12121";
            subject.Notify();
            Console.Read();

        }
    }
}
