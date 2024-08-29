namespace DesignPatterns.BehavioralDesignPatterns.IteratorPattern.Main
{
    public class ArrayConcreteIterator<T> : IIterator<T>
    {
        private T[] _array;
        private int _index;

        public ArrayConcreteIterator(T[] array)
        {
            _array = array;
        }
        public T Current => _array[_index];

        public bool HasNext()
        {
            return _index < _array.Length - 1;
        }

        public T Next()
        {
            if (HasNext())
            {
                _index++;
                return _array[_index];
            }
            return default;
        }

        public void Reset()
        {
            _index = -1;
        }
    }
}
