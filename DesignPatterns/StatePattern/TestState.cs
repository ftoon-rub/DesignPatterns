using DesignPatterns.StatePattern.Exercises;
using DesignPatterns.StatePattern.Exercises.Abuse;
using DesignPatterns.StatePattern.Exercises.Ex4;

namespace DesignPatterns.StatePattern
{
    internal class TestState : ITestState
    {
        public void Test()
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
            AbuseContext.Click ();
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
    }
}
