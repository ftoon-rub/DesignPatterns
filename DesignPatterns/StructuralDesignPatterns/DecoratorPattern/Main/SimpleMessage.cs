using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralDesignPatterns.DecoratorPattern.Main
{
    // Concrete Component
    // Single Responsibility (SOLID): This class has only one reason to change – if the message retrieval logic changes.
    public class SimpleMessage : IMessage
    {
        public string GetMessage() => "This is a simple message.";
    }
}
