namespace DesignPatterns.IteratorPattern.Main
{
    public class ArrayIterator<T> : IIterator<T>
    {
        private T[] _array;
        private int _index;

        public ArrayIterator(T[] array)
        {
            _array = array;
        }
        public T Current => _array[_index];

        public bool HasNext()
        {
            return (_index < _array.Length - 1);
        }

        public T Next()
        {
            if (HasNext())
            {
                _index++;
                return _array[_index];
            }
            return default(T);
        }

        public void Reset()
        {
            _index = -1;
        }
    }
}
