namespace DesignPatterns.BehavioralDesignPatterns.MementoPattern.Main
{
    /// <summary>
    /// Memento class to store the state of the Originator
    ///- SRP: Memento only stores the state.
    ///- Encapsulation: The state is kept private and is not exposed directly.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Memento<T>
    {
        /// <summary>
        /// OOP: Encapsulation - The state is private and accessed only through this property
        /// </summary>
        public T State { get; private set; }

        public Memento(T state)
        {
            State = state;
        }
    }
}
