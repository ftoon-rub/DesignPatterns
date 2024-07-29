using DesignPatterns.IteratorPattern.Solution;

namespace DesignPatterns.IteratorPattern.Main
{
    internal class ListConcreteAggregate<T> : IAggregate<T>
    {
        private List<T> _list = new();
        public List<T> list { get { return _list; } set { _list = value; } }
        public IIterator<T> CreateIterator()
        {
            return new ListIterator<T>(_list);
        }

        public T Pop()
        {
            if (_list.Count < 1)
                return default;
            var lastUrl = _list[_list.Count - 1];
            _list.RemoveAt(_list.Count - 1);
            return lastUrl;
        }

        public void Push(T item)
        {
            _list.Add(item);
        }
    }
}
