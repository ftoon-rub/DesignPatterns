using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralDesignPatterns.DecoratorPattern.Main
{
    // Decorator
    // Open/Closed Principle (SOLID): The decorator class is open for extension but closed for modification. 
    // You can extend it by creating new decorators without changing the existing ones.
    // Composition (OOP): This class uses composition to include behavior from another object.
    public class MessageDecorator : IMessage
    {
        protected IMessage _message;  // Composition (OOP): Holds a reference to an instance of IMessage.

        public MessageDecorator(IMessage message)
        {
            _message = message;  // Dependency Injection (OOP): The IMessage instance is injected into the decorator.
        }

        // Polymorphism (OOP): The decorator delegates the call to the component, allowing decorators and concrete components to be used interchangeably.
        public virtual string GetMessage()
        {
            return _message.GetMessage();  // Delegates to the component (decorated object).
        }
    }
}
