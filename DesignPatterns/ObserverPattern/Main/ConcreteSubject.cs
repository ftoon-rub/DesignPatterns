﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ObserverPattern.Main
{
    /// <summary>
    /// SOLID Principle: Single Responsibility Principle (SRP)
    /// The ConcreteSubject class is responsible for managing its state and notifying observers when its state changes.

    /// </summary>
    public class ConcreteSubject : ISubject<string>
    {
        /// <summary>
        /// List of observers that need to be notified of changes
        /// </summary>
        private List<IObserver<string>> observers = new List<IObserver<string>>();
        /// <summary>
        /// Encapsulated state of the subject
        /// </summary>
        private string state;

        /// <summary>
        /// State property that, when changed, triggers notifications to observers
        /// </summary>
        public string State
        {
            get { return state; }
            set
            {
                state = value;
                // Notify observers when state changes
                NotifyObservers();
            }
        }

        /// <summary>
        /// Register an observer
        /// </summary>
        /// <param name="observer"></param>
        public void RegisterObserver(IObserver<string> observer)
        {
            observers.Add(observer);
        }

        /// <summary>
        /// Remove an observer
        /// </summary>
        /// <param name="observer"></param>
        public void RemoveObserver(IObserver<string> observer)
        {
            observers.Remove(observer);
        }

        /// <summary>
        /// Notify all observers of a state change
        /// </summary>
        public void NotifyObservers()
        {
            foreach (var observer in observers)
            {
                // Push model: directly send the state to the observer
                observer.Update(state);

                // Pull model: just notify the observer, who will then pull the state
                observer.Update();
            }
        }
    }
}
