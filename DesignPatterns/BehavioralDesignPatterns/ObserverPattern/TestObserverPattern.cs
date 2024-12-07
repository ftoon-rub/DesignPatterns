using DesignPatterns.BehavioralDesignPatterns.ObserverPattern.Main;

namespace DesignPatterns.BehavioralDesignPatterns.ObserverPattern
{
    public class TestObserverPattern : TestBehavioralPatternsTemplate
    {
        protected override void Ex1()
        {
            throw new NotImplementedException();
        }

        //public void Test()
        //{
        //    Console.WriteLine("Start TestObserverPattern Class\n");

        //    Console.WriteLine("What is Behavioral Patterns?");
        //    Console.WriteLine("-Deal with how objects interact and communicate. They focus on algorithms and the assignment of responsibilities");
        //    Console.WriteLine("\n");

        //    Console.WriteLine("What is this pattern?");
        //    Console.WriteLine("- The Observer Design Pattern is a behavioral design pattern that defines a one-to-many dependency between objects. When one object (the subject) changes its state, all its dependents (the observers) are notified and updated automatically. This pattern is particularly useful when changes in one object need to trigger updates in multiple other objects without tightly coupling them.");
        //    Console.WriteLine("\n- Push vs. Pull Model");
        //    Console.WriteLine("- Push Model: The subject sends the updated state directly to the observers. The observer receives the data whether it needs it or not.");
        //    Console.WriteLine("- Pull Model: The subject only notifies the observers that something has changed, and the observers pull the state they need by querying the subject.");
        //    Console.WriteLine("\n");

        //    Console.WriteLine("When to Use the this pattern?");
        //    Console.WriteLine("- Event Handling Systems: When one change in a state needs to trigger updates in multiple objects (e.g., UI updates).");
        //    Console.WriteLine("- Broadcasting Communication: When multiple objects need to be informed about a change in a single object (e.g., a change in data or configuration).");
        //    Console.WriteLine("- Decoupling: When you want to minimize the dependencies between objects, making your system more flexible and easier to maintain.");
        //    Console.WriteLine("\n");

        //    Console.WriteLine("Pattern Components:");
        //    Console.WriteLine("- Subject Interface (ISubject<T>):\r\n\r\nDeclares methods to register, remove, and notify observers.");
        //    Console.WriteLine("- Observer Interface (IObserver<T>):\r\n\r\nDeclares the Update method, which observers will implement to receive updates.");
        //    Console.WriteLine("- Concrete Subject (ConcreteSubject):\r\n\r\nImplements the subject interface.\r\nHolds the state and notifies observers when the state changes.");
        //    Console.WriteLine("- Concrete Observers (ConcreteObserverPush and ConcreteObserverPull):\r\n\r\nImplement the observer interface.\r\nConcreteObserverPush receives data directly from the subject (Push model).\r\nConcreteObserverPull pulls data from the subject (Pull model).");

        //    //Console.WriteLine("***Look at the popup to see the pattern UML Diagram***");
        //    Console.WriteLine("\n");

        //    Console.WriteLine("OOP principles used in this pattern");
        //    Console.WriteLine("- Encapsulation: The state in ConcreteSubject is encapsulated and accessed through a property.");
        //    Console.WriteLine("- Abstraction: ISubject<T> and IObserver<T> provide abstract interfaces for subjects and observers.");
        //    Console.WriteLine("- Inheritance: Not explicitly used but can be applied in extending observer or subject functionalities.");
        //    Console.WriteLine("- Polymorphism: Observers implement the Update method polymorphically.");
        //    Console.WriteLine("\n");

        //    Console.WriteLine("SOLID principles used in this pattern");

        //    Console.WriteLine("-Single Responsibility Principle: Each class has a single responsibility (e.g., the subject manages state and observers, while observers react to state changes). ");
        //    Console.WriteLine("- Open/Closed Principle: The system is open for extension (new observers can be added) but closed for modification (existing classes don’t need changes).");
        //    Console.WriteLine("- Liskov Substitution Principle: Observers can be replaced with any other observer implementation.");
        //    Console.WriteLine("- Interface Segregation Principle: Separate interfaces (ISubject<T>, IObserver<T>) are used for different purposes, ensuring that classes don't need to implement methods they don't use.");
        //    Console.WriteLine("- Dependency Inversion Principle: High-level modules (the main program) do not depend on low-level modules; both depend on abstractions.");
        //    Console.WriteLine("\n");

        //    Console.WriteLine("Main Generic Code ex");
        //    TestDesignPatternMain();

        //    //Console.WriteLine("Problem");
        //    //TestDesignPatternProblem();

        //    //Console.WriteLine("solution Code");
        //    //TestDesignPatternSolution();
        //}

        //public void TestDesignPatternMain()
        //{
        //    // SOLID Principle: Open/Closed Principle (OCP)
        //    // The system is open for extension (new observers can be added) but closed for modification (existing code doesn't need changes).
        //    ConcreteSubject subject = new ConcreteSubject();

        //    Main.IObserver<string> observerPush = new ConcreteObserverPush();
        //    Main.IObserver<string> observerPull = new ConcreteObserverPull(subject);

        //    // Register observers with the subject
        //    subject.RegisterObserver(observerPush);
        //    subject.RegisterObserver(observerPull);

        //    // Change the state of the subject, triggering notifications
        //    subject.State = "State 1";
        //    subject.State = "State 2";
        //}

        //public void TestDesignPatternProblem()
        //{
        //    Console.WriteLine("Without using Command DP it's violate multiple SOLID principles:  \n");
        //    Console.WriteLine("- ");
        //    Console.WriteLine("problem:\n- a \n");

        //    Console.WriteLine("Problem Code");
        //    Console.WriteLine("Problem ex1");
        //}

        //public void TestDesignPatternSolution()
        //{
        //    throw new NotImplementedException();
        //}
        protected override void OopUsedInPattern()
        {
            throw new NotImplementedException();
        }

        protected override void PatternComponents()
        {
            throw new NotImplementedException();
        }

        protected override void PatternDescription()
        {
            throw new NotImplementedException();
        }

        protected override void SolidUsedInPattern()
        {
            throw new NotImplementedException();
        }

        protected override void TestDesignPatternMain()
        {
            throw new NotImplementedException();
        }

        protected void TestDesignPatternProblem()
        {
            throw new NotImplementedException();
        }

        protected void TestDesignPatternSolution()
        {
            throw new NotImplementedException();
        }
    }
}
