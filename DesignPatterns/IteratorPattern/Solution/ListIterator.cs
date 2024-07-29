namespace DesignPatterns.IteratorPattern.Solution
{
    internal class ListIterator : IIterator<string>
    {
        public ListIterator(BrowseHistory history)
        {
            _history = history;
        }

        private BrowseHistory _history;
        private int index;

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
