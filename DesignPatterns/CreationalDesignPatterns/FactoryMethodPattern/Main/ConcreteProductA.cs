using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalDesignPatterns.FactoryMethodPattern.Main
{
    public class ConcreteProductA : IProduct
    {
        public void DoSomthing()
        {
            Console.WriteLine("product A");
        }
    }
}
