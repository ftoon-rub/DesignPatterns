namespace DesignPatterns.StrategyPattern
{
    internal interface ICompressor
    {
        void Compress(string fileName);
        byte[] Compress(byte[] image);
    }
}
