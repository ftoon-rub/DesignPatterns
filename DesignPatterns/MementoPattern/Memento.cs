namespace DesignPatterns.MementoPattern
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

        public string GetState()
        {
            return this.Content;
        }

    }
}
