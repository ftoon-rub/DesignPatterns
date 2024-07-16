namespace DesignPatterns.MementoPattern
{
    /// <summary>
    /// it has the list of the history
    /// holds the Memento and does not modify or inspect its contents.When needed
    /// , the Caretaker can return the Memento to the Originator to restore its previous state.
    /// </summary>
    internal class Caretaker
    {
        private Stack<Memento> statesHistory = new Stack<Memento>();
        /// <summary>
        /// save teh current state to the history stack
        /// </summary>
        /// <param name="originator"></param>
        public void Save(Originator originator)
        {
            statesHistory.Push(originator.CreateState());
        }
        /// <summary>
        /// pop the last state from the history and restore it as currnet states
        /// </summary>
        /// <param name="originator"></param>
        public void Undo(Originator originator)
        {
            if (statesHistory.Count > 0)
            {
                originator.Restore(statesHistory.Pop());
            }
            else
            {
                Console.WriteLine("No states to restore.");
            }
        }
    }
}
