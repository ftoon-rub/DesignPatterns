namespace DesignPatterns.ObserverPattern.Main
{
    /// <summary>
    ///     SOLID Principle: Interface Segregation Principle (ISP)
    ///     This interface defines the contract for subjects in the Observer pattern, ensuring that classes only implement the methods they need.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface ISubject<T>
    {
        /// <summary>
        /// Register an observer to be notified of changes
        /// </summary>
        /// <param name="observer"></param>
        void RegisterObserver(IObserver<T> observer);
        /// <summary>
        /// Remove an observer from the notification list
        /// </summary>
        /// <param name="observer"></param>
        void RemoveObserver(IObserver<T> observer);
        /// <summary>
        /// Notify all registered observers of a change
        /// </summary>
        void NotifyObservers();
    }
}
