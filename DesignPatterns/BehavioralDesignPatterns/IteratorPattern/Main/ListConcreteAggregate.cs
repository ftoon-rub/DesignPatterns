using DesignPatterns.IteratorPattern.Main;
using DesignPatterns.IteratorPattern.Solution;

namespace DesignPatterns.BehavioralDesignPatterns.IteratorPattern.Main
{
    /// <summary>
    /// Represents a concrete collection that can be iterated over.
    /// 
    /// - Open/Closed Principle (SOLID): This class can be extended with additional functionalities without modifying its existing code.
    /// - Encapsulation (OOP): Manages the internal list and exposes only necessary operations.
    /// </summary>
    /// <typeparam name="T">The type of elements in the collection.</typeparam>
    internal class ListConcreteAggregate<T> : IAggregate<T>
    {
        // Encapsulation (OOP): The internal list is private to the class.
        private List<T> _list = new();
        /// <summary>
        /// Gets or sets the internal list.
        /// 
        /// - Encapsulation (OOP): Controls access to the internal list.
        /// </summary>
        public List<T> list { get { return _list; } set { _list = value; } }
        /// <summary>
        /// Creates an iterator for the internal list.
        /// 
        /// - Single Responsibility Principle (SOLID): This method is dedicated to creating an iterator.
        /// - Dependency Injection: Injects the internal list into the iterator.
        /// </summary>
        /// <returns>A new iterator for the internal list.</returns>
        public IIterator<T> CreateIterator()
        {
            return new ListConcreteIterator<T>(_list);
        }

        /// <summary>
        /// Removes and returns the last item from the collection.
        /// 
        /// - Single Responsibility Principle (SOLID): This method handles removing the last item.
        /// - Defensive Programming: Checks if the list is empty before attempting to remove an item.
        /// </summary>
        /// <returns>The last item in the collection, or default if the collection is empty.</returns>

        public T Pop()
        {
            if (_list.Count < 1)
                return default;
            var lastUrl = _list[_list.Count - 1];
            _list.RemoveAt(_list.Count - 1);
            return lastUrl;
        }

        /// <summary>
        /// Adds an item to the collection.
        /// 
        /// - Single Responsibility Principle (SOLID): This method handles adding an item.
        /// </summary>
        /// <param name="item">The item to add to the collection.</param>
        public void Push(T item)
        {
            _list.Add(item);
        }
    }
}
