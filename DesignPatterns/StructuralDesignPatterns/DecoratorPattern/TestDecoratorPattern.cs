using DesignPatterns.StructuralDesignPatterns.DecoratorPattern.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralDesignPatterns.DecoratorPattern
{
    public class TestDecoratorPattern : TestStructuralDesignPatternsTemplate
    {
        protected override void Ex1()
        {
            throw new NotImplementedException();
        }

        protected override void OopUsedInPattern()
        {
            Console.WriteLine("\t- Encapsulation: The decorator pattern encapsulates the extended behaviors by wrapping the Component and adding new behaviors.");
            Console.WriteLine("\t- Polymorphism: Decorators and concrete components implement the same interface, allowing for flexible and interchangeable usage.");
            Console.WriteLine("\t- Composition: The pattern relies on composition, where objects are composed of other objects (a decorator contains a reference to the component it decorates).");
        }

        protected override void PatternComponents()
        {
            Console.WriteLine("\t- Component: Defines the interface for objects that can have responsibilities added to them.");
            Console.WriteLine("\t- Concrete Component: The class to which additional functionality will be added.");
            Console.WriteLine("\t- Decorator: Implements the Component interface and contains a reference to a Component object. The decorator forwards requests to the Component and may add extra behavior.");
            Console.WriteLine("\t- Concrete Decorator: Adds new responsibilities to the component.");
        }

        protected override void PatternDescription()
        {
            Console.WriteLine("\t- The Decorator Pattern is a structural design pattern that allows behavior to be added to individual objects, either statically or dynamically, without affecting the behavior of other objects from the same class. It’s a flexible alternative to subclassing for extending functionality.");
            Console.WriteLine("\t- When is it used?\r\n\t- When you want to add responsibilities to individual objects dynamically and transparently, without affecting other objects.\r\n\t- When extending functionality by subclassing becomes impractical due to an explosion of subclasses or when inheritance is not feasible.\r\n\t- When functionality can be composed in layers, where each layer adds additional behavior.");
        }

        protected override void SolidUsedInPattern()
        {
            Console.WriteLine("\t- Single Responsibility Principle: Each class has a single responsibility. The base component (SimpleMessage) is responsible only for the core message, while decorators add specific functionalities like encryption and signing.");
            Console.WriteLine("\t- Open/Closed Principle: The decorator allows behavior to be extended without modifying existing code. You can add new decorators without changing the original message class.");
        }

        protected override void TestDesignPatternMain()
        {
            // Creating a simple message (Concrete Component)
            IMessage message = new SimpleMessage();
            Console.WriteLine(message.GetMessage());

            // Decorating the message with encryption
            IMessage encryptedMessage = new EncryptedMessage(message);
            Console.WriteLine(encryptedMessage.GetMessage());

            // Decorating the encrypted message with signing
            IMessage signedEncryptedMessage = new SignedMessage(encryptedMessage);
            Console.WriteLine(signedEncryptedMessage.GetMessage());

            // Dependency Inversion Principle (SOLID): The program depends on abstractions (IMessage) rather than concrete implementations.
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
