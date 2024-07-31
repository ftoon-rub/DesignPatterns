﻿using DesignPatterns.CommandPattern.Problem.Problem2;
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
            Console.WriteLine("Deal with how objects interact and communicate. They focus on algorithms and the assignment of responsibilities");
            Console.WriteLine("\n");

            Console.WriteLine("What is this pattern?");
            Console.WriteLine("The Command Design Pattern is used to encapsulate a request as an object, thereby allowing for parameterization of clients with queues, requests, and operations. \nIt is useful when you need to decouple the object that invokes the operation from the one that knows how to perform it. \nThis pattern helps to follow the Single Responsibility Principle (SRP) by separating the responsibility of issuing a request from executing it.");
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

            Console.WriteLine("Single Responsibility Principle (SRP)");
            Console.WriteLine("Open/Closed Principle (OCP)");
            Console.WriteLine("Interface Segregation Principle (ISP)");
            Console.WriteLine("Dependency Inversion Principle (DIP)");
            Console.WriteLine("\n");

            Console.WriteLine("Problem");
            TestDesignPatternProblem();

            Console.WriteLine("solution Code");
            TestDesignPatternSolution();
        }

        public void TestDesignPatternProblem()
        {
            Console.WriteLine("//problem:  a simple text editor application where users can type text, undo their typing, and redo it. Without the Command Pattern, the code can quickly become complex and difficult to maintain.\n");
            Console.WriteLine("//Without using Command DP it's violate multiple SOLID principles:  \n");
            Console.WriteLine("/Single Responsibility Principle (SRP): Methods like Type, Undo, and Redo have multiple responsibilities.\r\nOpen/Closed Principle (OCP): Adding new commands (like copy, paste) requires modifying the existing class.\r\nInterface Segregation Principle (ISP): All methods are in a single class, leading to a bloated interface.\n");

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
