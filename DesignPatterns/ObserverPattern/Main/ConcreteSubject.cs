using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ObserverPattern.Main
{
    public class ConcreteSubject : ISubject<string>
    {
        private List<IObserver<string>> observers = new List<IObserver<string>>();
        private string state;

        public string State
        {
            get { return state; }
            set
            {
                state = value;
                NotifyObservers();
            }
        }

        public void RegisterObserver(IObserver<string> observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver<string> observer)
        {
            observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (var observer in observers)
            {
                // Push model
                observer.Update(state);

                // Pull model
                observer.Update();
            }
        }
    }
}
