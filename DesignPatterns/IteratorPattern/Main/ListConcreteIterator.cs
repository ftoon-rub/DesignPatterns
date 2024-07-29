namespace DesignPatterns.IteratorPattern.Main
{
    public class ListConcreteIterator<T> : IIterator<T>
    {
        private readonly List<T> _list;
        private int _index;

        public ListConcreteIterator(List<T> list)
        {
            _list = list;
        }
        public T Current => _list[_index];

        public bool HasNext()
        {
            return (_index < _list.Count - 1);
        }

        public T Next()
        {
            if (HasNext())
            {
                return _list[++_index];
            }
            return default(T);
        }

        public void Reset()
        {
            _index = -1;
        }
    }
}
