using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralDesignPatterns.AdapterPattern.Main
{
    // 3. Adapter (Open/Closed Principle - OCP, Liskov Substitution Principle - LSP, Single Responsibility Principle - SRP)
    // OCP: The Adapter class can extend the behavior of the system (adapting an Adaptee) without modifying the existing Adaptee code.
    // LSP: The Adapter conforms to the ITarget interface, allowing it to be used interchangeably with other implementations of ITarget.
    // SRP: The Adapter has one responsibility: to adapt the Adaptee's interface to the Target interface.
    public class Adapter : ITarget
    {
        private readonly Adaptee _adaptee;

        // Constructor (Dependency Inversion Principle - DIP)
        // DIP: The Adapter depends on an abstraction (the ITarget interface) and not a concrete implementation.
        public Adapter(Adaptee adaptee)
        {
            _adaptee = adaptee;  // Composition (OOP Principle - Encapsulation)
                                 // Encapsulation: The Adaptee is encapsulated within the Adapter class, hiding its implementation details from the Client.
        }

        // Request method (Interface Segregation Principle - ISP, Polymorphism, Abstraction)
        // ISP: The ITarget interface is minimal, providing only the necessary methods the Client needs.
        // Polymorphism & Abstraction: The Adapter implements the ITarget interface and translates the call to the Adaptee's method.
        public void Request()
        {
            _adaptee.SpecificRequest();  // The Adapter translates ITarget's Request into Adaptee's SpecificRequest
        }
    }
}
