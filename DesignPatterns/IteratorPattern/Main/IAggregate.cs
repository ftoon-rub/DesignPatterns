
using DesignPatterns.IteratorPattern.Main;

namespace DesignPatterns.IteratorPattern
{
    /// <summary>
    /// Defines the interface for collections that will return iterators.
    /// 
    /// - Interface Segregation Principle (SOLID): IAggregate interface is focused on a single responsibility.
    /// - Encapsulation (OOP): Provides a way to expose iterator creation and basic stack operations.
    /// </summary>
    /// <typeparam name="T">The type of elements in the aggregate.</typeparam>
    public interface IAggregate<T>
    {
        /// <summary>
        /// Creates an iterator for the collection.
        /// - Single Responsibility Principle (SOLID): This method is dedicated to creating iterators.
        /// </summary>
        IIterator<T> CreateIterator();
        /// <summary>
        /// Adds an item to the collection.
        /// - Single Responsibility Principle (SOLID): This method is dedicated to adding items.
        /// </summary>
        void Push(T item);
        /// <summary>
        /// Removes and returns the last item from the collection.
        /// - Single Responsibility Principle (SOLID): This method is dedicated to removing items.
        /// </summary>
        T Pop();
        //int Count { get; }
        //T this[int index] { get; }
    }
}
