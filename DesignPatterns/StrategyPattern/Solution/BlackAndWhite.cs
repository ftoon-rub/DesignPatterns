namespace DesignPatterns.StrategyPattern
{
    /// <summary>
    /// ConcreteStrategy class
    /// </summary>
    internal class BlackAndWhite : IFilter
    {
        public void Apply(string fileName)
        {
            Console.WriteLine("apply HighContrast");
        }
    }
}
