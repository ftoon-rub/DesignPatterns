namespace DesignPatterns.BehavioralDesignPatterns.StrategyPattern.Solution
{
    internal interface ICompressor
    {
        void Compress(string fileName);
        byte[] Compress(byte[] image);
    }
}
