        namespace DesignPatterns.StatePattern
{
    /// <summary>
    /// is the class that maintains an instance of a ConcreteState subclass, which defines the current state.
    /// </summary>
    internal class Context
    {
        private IState state;

        /// <summary>
        /// method calls a specific handler method based on its current state
        /// </summary>
        public void Request()
        {
            state.Handle();
        }

        public IState State
        {
            get { return state; }
            set { state = value; }
        }
    }
}
