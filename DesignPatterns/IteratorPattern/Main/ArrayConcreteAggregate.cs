using System;

namespace DesignPatterns.IteratorPattern.Main
{
    internal class ArrayConcreteAggregate<T> : IAggregate<T>
    {
        private T[] _array = new T[10];
        private int index;

        public IIterator<T> CreateIterator()
        {
            return new ArrayConcreteIterator<T>(_array);
        }

        public T Pop()
        {
            if (_array.Length < 0)
            {
                return _array[--index];
            }
            return default;
        }

        public void Push(T item)
        {
            _array[index++] = item;
        }

        public T[] array { get { return _array; } set {_array = value; } }
    }
}
