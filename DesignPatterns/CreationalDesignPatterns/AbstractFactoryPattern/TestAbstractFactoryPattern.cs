using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalDesignPatterns.AbstractFactoryPattern
{
    public class TestAbstractFactoryPattern : TestCreationalDesignPatternsTemplate
    {
        protected override void Ex1()
        {
            Console.WriteLine("\n");
        }

        protected override void OopUsedInPattern()
        {
            Console.WriteLine("\n");
        }

        protected override void PatternComponents()
        {
            Console.WriteLine("\n");
        }

        protected override void PatternDescription()
        {
            Console.WriteLine("\n");
        }

        protected override void SolidUsedInPattern()
        {
            Console.WriteLine("\n");
        }

        protected override void TestDesignPatternMain()
        {
            IAbstractFactory factory1 = new ConcreteFactory1();
            AbstractFactoryClient factoryClient = new (factory1);
            factoryClient.CreateVariant();

            IAbstractFactory factory2 = new ConcreteFactory2();
            factoryClient = new(factory2);
            factoryClient.CreateVariant();

            Console.WriteLine("\n");
        }
    }
}
