namespace DesignPatterns.BehavioralDesignPatterns.StatePattern.Main
{
    /// <summary>
    /// is an interface or abstract class that declares methods for different actions that the Context can delegate to its current state.
    /// </summary>
    internal interface IState
    {
        void Handle();
    }
}
