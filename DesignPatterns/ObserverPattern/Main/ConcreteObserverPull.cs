using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ObserverPattern.Main
{
    /// <summary>
    /// SOLID Principle: Dependency Inversion Principle (DIP)
    /// The ConcreteObserverPull class depends on the abstraction (interface) rather than a specific implementation of the subject.
    /// OOP Principle: Inheritance and Polymorphism
    /// The ConcreteObserverPull class inherits from the IObserver<T> interface and provides a specific implementation for the Pull model.
    /// </summary>
    public class ConcreteObserverPull : IObserver<string>
    {
        private ConcreteSubject subject;

        /// <summary>
        /// Constructor injects the subject, following DIP by depending on an abstraction
        /// </summary>
        /// <param name="subject"></param>
        public ConcreteObserverPull(ConcreteSubject subject)
        {
            this.subject = subject;
        }

        /// <summary>
        /// Pull model: the observer pulls the state from the subject
        /// </summary>
        public void Update()
        {
            string data = subject.State; // Pull the data from the subject
            Console.WriteLine($"Pull Observer: Pulled data: {data}");
        }

        /// <summary>
        ///  Unused in Pull model, but part of the interface contract
        /// </summary>
        /// <param name="data"></param>
        public void Update(string data) { }
    }
}
