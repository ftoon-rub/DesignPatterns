using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralDesignPatterns.DecoratorPattern.Main
{
    // Concrete Decorator
    // Single Responsibility (SOLID): Adds signing behavior only.
    public class SignedMessage : MessageDecorator
    {
        public SignedMessage(IMessage message) : base(message) { }

        // Overrides the base behavior and adds signing.
        // Liskov Substitution Principle (SOLID): SignedMessage can replace any IMessage component without breaking the functionality.
        public override string GetMessage()
        {
            return Sign(base.GetMessage());  // Adds new behavior (signing).
        }

        // Encapsulation (OOP): The signing logic is encapsulated within the class.
        private string Sign(string message)
        {
            return $"{message} [Signed]";
        }
    }
}
