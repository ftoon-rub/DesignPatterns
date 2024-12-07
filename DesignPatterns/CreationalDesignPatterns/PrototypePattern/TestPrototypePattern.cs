using DesignPatterns.CreationalDesignPatterns.PrototypePattern.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalDesignPatterns.PrototypePattern
{
    public class TestPrototypePattern : TestCreationalDesignPatternsTemplate
    {
        protected override void Ex1()
        {
            throw new NotImplementedException();
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
            ConcretePrototype original = new ConcretePrototype()
            {
                age = 26,
                name = "ftoon",
                skills = new List<string> { "C#","sql server"}
            };

            Console.WriteLine("original: " +original.ToString());

            IPrototype clone = original.Clone();
            Console.WriteLine("clone: " + clone.ToString());

            IPrototype shallowClone = original.ShallowClone();
            Console.WriteLine("shallowClone: " + shallowClone.ToString());

            original.age = 27;
            original.name = "Ftoon Bin Rbia";
            original.skills.Add("Prototype DP");

            Console.WriteLine("edit original");
            Console.WriteLine("original: " + original.ToString());
            //clone explicitly takes an existing object as a parameter and copies its fields/property values to the new object.
            Console.WriteLine("clone and shallowClone after edit original");
            Console.WriteLine("clone: " + clone.ToString());
            Console.WriteLine("shallowClone: " + shallowClone.ToString());



        }

    }
}
