namespace DesignPatterns.BehavioralDesignPatterns.IteratorPattern.Solution
{
    internal class ArrayIterator : IIterator<string>
    {
        private BrowseHistory _history;
        private int index;
        public ArrayIterator(BrowseHistory history)
        {
            _history = history;
        }


        public string current()
        {
            return _history.GetListUrls[index];
        }

        public bool hasNext()
        {
            return index < _history.GetListUrls.Count;
        }

        public void next()
        {
            index++;
        }
    }
}
