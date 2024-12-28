using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalDesignPatterns.FactoryMethodPattern.Main
{
    public class ConcreteProductACreator : ProductsCreator
    {
        protected override IProduct CreateProduct()
        {
            return new ConcreteProductA();
        }
    }
}
