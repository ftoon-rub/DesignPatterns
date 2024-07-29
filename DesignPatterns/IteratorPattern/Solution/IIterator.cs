namespace DesignPatterns.IteratorPattern.Solution
{
    public interface IIterator<T>
    {
        void next();
        T current();
        bool hasNext();
    }
}
