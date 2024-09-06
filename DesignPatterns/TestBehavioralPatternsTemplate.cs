using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public abstract class TestBehavioralPatternsTemplate : BaseTestTemplate
    {
        protected override void PatternCategory()
        {
            Console.WriteLine("\t- Deal with how objects interact and communicate. They focus on algorithms and the assignment of responsibilities");
            Console.WriteLine("\n");
        }


    }
}
