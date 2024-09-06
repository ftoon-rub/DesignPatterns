namespace DesignPatterns.BehavioralDesignPatterns.MementoPattern.Main
{
    /// <summary>
    /// Originator class that has a state and can save and restore it
    /// - SRP: Originator manages its own state and the logic to save/restore it.
    /// - OCP: This class can be extended with additional functionality without modifying its core logic.
    /// - LSP: If inherited, any subclass can replace this without affecting the client code.
    /// - Encapsulation: The state is hidden from the external classes, including the Caretaker.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Originator<T>
    {
        /// <summary>
        /// OOP: Encapsulation - The state is encapsulated and not exposed to other objects.
        /// </summary>
        public T State { get; set; }

        /// <summary>
        /// Save the current state into a Memento
        /// - SRP: Responsible for creating a snapshot of the current state.
        /// </summary>
        /// <returns></returns>
        public Memento<T> SaveState()
        {
            return new Memento<T>(State);
        }

        /// <summary>
        /// Restore the state from a Memento
        /// - SRP: Responsible for restoring the state from a memento.
        /// </summary>
        /// <param name="memento"></param>
        public void RestoreState(Memento<T> memento)
        {
            State = memento.State;
        }
    }
}
