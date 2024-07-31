using DesignPatterns.CommandPattern.Problem.Problem2;
using DesignPatterns.CommandPattern.Solution.Proplem1;
using DesignPatterns.CommandPattern.Solution.Proplem2;

namespace DesignPatterns.CommandPattern
{
    internal class TestCommandPattern : ITestState, ITestProblemState ,ITestSolutionState
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
            TestDesignPatternProblem();

            Console.WriteLine("solution Code");
            TestDesignPatternSolution();
        }

        public void TestDesignPatternProblem()
        {
            Console.WriteLine("// 1 problem: \n");

            Console.WriteLine("Problem Code");
            Console.WriteLine("Problem 2");
            TextEditorProblem editor = new();

            Console.WriteLine("Initial text: " + editor.GetText());

            editor.Type("Hello");
            Console.WriteLine("After typing 'Hello': " + editor.GetText());

            editor.Type(", World!");
            Console.WriteLine("After typing ', World!': " + editor.GetText());

            editor.Undo();
            Console.WriteLine("After undo: " + editor.GetText());

            editor.Undo();
            Console.WriteLine("After second undo: " + editor.GetText());

            editor.Redo();
            Console.WriteLine("After redo: " + editor.GetText());

            editor.Type(" Again!");
            Console.WriteLine("After typing ' Again!': " + editor.GetText());

            editor.Undo();
            Console.WriteLine("After third undo: " + editor.GetText());

            editor.Redo();
            Console.WriteLine("After second redo: " + editor.GetText());
            Console.WriteLine("\n");
        }

        public void TestDesignPatternSolution()
        {
            Console.WriteLine("Problem1");

            CustomerService customerService = new CustomerService();
            AddCustomerCommand customerCommand = new(customerService);
            Button button = new(customerCommand);
            button.click();
            Console.WriteLine("\n");


            Console.WriteLine("Problem2");

            TextEditor editor = new TextEditor();
            CommandManager manager = new CommandManager();

            manager.ExecuteCommand(new TypeCommand(editor, "Hello")); // OCP adhered: adding new commands without modifying existing code
            Console.WriteLine(editor.GetText()); // Outputs: Hello

            manager.ExecuteCommand(new TypeCommand(editor, " World")); // OCP adhered: adding new commands without modifying existing code
            Console.WriteLine(editor.GetText()); // Outputs: Hello World

            manager.Undo(); // SRP adhered: separate undo logic
            Console.WriteLine(editor.GetText()); // Outputs: Hello

            manager.Redo(); // SRP adhered: separate redo logic
            Console.WriteLine(editor.GetText()); // Outputs: Hello World

        }
    }
}
