using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralDesignPatterns.CompositePattern.Main
{
    // This represents composite objects (objects that can have children).
    // SRP (Single Responsibility Principle): The Composite class handles adding, removing, and managing child components.
    public class Composite<T> : Component<T>
    {
        // Encapsulation (OOP): Children are encapsulated in a private list.
        private List<Component<T>> _children = new List<Component<T>>();

        public Composite(string name) : base(name) { }

        // DIP (Dependency Inversion Principle): The Composite class depends on the abstract Component class (high-level abstraction), not on concrete Leaf/Composite implementations.
        public void Add(Component<T> component)
        {
            _children.Add(component); // SRP: Manages the collection of child components.
        }

        public void Remove(Component<T> component)
        {
            _children.Remove(component); // SRP: Responsible for managing its child components.
        }

        // LSP (Liskov Substitution Principle): Both Leaf and Composite implement the same interface and can be substituted where needed.
        public override void Display(int depth)
        {
            // OCP (Open/Closed Principle): The Composite class can add more components and extend its behavior without modifying its core logic.
            Console.WriteLine(new String('-', depth) + Name);

            // Recursively display child nodes
            foreach (Component<T> component in _children)
            {
                component.Display(depth + 2); // Polymorphism (OOP): Calls the appropriate method of Leaf or Composite.
            }
        }
    }
}
