// See https://aka.ms/new-console-template for more information
using DesignPatterns;
using DesignPatterns.BehavioralDesignPatterns.VisitorPattern;

TestState test = new ();

//Console.WriteLine("******************TestMemento*********************");
//test.State = new TestMemento();
//test.TestPatterns();
//Console.WriteLine("\n\n");

//Console.WriteLine("******************TestState********************");
//test.State = new TestState();
//test.TestPatterns();
//Console.WriteLine("\n\n");

//Console.WriteLine("******************TestIterator********************");
//test.State = new TestIterator();
//test.TestPatterns();
//Console.WriteLine("\n\n");

//Console.WriteLine("******************TestStrategy********************");
//test.State = new TestStrategy();
//test.TestPatterns();
//Console.WriteLine("\n\n");


//Console.WriteLine("******************TestTemplateMethodPattern********************");
//test.State = new TestTemplateMethodPattern();
//test.TestPatterns();
//Console.WriteLine("\n\n");


//Console.WriteLine("******************TestCommandPattern********************");
//test.State = new TestCommandPattern();
//test.TestPatterns();
//Console.WriteLine("\n\n");

//Console.WriteLine("******************TestObserverPattern********************");
//test.State = new TestObserverPattern();
//test.TestPatterns();
//Console.WriteLine("\n\n");

Console.WriteLine("******************TestVisitorPattern********************");
test.State = new TestVisitorPattern();
test.TestPatterns();
Console.WriteLine("\n\n");

Console.ReadLine();
