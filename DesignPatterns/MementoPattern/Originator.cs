namespace DesignPatterns.MementoPattern
{
    /// <summary>
    /// creates a Memento containing a snapshot of its current internal state.
    /// it's controle the undo mechanism, by creating the currnet state and restore the state 
    /// </summary>
    internal class Originator
    {
        private string Content;
        public Originator(string Content)
        {
            this.Content = Content;
        }
        /// <summary>
        /// create new state (memento) with the currnet content
        /// </summary>
        /// <returns></returns>
        public Memento CreateState()
        {
            return new Memento(this.Content);
        }
        /// <summary>
        /// restore the currnet memento state
        /// </summary>
        /// <param name="memento"></param>
        public void Restore(Memento memento)
        {
            Content = memento.GetState();
        }
    }
}
