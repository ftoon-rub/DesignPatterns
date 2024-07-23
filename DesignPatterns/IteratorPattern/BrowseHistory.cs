using System.Collections;

namespace DesignPatterns.IteratorPattern
{
    internal class BrowseHistory
    {
        private List<string> ListUrls = new List<string>();
        private string[] ArrayUrls = new string[10];
        private int index;
        public IIterator<string> createIteratorListUrls()
        {
            return new ListIterator(this);
        }
        public IIterator<string> createIteratorArrayUrls()
        {
            return new ArrayIterator(this);
        }
        public List<string> GetListUrls
        {
            get { return ListUrls; }
            set { ListUrls = value; }
        }
        public string[] GetArrayUrls
        {
            get { return ArrayUrls; }
            set { ArrayUrls = value; }
        }

        public void pushListUrls(string url)
        {
            ListUrls.Add(url);
        }
        public string popListUrls()
        {
            if (ListUrls.Count < 1)
                return null;
            var lastUrl = ListUrls[ListUrls.Count - 1];
            ListUrls.RemoveAt(ListUrls.Count - 1);
            return lastUrl;
        }
        public void pushArrayUrls(string url)
        {
            ArrayUrls[index++] = url; 
        }
        public string popArrayUrls()
        {
            if (ListUrls.Count < 1)
            {
                return ArrayUrls[--index];
            }
            return null;
        }
    }
}
