using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralDesignPatterns
{
    public abstract class TestStructuralDesignPatternsTemplate : BaseTestTemplate
    {
        protected override void PatternCategory()
        {
            Console.WriteLine("\t- Structural patterns deal with the composition of classes and objects, focusing on how classes and objects are combined to form larger structures while keeping these structures flexible and efficient.\r\n\r\n");
            Console.WriteLine("\n");
        }
    }
}
