namespace DesignPatterns.ObserverPattern.Main
{
    public interface IObserver<T>
    {
        void Update(T data); // Push model
        void Update(); // Pull model
    }
}
