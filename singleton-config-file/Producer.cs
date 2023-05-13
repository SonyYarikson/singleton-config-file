using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singleton_config_file
{
    public class Producer : ISubject
    {
        private List<IObserver> subject;
        private string _change;
        public Producer(string p)
        {
            _change = p;
            subject = new List<IObserver>();
        }
        public void notifyObservers()
        {
            foreach (IObserver o in subject.ToList())
                o.update(_change);
        }

        public void registerObserver(IObserver o)
        {
            subject.Add(o);
        }

        public void removeObserver(IObserver o)
        {
            subject.Remove(o);
        }
        public void Change (string p)
        {
            _change = p;
            notifyObservers();
        }
    }
}
