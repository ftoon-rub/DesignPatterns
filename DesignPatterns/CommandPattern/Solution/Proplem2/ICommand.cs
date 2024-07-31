namespace DesignPatterns.CommandPattern.Solution.Proplem2
{
    /// <summary>
    /// ICommand interface adheres to ISP
    /// </summary>
    public interface ICommand
    {
        /// <summary>
        /// ISP adhered: simple, focused interface
        /// </summary>
        void Execute();
        /// <summary>
        /// ISP adhered: simple, focused interface
        /// </summary>
        void Unexecute(); 
    }
}
