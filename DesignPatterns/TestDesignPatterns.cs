namespace DesignPatterns
{
    internal class TestDesignPatterns
    {
        private ITestState state;

        /// <summary>
        /// method calls a specific handler method based on its current state
        /// </summary>
        public void TestPatterns()
        {
            state.Test();
        }

        public ITestState State
        {
            get { return state; }
            set { state = value; }
        }
    }
}
