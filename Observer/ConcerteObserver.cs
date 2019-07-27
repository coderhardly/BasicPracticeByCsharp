using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class ConcerteObserver:AbstractObserver
    {
        public string name;
        public ConcreteSubject subject;
        public string subjectState;
        public ConcerteObserver(ConcreteSubject subject, string name)
        {
            this.subject = subject;
            this.name = name;
        }
         public override void Update()
        {
            subjectState = subject.SubjectStste;
            Console.WriteLine("{0}{1}", name, subjectState);
        }
    }
}
