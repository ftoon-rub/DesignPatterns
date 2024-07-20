namespace DesignPatterns.StatePattern.Exercises.Abuse
{
    internal class AbuseRunningState : IState
    {
        private AbuseStopWatch _stopWatch;


        public AbuseRunningState(AbuseStopWatch stopWatch) 
        {
            _stopWatch = stopWatch;
        }
        public void Click()
        {
            Console.WriteLine("Running State");
            _stopWatch.state = new AbuseStoppedState(_stopWatch);
        }
    }
}
