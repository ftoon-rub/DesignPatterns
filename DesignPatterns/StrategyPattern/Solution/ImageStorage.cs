namespace DesignPatterns.StrategyPattern
{
    /// <summary>
    /// Context Class
    /// </summary>
    internal class ImageStorage
    {
        private IFilter _filter;
        private ICompressor _compressor;

        public ImageStorage(IFilter filter, ICompressor compressor)
        {
            _filter = filter;
            _compressor = compressor;
        }

        public void store(compressor fileName)
        {
            
        }
    }
}
