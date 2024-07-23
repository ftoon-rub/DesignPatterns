namespace DesignPatterns.StrategyPattern
{
    internal class TestStrategy : ITestState
    {
        public void Test()
        {
            Console.WriteLine("\nStart TestStrategy Class");
            ImageStorage imageStorage = new ImageStorage(new BlackAndWhite(),new JpegCompressor());
            imageStorage.store("a");
            // I changed the behaveral of the progam by just change the constractor 
            imageStorage = new ImageStorage(new HighContrast(),new PngCompressor());
            imageStorage.store("a");
        }
    }
}
