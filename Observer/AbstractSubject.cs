
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Observer
{
   public abstract class AbstractSubject
    {
        public IList<AbstractObserver> abstractObservers = new List<AbstractObserver>();
        public void Attach(AbstractObserver observer)
        {
            abstractObservers.Add(observer);
        }
        public void Remove(AbstractObserver observer)
        {
            abstractObservers.Remove(observer);
        }
        public void Notify()
        {
            foreach(var item in abstractObservers)
            {
                item.Update();
            }
        }
    }
}