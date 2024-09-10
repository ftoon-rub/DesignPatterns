using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralDesignPatterns.AdapterPattern.Main
{
    // 1. Target Interface (Abstraction & Liskov Substitution Principle - LSP)
    // Abstraction: The ITarget interface defines an abstract contract for the Client to use.
    // LSP: The Adapter will implement this interface, ensuring that it can be substituted wherever ITarget is expected.
    public interface ITarget
    {
        void Request();
    }
}
