namespace DesignPatterns.BehavioralDesignPatterns.MementoPattern.Exercises.Ex1
{
    /// <summary>
    /// creates a Memento containing a snapshot of its current internal state.
    /// it's controle the undo mechanism, by creating the currnet state and restore the state 
    /// </summary>
    internal class Originator
    {
        private string Content = string.Empty;
        /// <summary>
        /// change the currnet content
        /// </summary>
        /// <param name="content"></param>
        public void SetContent(string content)
        {
            Content = content;
            Console.WriteLine($"Originator Set Current Text: {Content}");
        }
        /// <summary>
        /// create new state (memento) with the currnet content
        /// </summary>
        /// <returns></returns>
        public Memento CreateState()
        {
            Console.WriteLine($"Originator createing memento state with content {Content}...");
            return new Memento(Content);
        }
        /// <summary>
        /// restore the currnet memento state
        /// </summary>
        /// <param name="memento"></param>
        public void Restore(Memento memento)
        {
            Content = memento.GetState();
            Console.WriteLine($"Originator Restored Text: {Content}");
        }
    }
}
