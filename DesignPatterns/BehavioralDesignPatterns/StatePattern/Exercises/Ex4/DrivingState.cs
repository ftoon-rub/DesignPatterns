using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehavioralDesignPatterns.StatePattern.Exercises.Ex4
{
    internal class DrivingState : IDirectionState
    {
        public int CalculateETA()
        {
            return 20;
        }

        public void GetDirection()
        {
            Console.WriteLine($"Driving by car from A to B will take {CalculateETA()}m");
        }
    }
}
