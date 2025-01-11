namespace DesignPatterns.CreationalDesignPatterns.AbstractFactoryPattern
{
    public class ConcreteFactory1 : IAbstractFactory
    {
        public IProductA CreateProductA()
        {
            Message();
            return new ConcreteProductA1();
        }

        public IProductB CreateProductB()
        {
            Message();
            return new ConcreteProductB1();
        }
        private void Message()
        {
            Console.WriteLine("Create Product of type ConcreteFactory1");
        }
    }
}
