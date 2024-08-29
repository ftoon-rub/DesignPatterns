using DesignPatterns.BehavioralDesignPatterns.StatePattern.Exercises;

namespace DesignPatterns.BehavioralDesignPatterns.StatePattern.Exercises.Abuse
{
    internal class AbuseStopWatch
    {
        private IState _state;

        public AbuseStopWatch()
        {
            _state = new AbuseStoppedState(this);
        }

        public IState state
        {
            get { return _state; }
            set { _state = value; }
        }

        public void Click()
        {
            _state.Click();
        }
    }
}
