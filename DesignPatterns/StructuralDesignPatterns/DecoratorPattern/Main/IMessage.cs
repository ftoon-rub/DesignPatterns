using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralDesignPatterns.DecoratorPattern.Main
{
    // Interface segregation (SOLID): Defines only one responsibility (message retrieval), so it's easy to implement and extend.
    public interface IMessage
    {
        string GetMessage();  // Abstraction (OOP): Defines a common interface that will be used by the client code.
    }
}
