using DesignPatterns.StructuralDesignPatterns.CompositePattern.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralDesignPatterns.CompositePattern
{
    public class TestCompositeDesignPattern : TestStructuralDesignPatternsTemplate
    {
        protected override void OopUsedInPattern()
        {
            throw new NotImplementedException();
        }

        protected override void PatternComponents()
        {
            throw new NotImplementedException();
        }

        protected override void PatternDescription()
        {
            throw new NotImplementedException();
        }

        protected override void SolidUsedInPattern()
        {
            throw new NotImplementedException();
        }

        protected override void TestDesignPatternMain()
        {
            // Create leaf and composite objects
            // Encapsulation & Abstraction (OOP): We do not need to know the specific implementation details of each component.
            Composite<string> root = new Composite<string>("Root");
            root.Add(new Leaf<string>("Leaf A")); // ISP (Interface Segregation Principle): We only use methods related to adding children.
            root.Add(new Leaf<string>("Leaf B"));

            Composite<string> comp = new Composite<string>("Composite X");
            comp.Add(new Leaf<string>("Leaf XA"));
            comp.Add(new Leaf<string>("Leaf XB"));

            root.Add(comp);
            root.Add(new Leaf<string>("Leaf C"));

            // Display the tree structure
            // Polymorphism (OOP): The same Display method can handle both Leaf and Composite, demonstrating runtime polymorphism.
            root.Display(1);
        }

        protected override void TestDesignPatternProblem()
        {
            throw new NotImplementedException();
        }

        protected override void TestDesignPatternSolution()
        {
            throw new NotImplementedException();
        }
    }
}
