using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.BehavioralDesignPatterns.StatePattern.Exercises;

namespace DesignPatterns.BehavioralDesignPatterns.StatePattern.Exercises.Abuse
{
    internal class AbuseStoppedState : IState
    {
        private AbuseStopWatch _StopWatch;

        public AbuseStoppedState(AbuseStopWatch stopWatch)
        {
            _StopWatch = stopWatch;
        }

        public void Click()
        {
            Console.WriteLine("Stop State");
            _StopWatch.state = new AbuseRunningState(_StopWatch);
        }
    }
}
