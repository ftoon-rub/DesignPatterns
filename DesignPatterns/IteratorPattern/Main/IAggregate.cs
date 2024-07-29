
using DesignPatterns.IteratorPattern.Main;

namespace DesignPatterns.IteratorPattern
{
    /// <summary>
    /// Defines the interface for collections that will return iterators.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IAggregate<T>
    {
        IIterator<T> CreateIterator();
        void Push(T item);
        T Pop();
        //int Count { get; }
        //T this[int index] { get; }
    }
}
