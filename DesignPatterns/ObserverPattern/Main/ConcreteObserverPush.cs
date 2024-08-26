using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ObserverPattern.Main
{
    public class ConcreteObserverPush : IObserver<string>
    {
        public void Update(string data)
        {
            Console.WriteLine($"Push Observer: Received data: {data}");
        }

        // This method isn't used in push model
        public void Update() { }
    }
}
