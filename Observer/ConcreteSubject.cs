using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
   public class ConcreteSubject:AbstractSubject
    {
        public string subjectState;
        public string SubjectStste
        {
            get
            {
                return subjectState;
            }
            set
            {
                subjectState = value;
            }
        }
    }
}
