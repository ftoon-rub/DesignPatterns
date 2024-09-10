using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralDesignPatterns.CompositePattern.Main
{
    // This represents the leaf objects in the hierarchy (objects that have no children).
    // SRP (Single Responsibility Principle): The Leaf class is responsible for its own representation.
    public class Leaf<T> : Component<T>
    {
        public Leaf(string name) : base(name) { }

        // OCP (Open/Closed Principle): This class can be extended without modifying its structure, such as adding more behaviors if needed.
        public override void Display(int depth)
        {
            // Encapsulation & Abstraction (OOP): The internal structure of the object is hidden from the client.
            Console.WriteLine(new String('-', depth) + Name);
        }
    }
}
