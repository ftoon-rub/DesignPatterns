using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ObserverPattern.Main
{
    public class ConcreteObserverPull : IObserver<string>
    {
        private ConcreteSubject subject;

        public ConcreteObserverPull(ConcreteSubject subject)
        {
            this.subject = subject;
        }

        public void Update()
        {
            string data = subject.State; // Pull the data
            Console.WriteLine($"Pull Observer: Pulled data: {data}");
        }

        // This method isn't used in pull model
        public void Update(string data) { }
    }
}
