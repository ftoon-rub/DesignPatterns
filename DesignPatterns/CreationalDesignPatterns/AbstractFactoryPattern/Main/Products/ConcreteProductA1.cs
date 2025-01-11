using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalDesignPatterns.AbstractFactoryPattern
{
    public class ConcreteProductA1 : IProductA
    {
        public ConcreteProductA1()
        {
            Console.WriteLine("Constructors A1");
        }
    }
}
