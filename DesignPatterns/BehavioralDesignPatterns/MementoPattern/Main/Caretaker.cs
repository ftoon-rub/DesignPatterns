using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehavioralDesignPatterns.MementoPattern.Main
{
    /// <summary>
    /// // Caretaker class that manages the Mementos
    /// - SRP: Caretaker only manages the history of Mementos; it does not deal with state logic.
    /// - OCP: Can be extended to manage multiple Originators or support advanced features like redo without modification.
    /// - DIP: Caretaker depends on abstractions (Memento) and not concrete details of the originator's implementation.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Caretaker<T>
    {
        /// <summary>
        /// OOP: Encapsulation - The history stack is private and not directly accessible from the outside.
        /// </summary>
        private readonly Stack<Memento<T>> _history = new Stack<Memento<T>>();


        /// <summary>
        /// Save the current state of the originator
        /// - ISP: The Caretaker interface is clean and only provides the necessary functionality.
        /// </summary>
        /// <param name="originator"></param>
        public void SaveState(Originator<T> originator)
        {
            _history.Push(originator.SaveState());
        }

        /// <summary>
        /// Undo the last state change
        /// - SRP: Caretaker does not know the internal details of the state, it just manages Mementos.
        /// </summary>
        /// <param name="originator"></param>
        public void Undo(Originator<T> originator)
        {
            if (_history.Count > 0)
            {
                var memento = _history.Pop();
                originator.RestoreState(memento);
            }
        }
    }
}
