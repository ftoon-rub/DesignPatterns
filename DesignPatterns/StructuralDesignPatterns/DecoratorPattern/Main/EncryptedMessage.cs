using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralDesignPatterns.DecoratorPattern.Main
{
    // Concrete Decorator
    // Single Responsibility (SOLID): Adds encryption behavior only.
    // Open/Closed Principle (SOLID): You can extend this functionality by adding new decorators without modifying the class.
    public class EncryptedMessage : MessageDecorator
    {
        public EncryptedMessage(IMessage message) : base(message) { }

        // Overrides the base behavior and adds encryption.
        // Liskov Substitution Principle (SOLID): EncryptedMessage can replace any IMessage component without affecting the correctness of the program.
        public override string GetMessage()
        {
            return Encrypt(base.GetMessage());  // Adds new behavior (encryption).
        }

        // Encapsulation (OOP): The encryption logic is encapsulated within the class.
        private string Encrypt(string message)
        {
            return $"Encrypted({message})"; // Simulating encryption
        }
    }
}
