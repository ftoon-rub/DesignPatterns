using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralDesignPatterns.AdapterPattern.Main
{
    // 4. Client (Dependency Inversion Principle - DIP)
    // DIP: The Client depends on the abstraction (ITarget), not a specific implementation (Adapter or Adaptee).
    public class Client
    {
        public void MakeRequest(ITarget target)
        {
            // Liskov Substitution Principle (LSP): The Client can use any object that implements ITarget, whether it's an Adapter or another implementation.
            target.Request();  // Polymorphism: The Client doesn't care whether it's working with an Adapter or another class.
        }
    }
}
