using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalDesignPatterns.AbstractFactoryPattern
{
    public interface IAbstractFactory
    {
        IProductA CreateProductA();
        IProductB CreateProductB();
    }
}
