namespace DesignPatterns.ObserverPattern
{
    public class TestObserverPattern : ITestState, ITestProblemState, ITestSolutionState
    {
        public void Test()
        {
            Console.WriteLine("Start TestCommandPattern Class\n");

            Console.WriteLine("What is Behavioral Patterns?");
            Console.WriteLine("-Deal with how objects interact and communicate. They focus on algorithms and the assignment of responsibilities");
            Console.WriteLine("\n");

            Console.WriteLine("What is this pattern?");
            Console.WriteLine("-");
            Console.WriteLine("\n");

            Console.WriteLine("Pattern Components:");
            Console.WriteLine("-");
            Console.WriteLine("-");
            Console.WriteLine("-");
            Console.WriteLine("-");
            Console.WriteLine("-");
            Console.WriteLine("***Look at the popup to see the pattern UML Diagram***");
            Console.WriteLine("\n");

            Console.WriteLine("OOP principles used in this pattern");
            Console.WriteLine("- ");
            Console.WriteLine("- ");
            Console.WriteLine("- ");
            Console.WriteLine("- ");
            Console.WriteLine("\n");

            Console.WriteLine("SOLID principles used in this pattern");

            Console.WriteLine("- ");
            Console.WriteLine("- ");
            Console.WriteLine("- ");
            Console.WriteLine("- ");
            Console.WriteLine("\n");

            Console.WriteLine("Problem");
            TestDesignPatternProblem();

            Console.WriteLine("solution Code");
            TestDesignPatternSolution();
        }

        public void TestDesignPatternProblem()
        {
            Console.WriteLine("Without using Command DP it's violate multiple SOLID principles:  \n");
            Console.WriteLine("- ");
            Console.WriteLine("problem:\n- a \n");

            Console.WriteLine("Problem Code");
            Console.WriteLine("Problem ex1");
        }

        public void TestDesignPatternSolution()
        {
            throw new NotImplementedException();
        }
    }
}
