namespace DesignPatterns.BehavioralDesignPatterns.StatePattern.Main
{
    /// <summary>
    /// implement the State interface, each representing a specific state and its corresponding behavior.
    /// </summary>
    internal class ConcreteStatesA : IState
    {
        /// <summary>
        /// implementation on the handle method 
        /// </summary>
        public void Handle()
        {
            Console.WriteLine("Handler State A");
        }
    }
}
