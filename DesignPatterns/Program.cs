// See https://aka.ms/new-console-template for more information
using DesignPatterns;
using DesignPatterns.BehavioralDesignPatterns.MementoPattern;
using DesignPatterns.BehavioralDesignPatterns.StatePattern;
using DesignPatterns.BehavioralDesignPatterns.VisitorPattern;
using DesignPatterns.CreationalDesignPatterns.PrototypePattern;
using DesignPatterns.CreationalDesignPatterns.SingletonPattern;
using DesignPatterns.StructuralDesignPatterns.AdapterPattern;
using DesignPatterns.StructuralDesignPatterns.CompositePattern;
using DesignPatterns.StructuralDesignPatterns.DecoratorPattern;

TestState test = new ();

if (false)
{
    //Console.WriteLine("******************TestBehavioralPatternsTemplate*********************");

    //Console.WriteLine("******************TestMemento*********************");
    //test.State = new TestMemento();
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

    //Console.WriteLine("******************TestVisitorPattern********************");
    //test.State = new TestVisitorPattern();
    //test.TestPatterns();
    //Console.WriteLine("\n\n");
}

//
if (false)
{
    Console.WriteLine("******************TestStructuralDesignPatternsTemplate********************");
    Console.WriteLine();

    Console.WriteLine("******************TestCompositeDesignPattern********************");
    test.State = new TestCompositeDesignPattern();
    test.TestPatterns();
    Console.WriteLine("\n\n");

    Console.WriteLine("******************TestAdapterPattern********************");
    test.State = new TestAdapterPattern();
    test.TestPatterns();
    Console.WriteLine("\n\n");

    Console.WriteLine("******************TestDecoratorPattern********************");
    test.State = new TestDecoratorPattern();
    test.TestPatterns();
    Console.WriteLine("\n\n");
}

if (true)
{
        Console.WriteLine("******************TestCreationalDesignPatternsTemplate********************");
        Console.WriteLine();
    if (false)
    {
        Console.WriteLine("******************TestPrototypePattern********************");
        test.State = new TestPrototypePattern();
        test.TestPatterns();
        Console.WriteLine("\n\n");
    }
    if (true)
    {
        Console.WriteLine("******************TestSingletonPattern********************");
        test.State = new TestSingletonPattern();
        test.TestPatterns();
        Console.WriteLine("\n\n");

    }
}


Console.ReadLine();
