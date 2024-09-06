namespace DesignPatterns.BehavioralDesignPatterns.MementoPattern.Exercises.Ex1
{
    /// <summary>
    /// it has the content 
    /// </summary>
    internal class Memento
    {
        private readonly string Content;

        public Memento(string Content)
        {
            this.Content = Content;
        }
        /// <summary>
        /// get the current states
        /// </summary>
        /// <returns></returns>
        public string GetState()
        {
            return Content;
        }

    }
}
