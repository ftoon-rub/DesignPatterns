using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalDesignPatterns.FactoryMethodPattern.Main
{
    public class ConcreteProductBCreator : ProductsCreator
    {
        protected override IProduct CreateProduct()
        {
            return new ConcreteProductB();
        }
    }
}
