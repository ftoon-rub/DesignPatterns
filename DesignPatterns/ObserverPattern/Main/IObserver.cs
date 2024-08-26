namespace DesignPatterns.ObserverPattern.Main
{
    /// <summary>
    /// SOLID Principle: Interface Segregation Principle (ISP)
    /// This interface defines the contract for observers, allowing them to receive updates from the subject.
    /// OOP Principle: Abstraction
    /// The IObserver<T> interface abstracts the functionality of an observer in the Observer pattern.
    /// It defines the essential methods without exposing the implementation details.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IObserver<T>
    {
        /// <summary>
        /// Method for the Push model: the subject pushes the data to the observer
        /// </summary>
        /// <param name="data"></param>
        void Update(T data); 
        /// <summary>
        /// Method for the Pull model: the observer pulls the data from the subject
        /// </summary>
        void Update(); 
    }
}
