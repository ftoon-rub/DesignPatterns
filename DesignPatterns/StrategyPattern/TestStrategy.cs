namespace DesignPatterns.StrategyPattern
{
    internal class TestStrategy : ITestState
    {
        public void Test()
        {
            Console.WriteLine("Start TestStrategy Class\n");
            ImageStorage imageStorage = new ImageStorage(new BlackAndWhite(),new JpegCompressor());
            imageStorage.store("a");
            // I changed the behaveral of the progam by just change the constractor this is open close prinsple
            Console.WriteLine("\nopen close prinsple");
            imageStorage = new ImageStorage(new HighContrast(),new PngCompressor());
            imageStorage.store("a");
            Console.WriteLine("\nimageWithoutCtor");
            ImageStorage imageWithoutCtor = new();
            imageWithoutCtor.store("b",new PngCompressor(),new BlackAndWhite());
        }
    }
}
