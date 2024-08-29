namespace DesignPatterns.BehavioralDesignPatterns.StrategyPattern.Solution
{
    /// <summary>
    /// ConcreteStrategy class
    /// </summary>
    internal class PngCompressor : ICompressor
    {
        public void Compress(string fileName)
        {
            Console.WriteLine("Compressing using png");
        }

        public byte[] Compress(byte[] image)
        {
            throw new NotImplementedException();
        }
    }
}
