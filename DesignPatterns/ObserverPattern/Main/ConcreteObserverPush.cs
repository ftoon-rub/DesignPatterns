using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ObserverPattern.Main
{
    /// <summary>
    /// SOLID Principle: Single Responsibility Principle (SRP)
    /// The ConcreteObserverPush class is responsible for receiving updates (data) from the subject in the push model.

    /// </summary>
    public class ConcreteObserverPush : IObserver<string>
    {
        /// <summary>
        /// Method to receive pushed data
        /// </summary>
        /// <param name="data"></param>
        public void Update(string data)
        {
            Console.WriteLine($"Push Observer: Received data: {data}");
        }

        /// <summary>
        /// Unused in Push model, but part of the interface contract (could be avoided with separate interfaces)
        /// </summary>
        public void Update() { }
    }
}
