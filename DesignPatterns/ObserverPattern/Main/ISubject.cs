namespace DesignPatterns.ObserverPattern.Main
{
    public interface ISubject<T>
    {
        void RegisterObserver(IObserver<T> observer);
        void RemoveObserver(IObserver<T> observer);
        void NotifyObservers();
    }
}
