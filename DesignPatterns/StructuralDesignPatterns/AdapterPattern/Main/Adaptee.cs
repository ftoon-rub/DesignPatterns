using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralDesignPatterns.AdapterPattern.Main
{
    // 2. Adaptee (Single Responsibility Principle - SRP)
    // SRP: The Adaptee class has one reason to change: its own functionality. It does not need to know about the Client or how it will be used.
    public class Adaptee
    {
        public void SpecificRequest()
        {
            Console.WriteLine("Called SpecificRequest from Adaptee");
        }
    }
}
