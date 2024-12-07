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
        protected override void Ex1()
        {
            throw new NotImplementedException();
        }

        protected override void OopUsedInPattern()
        {
            Console.WriteLine("\t- Encapsulation:\r\nEach component (Leaf, Composite) encapsulates its own behavior. Composite also encapsulates the management of child components.\r\nAbstraction:\r\n\r\nThe Component abstract class provides a common interface for all objects in the hierarchy, allowing abstraction over different types of components (Leaf and Composite).\r\nPolymorphism:\r\n\r\nLeaf and Composite classes implement the same interface (Component) but behave differently, enabling polymorphism.\r\nInheritance:\r\n\r\nLeaf and Composite inherit from the Component abstract class, gaining its interface and behavior. This allows code reusability and flexibility.");
            Console.WriteLine("\t- Abstraction:\r\nThe Component abstract class provides a common interface for all objects in the hierarchy, allowing abstraction over different types of components (Leaf and Composite).\r\nPolymorphism:\r\n\r\nLeaf and Composite classes implement the same interface (Component) but behave differently, enabling polymorphism.\r\nInheritance:\r\n\r\nLeaf and Composite inherit from the Component abstract class, gaining its interface and behavior. This allows code reusability and flexibility.");
            Console.WriteLine("\t- Polymorphism:\r\nLeaf and Composite classes implement the same interface (Component) but behave differently, enabling polymorphism.\r\nInheritance:\r\n\r\nLeaf and Composite inherit from the Component abstract class, gaining its interface and behavior. This allows code reusability and flexibility.");
            Console.WriteLine("\t- Inheritance:\r\nLeaf and Composite inherit from the Component abstract class, gaining its interface and behavior. This allows code reusability and flexibility.");
        }

        protected override void PatternComponents()
        {
            Console.WriteLine("\t- Component: Declares the interface for objects in the composition (both for leaves and composites).\r\n\t- Leaf: Represents leaf objects (objects with no children) in the composition.\r\n\t- Composite: Represents composite objects (objects that can have children).");
        }

        protected override void PatternDescription()
        {
            Console.WriteLine("\t- The Composite Design Pattern is part of the Gang of Four (GoF) design patterns and falls under the structural category. This pattern allows you to treat individual objects and compositions of objects uniformly. It is used when you need to represent a tree-like hierarchical structure where individual objects and compositions of objects can be treated the same way.");
            Console.WriteLine("\t- What is the Composite Pattern?\r\n\t- \t- \t- The Composite Pattern is used to compose objects into tree structures to represent part-whole hierarchies.\r\n\t- \t- \t- It allows clients to treat individual objects and compositions of objects uniformly, i.e., as if they were all part of the same class.");
            Console.WriteLine("\t- When to Use the Composite Pattern?\r\n\t- \t- When you have a structure that can be represented as a tree of objects.\r\n\t- \t- When you want to treat a group of objects and individual objects the same way.\r\n\t- \t- When your problem involves recursively processing the objects in the tree structure.\r\n\t- \t- Use this pattern in scenarios like file systems, graphical UI components, or organization hierarchies.");
        }

        protected override void SolidUsedInPattern()
        {
            Console.WriteLine("\t- Single Responsibility Principle (SRP):\r\nEach class (Component, Leaf, Composite) has a single responsibility: either managing its own behavior (in the case of Leaf) or managing children (in the case of Composite).\r\n\t- Open/Closed Principle (OCP):\\r\nThe pattern is open for extension (you can add more leaf and composite classes) but closed for modification (existing code doesn't need to change to accommodate new types of components).\r\n\t- Liskov Substitution Principle (LSP):\r\nObjects of the superclass Component can be replaced by objects of subclasses (Leaf or Composite) without affecting the correctness of the program.\r\n\t- Interface Segregation Principle (ISP):\\r\nThe Component interface ensures that both Leaf and Composite classes implement only the relevant methods (Display in this case).\r\n\t- Dependency Inversion Principle (DIP):\r\nHigh-level modules (client code) should depend on abstractions (Component), not on concrete implementations (Leaf, Composite).");
            Console.WriteLine("\t- Open/Closed Principle (OCP):\\r\nThe pattern is open for extension (you can add more leaf and composite classes) but closed for modification (existing code doesn't need to change to accommodate new types of components).\r\n\t- Liskov Substitution Principle (LSP):\r\nObjects of the superclass Component can be replaced by objects of subclasses (Leaf or Composite) without affecting the correctness of the program.\r\n\t- Interface Segregation Principle (ISP):\\r\nThe Component interface ensures that both Leaf and Composite classes implement only the relevant methods (Display in this case).\r\n\t- Dependency Inversion Principle (DIP):\r\nHigh-level modules (client code) should depend on abstractions (Component), not on concrete implementations (Leaf, Composite).");
            Console.WriteLine("\t- Liskov Substitution Principle (LSP):\r\nObjects of the superclass Component can be replaced by objects of subclasses (Leaf or Composite) without affecting the correctness of the program.\r\n\t- Interface Segregation Principle (ISP):\\r\nThe Component interface ensures that both Leaf and Composite classes implement only the relevant methods (Display in this case).\r\n\t- Dependency Inversion Principle (DIP):\r\nHigh-level modules (client code) should depend on abstractions (Component), not on concrete implementations (Leaf, Composite).");
            Console.WriteLine("\t- Interface Segregation Principle (ISP):\\r\nThe Component interface ensures that both Leaf and Composite classes implement only the relevant methods (Display in this case).\r\n\t- Dependency Inversion Principle (DIP):\r\nHigh-level modules (client code) should depend on abstractions (Component), not on concrete implementations (Leaf, Composite).");
            Console.WriteLine("\t- Dependency Inversion Principle (DIP):\r\nHigh-level modules (client code) should depend on abstractions (Component), not on concrete implementations (Leaf, Composite).");
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

        protected void TestDesignPatternProblem()
        {
            Console.WriteLine(nameof(TestDesignPatternProblem) + "method in progress");
        }

        protected void TestDesignPatternSolution()
        {
            Console.WriteLine(nameof(TestDesignPatternSolution) + "method in progress");
        }
    }
}
