namespace DesignPatterns.IteratorPattern.Main
{
    public interface IIterator<T>
    {
        T Current { get; }
        bool HasNext();
        T Next();
        void Reset();
    }
}
