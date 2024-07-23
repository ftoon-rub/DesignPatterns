namespace DesignPatterns.IteratorPattern
{
    internal class ArrayConcreteAggregate<T> : IAggregate<T>
    {
        public T this[int index] => throw new NotImplementedException();

        public int Count => throw new NotImplementedException();

        public IIterator<T> CreateIterator()
        {
            throw new NotImplementedException();
        }

        public T Pop()
        {
            throw new NotImplementedException();
        }

        public void Push(T item)
        {
            throw new NotImplementedException();
        }
    }
}
