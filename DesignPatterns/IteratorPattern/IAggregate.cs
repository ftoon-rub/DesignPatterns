namespace DesignPatterns.IteratorPattern
{
    internal interface IAggregate<T>
    {
        IIterator<T> CreateIterator();
        void Push(T item);
        T Pop();
        int Count { get; }
        T this[int index] { get; }
    }
}
