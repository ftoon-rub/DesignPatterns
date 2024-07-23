﻿namespace DesignPatterns.StrategyPattern
{
    internal class ImageStorage
    {
        private filter Filter;
        private compressor Compressor;

        public ImageStorage(compressor Compressor, filter Filter)
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

            if (filter.bAndW == Filter )
                Console.WriteLine("filter bAndW");
            else if (filter.highContrast == Filter)
                Console.WriteLine("filter.highContrast");
        }
    }
    public enum compressor
    {
        jbeg,
        png
    }
    public enum filter
    {
        bAndW,
        highContrast
    }
}
