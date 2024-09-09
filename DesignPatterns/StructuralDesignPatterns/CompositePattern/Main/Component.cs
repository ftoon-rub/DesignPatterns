using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralDesignPatterns.CompositePattern.Main
{
    // Component
    // This abstract class defines the common interface for both Leaf and Composite.
    // OCP (Open/Closed Principle): It allows extension by adding new types of components (Leaf, Composite)
    // without modifying the Component class itself.
    public abstract class Component<T>
    {
        public string Name { get; set; }

        // SRP (Single Responsibility Principle): This class has a single responsibility of defining a common interface
        // for all the components in the hierarchy.
        public Component(string name)
        {
            Name = name;
        }

        // This method will be implemented by both Leaf and Composite.
        // LSP (Liskov Substitution Principle): Both Leaf and Composite can be used interchangeably with this method.
        public abstract void Display(int depth);
    }
}
