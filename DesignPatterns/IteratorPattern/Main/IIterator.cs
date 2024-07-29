namespace DesignPatterns.IteratorPattern.Main
{
    // Interface Segregation Principle (SOLID): IIterator interface is small and focused on a single responsibility.
    public interface IIterator<T>
    {
        /// <summary>
        /// Encapsulation (OOP): Exposing only necessary members.
        /// </summary>
        T Current { get; }
        /// <summary>
        /// Single Responsibility Principle (SOLID): Each method does one thing.
        /// </summary>
        /// <returns></returns>
        bool HasNext();
        T Next();
        void Reset();
    }
}
