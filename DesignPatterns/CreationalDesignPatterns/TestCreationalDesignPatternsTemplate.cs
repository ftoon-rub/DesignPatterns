using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalDesignPatterns
{
    public abstract class TestCreationalDesignPatternsTemplate : BaseTestTemplate
    {
        protected override void PatternCategory()
        {
            Console.WriteLine("\t- These patterns deal with object creation mechanisms, aiming to reduce complexities and make the system more flexible and reusable. Creational patterns ensure that the system is independent of how its objects are created, composed, and represented.");
            Console.WriteLine("\n");
        }
    }
}
