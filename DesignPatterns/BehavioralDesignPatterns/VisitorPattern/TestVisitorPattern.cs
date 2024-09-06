using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehavioralDesignPatterns.VisitorPattern
{
    public class TestVisitorPattern : TestBehavioralPatternsTemplate
    {
        protected override void OopUsedInPattern()
        {
            Console.WriteLine("******************OopUsedInPattern********************");
        }

        protected override void PatternCategory()
        {
            Console.WriteLine("******************PatternCategory********************");
        }

        protected override void PatternComponents()
        {
                Console.WriteLine("******************PatternComponents********************");
        }

        protected override void PatternDescription()
        {
                        Console.WriteLine("******************PatternDescription********************");
        }

        protected override void SolidUsedInPattern()
        {
                        Console.WriteLine("******************SolidUsedInPattern********************");
        }

        protected override void TestDesignPatternMain()
        {
                        Console.WriteLine("******************TestDesignPatternMain********************");
        }

        protected override void TestDesignPatternProblem()
        {
                        Console.WriteLine("******************TestDesignPatternProblem********************");
        }

        protected override void TestDesignPatternSolution()
        {
                        Console.WriteLine("******************TestDesignPatternSolution********************");
        }
    }
}
