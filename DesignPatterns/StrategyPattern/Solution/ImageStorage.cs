namespace DesignPatterns.StrategyPattern
{
    /// <summary>
    /// Context Class
    /// </summary>
    internal class ImageStorage
    {
        private IFilter _filter;
        private ICompressor _compressor;
        public ImageStorage()
        {
            //use with this method
            //public void store(string fileName, ICompressor compressor,IFilter filter)

        }
        public ImageStorage(IFilter filter, ICompressor compressor)
        {
            _filter = filter;
            _compressor = compressor;
        }

        public void store(string fileName)
        {
            _compressor.Compress(fileName);
            _filter.Apply(fileName);
        }
        public void store(string fileName, ICompressor compressor,IFilter filter)
        {
            compressor.Compress(fileName);
            filter.Apply(fileName);
        }
    }
}
