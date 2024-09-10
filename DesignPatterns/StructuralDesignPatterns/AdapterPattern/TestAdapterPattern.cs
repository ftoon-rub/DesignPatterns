using DesignPatterns.StructuralDesignPatterns.AdapterPattern.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralDesignPatterns.AdapterPattern
{
    public class TestAdapterPattern : TestStructuralDesignPatternsTemplate
    {
        protected override void OopUsedInPattern()
        {
            Console.WriteLine("\t- Encapsulation: The Adapter encapsulates the Adaptee, hiding its interface from the Client.");
            Console.WriteLine("\t- Polymorphism: The Adapter implements the Target interface, allowing it to be used interchangeably with other classes that also implement the Target interface.");
            Console.WriteLine("\t- Abstraction: The Adapter pattern abstracts the interaction between the Client and the Adaptee, allowing them to communicate through an abstract interface (Target).");
        }

        protected override void PatternComponents()
        {
            Console.WriteLine("\t- Target: This is the interface expected by the client. It defines the domain-specific interface that the client uses.\r\n\t- Adapter: Implements the Target interface and adapts the Adaptee to the Target. It translates requests from the Target interface to the Adaptee interface.\r\n\t- Adaptee: The existing class with a different interface from what the client expects. This is the class that you want to use but is incompatible with the Target interface.\r\n\t- Client: The class that interacts with objects via the Target interface.");
        }

        protected override void PatternDescription()
        {
            Console.WriteLine("\t- The Adapter Pattern is a structural design pattern that allows incompatible interfaces to work together by acting as a bridge between two incompatible classes. It is used when a client expects one interface but you have an object implementing a different interface.");
            Console.WriteLine("\t- When is it used?\r\n\t- When you want to reuse an existing class, but its interface doesn't match the one required by the client.\r\n\t- When you want to integrate third-party libraries into your system that follow different interfaces.\r\n\t- When you want to provide a different interface to an existing class that is more suitable for your needs.");
        }

        protected override void SolidUsedInPattern()
        {
            Console.WriteLine("\t- Single Responsibility Principle (SRP): The Adapter has a single responsibility to convert the interface of the Adaptee into the Target interface.");
            Console.WriteLine("\t- Open/Closed Principle (OCP): The Adaptee can be extended with an adapter without modifying its code. The Adapter class allows you to integrate new systems without changing the existing ones.");
            Console.WriteLine("\t- Liskov Substitution Principle (LSP): The client can use the Adapter in place of the Target, and the behavior should remain consistent.");
        }

        protected override void TestDesignPatternMain()
        {
            // Creating an Adaptee object (Existing class with a different interface)
            Adaptee adaptee = new Adaptee();

            // Wrapping the Adaptee inside an Adapter to conform to the ITarget interface
            ITarget target = new Adapter(adaptee);  // OCP: We are extending functionality without changing Adaptee or Client.

            // Creating a Client object
            Client client = new Client();

            // The Client uses the Adapter (which conforms to ITarget) to call the adapted method.
            client.MakeRequest(target);  // Polymorphism & Abstraction in action
        }

        protected override void TestDesignPatternProblem()
        {
            Console.WriteLine(nameof(TestDesignPatternProblem) + "method in progress");
        }

        protected override void TestDesignPatternSolution()
        {
            Console.WriteLine(nameof(TestDesignPatternSolution) + "method in progress");
        }
    }
}
