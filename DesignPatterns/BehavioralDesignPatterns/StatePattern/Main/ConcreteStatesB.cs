namespace DesignPatterns.BehavioralDesignPatterns.StatePattern.Main
{
    /// <summary>
    /// implement the State interface, each representing a specific state and its corresponding behavior.
    /// </summary>
    internal class ConcreteStatesB : IState
    {
        /// <summary>
        /// implementation on the handle method 
        /// </summary>
        public void Handle()
        {
            Console.WriteLine("Handle State B");
        }
    }
}
