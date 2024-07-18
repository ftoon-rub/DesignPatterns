namespace DesignPatterns.StatePattern
{
    internal class TestState
    {
        public void Test()
        {
            Context context = new ();
            context.State = new ConcreteStatesA();
            context.Request();
            context.State = new ConcreteStatesB();
            context.Request();
        }
    }
}
