using DesignPatterns.CommandPattern.Solution.fx;

namespace DesignPatterns.CommandPattern
{
    internal class TestCommandPattern : ITestState
    {
        public void Test()
        {
            Console.WriteLine("Start TestCommandPattern Class\n");

            Console.WriteLine("What is Behavioral Patterns?");
            Console.WriteLine("...");
            Console.WriteLine("\n");

            Console.WriteLine("What is this pattern?");
            Console.WriteLine("...");
            Console.WriteLine("\n");

            Console.WriteLine("Pattern Components:");
            Console.WriteLine("...");
            Console.WriteLine("...");
            Console.WriteLine("...");
            Console.WriteLine("***Look at the popup to see the pattern UML Diagram***");
            Console.WriteLine("\n");

            Console.WriteLine("OOP principles used in this pattern");
            Console.WriteLine("...");
            Console.WriteLine("...");
            Console.WriteLine("...");
            Console.WriteLine("\n");

            Console.WriteLine("SOLID principles used in this pattern");
            Console.WriteLine("...");
            Console.WriteLine("...");
            Console.WriteLine("...");
            Console.WriteLine("\n");

            Console.WriteLine("Problem");
            Console.WriteLine("// 1 problem: \n");

            Console.WriteLine("Problem Code");
            Console.WriteLine("\n");

            Console.WriteLine("solution Code");
            CustomerService customerService = new CustomerService();
            AddCustomerCommand customerCommand = new(customerService);
            Button button = new(customerCommand);
            button.click();
            Console.WriteLine("\n");
        }
    }
}
