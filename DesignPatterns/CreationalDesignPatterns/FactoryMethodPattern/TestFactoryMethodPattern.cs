using DesignPatterns.CreationalDesignPatterns.FactoryMethodPattern.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalDesignPatterns.FactoryMethodPattern
{
    public class TestFactoryMethodPattern : TestCreationalDesignPatternsTemplate
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
            ProductsCreator productsCreator = new ConcreteProductACreator();
            productsCreator.Render();

            productsCreator = new ConcreteProductBCreator();
            productsCreator.Render();
        }
    }
}
