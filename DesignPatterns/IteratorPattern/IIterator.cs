namespace DesignPatterns.IteratorPattern
{
    internal interface IIterator <T>
    {
        void next();
        T current();
        bool hasNext();
    }
}
