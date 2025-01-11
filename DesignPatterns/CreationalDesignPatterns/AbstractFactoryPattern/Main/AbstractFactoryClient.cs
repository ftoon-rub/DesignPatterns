namespace DesignPatterns.CreationalDesignPatterns.AbstractFactoryPattern
{
    public class AbstractFactoryClient
    {
        private IAbstractFactory _abstractFactory;

        public AbstractFactoryClient(IAbstractFactory abstractFactory)
        {
            _abstractFactory = abstractFactory;
        }
        public void CreateVariant()
        {
            _abstractFactory.CreateProductA();
            _abstractFactory.CreateProductB();
        }
    }
}
