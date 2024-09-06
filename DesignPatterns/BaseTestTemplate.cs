using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public abstract class BaseTestTemplate : ITestState
    {
        protected abstract void PatternCategory();
        protected abstract void PatternDescription();
        protected abstract void PatternComponents();
        protected abstract void SolidUsedInPattern();
        protected abstract void OopUsedInPattern();
        protected abstract void TestDesignPatternMain();
        protected abstract void TestDesignPatternProblem();
        protected abstract void TestDesignPatternSolution();

        public void Test()
        {
            Console.WriteLine("* What is Behavioral Patterns?");
            PatternCategory();

            Console.WriteLine();
            Console.WriteLine("* What is this pattern?");
            PatternDescription();
            //Console.WriteLine("***Look at the popup to see the pattern UML Diagram***");

            Console.WriteLine();
            Console.WriteLine("* Pattern Components:");
            PatternComponents();

            Console.WriteLine();
            Console.WriteLine("* SOLID principles used in this pattern");
            SolidUsedInPattern();

            Console.WriteLine();
            Console.WriteLine("* OOP principles used in this pattern");
            OopUsedInPattern();

            Console.WriteLine();
            Console.WriteLine("* main concept (generic)");
            TestDesignPatternMain();

            Console.WriteLine();
            Console.WriteLine("* Problem needs this pattern");
            TestDesignPatternProblem();

            Console.WriteLine();
            Console.WriteLine("* Solution of this problem by this Design pattern");
            TestDesignPatternSolution();
        }
    }
}
