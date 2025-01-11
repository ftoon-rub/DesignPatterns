using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalDesignPatterns.AbstractFactoryPattern
{
    public class ConcreteFactory2 : IAbstractFactory
    {
        public IProductA CreateProductA()
        {
            Message();
            return new ConcreteProductA2();
        }

        public IProductB CreateProductB()
        {
            Message();
            return new ConcreteProductB2();
        }
        private void Message()
        {
            Console.WriteLine("Create Product of type ConcreteFactory2");
        }
    }
}
