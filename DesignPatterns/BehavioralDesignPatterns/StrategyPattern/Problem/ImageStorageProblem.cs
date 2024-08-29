namespace DesignPatterns.BehavioralDesignPatterns.StrategyPattern.Problem
{
    internal class ImageStorageProblem
    {
        private filter Filter;
        private compressor Compressor;

        public ImageStorageProblem(compressor Compressor, filter Filter)
        {
            this.Compressor = Compressor;
            this.Filter = Filter;
        }

        public void store(compressor fileName)
        {
            if (Compressor == compressor.jbeg)
                Console.WriteLine("compressor.jbeg");
            else if (compressor.png == Compressor)
                Console.WriteLine("compressor.png");

            if (filter.bAndW == Filter)
                Console.WriteLine("filter bAndW");
            else if (filter.highContrast == Filter)
                Console.WriteLine("filter.highContrast");
        }
    }
    internal enum compressor
    {
        jbeg,
        png
    }
    internal enum filter
    {
        bAndW,
        highContrast
    }
}
