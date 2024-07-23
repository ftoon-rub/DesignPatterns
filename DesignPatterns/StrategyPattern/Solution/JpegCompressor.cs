namespace DesignPatterns.StrategyPattern
{
    /// <summary>
    /// ConcreteStrategy class
    /// </summary>
    internal class JpegCompressor : ICompressor
    {
        public void Compress(string fileName)
        {
            Console.WriteLine("Compressing using jpeg");
        }

        public byte[] Compress(byte[] image)
        {
            throw new NotImplementedException();
        }
    }
}
