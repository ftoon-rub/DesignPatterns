using DesignPatterns.BehavioralDesignPatterns.StatePattern.Exercises.Abuse;
using DesignPatterns.BehavioralDesignPatterns.StatePattern.Exercises.Ex4;
using DesignPatterns.BehavioralDesignPatterns.StatePattern.Main;

namespace DesignPatterns.BehavioralDesignPatterns.StatePattern
{
    internal class TestStatePattarn : TestBehavioralPatternsTemplate
    {
        public void Exercises()
        {
            #region ex1
            Console.WriteLine("------------------Ex1--------------------");
            Context context = new();
            context.State = new ConcreteStatesA();
            context.Request();
            context.State = new ConcreteStatesB();
            context.Request();
            #endregion

            #region ex2
            Console.WriteLine("------------------Ex2 Abuse--------------------");
            AbuseStopWatch AbuseContext = new AbuseStopWatch();
            AbuseContext.Click();
            AbuseContext.Click();
            AbuseContext.Click();
            #endregion

            #region ex3
            Console.WriteLine("------------------Ex3--------------------");
            DirectionService directionService = new();
            directionService.directionState = new DrivingState();
            directionService.GetDirection();
            directionService.directionState = new WalkingState();
            directionService.GetDirection();
            #endregion
        }

        protected override void OopUsedInPattern()
        {
            Console.WriteLine("\t- Encapsulation: The State pattern encapsulates state-specific behaviors and transitions into separate classes, hiding the complexity from the Context class.");
            Console.WriteLine("\t- Polymorphism: The Context class interacts with different state objects through a common interface (IState), demonstrating polymorphic behavior.");
            Console.WriteLine("\t- Abstraction: The State pattern abstracts the implementation details of state-specific behaviors and transitions, exposing only the interface to the Context.");
        }

        protected override void PatternComponents()
        {
            Console.WriteLine("\t- Context Class: This class maintains a reference to an instance of a State subclass and delegates state-specific behavior to this instance.");
            Console.WriteLine("\t- State Interface: Defines the interface for encapsulating state-specific behavior.");
            Console.WriteLine("\t- Concrete States: Implement specific behavior for different states by implementing the State interface.");
        }

        protected override void PatternDescription()
        {
            Console.WriteLine("\t- The State Pattern is one of the behavioral design patterns described by the Gang of Four. It allows an object to alter its behavior when its internal state changes, appearing as if the object changed its class. This pattern is particularly useful for managing the state-specific behavior of an object.");
            Console.WriteLine("When to Use the State Pattern\r\n\t- Object Behavior Varies with State: The behavior of an object varies based on its internal state, and you want to avoid complex conditional statements for state-based behavior.\r\n\t- State Transitions: You need to manage state transitions explicitly and want to encapsulate state-specific behaviors and transitions in separate classes.\r\n\t- State-Specific Methods: You want to avoid having numerous state-specific methods in a single class.");
        }

        protected override void SolidUsedInPattern()
        {
            Console.WriteLine("\t- Single Responsibility Principle (SRP): \nEach state class handles only one type of behavior. The Context class delegates state-specific behavior to state objects, adhering to SRP.");
            Console.WriteLine("\t- Open/Closed Principle (OCP): \nYou can add new states without modifying existing state or context classes. New states are introduced by implementing the IState interface.");
            Console.WriteLine("\t- Liskov Substitution Principle (LSP): \nAll concrete states can be substituted for one another without altering the desirable properties of the program, as long as they implement the IState interface.");
            Console.WriteLine("\t- Interface Segregation Principle (ISP): The IState interface is tailored to state-specific behavior, allowing classes to only depend on what they use.");
            Console.WriteLine("\t- Dependency Inversion Principle (DIP): The Context class depends on the IState interface, not on concrete state classes, promoting abstraction.");
        }

        protected override void TestDesignPatternMain()
        {
            throw new NotImplementedException();
        }

        protected override void TestDesignPatternProblem()
        {
            throw new NotImplementedException();
        }

        protected override void TestDesignPatternSolution()
        {
            throw new NotImplementedException();
        }
    }
}
