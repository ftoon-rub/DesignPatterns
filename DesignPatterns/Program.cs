// See https://aka.ms/new-console-template for more information
using DesignPatterns;
using DesignPatterns.MementoPattern;
using DesignPatterns.StatePattern;

TestDesignPatterns test = new ();

Console.WriteLine("******************TestMemento*********************");
test.State = new TestMemento();
test.TestPatterns();
Console.WriteLine("\n\n");

Console.WriteLine("******************TestState********************");
test.State = new TestState();
test.TestPatterns();
Console.WriteLine("\n\n");

Console.ReadLine();
