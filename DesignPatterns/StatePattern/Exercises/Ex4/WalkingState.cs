namespace DesignPatterns.StatePattern.Exercises.Ex4
{
    internal class WalkingState : IDirectionState
    {
        public int CalculateETA()
        {
            return 1;
        }

        public void GetDirection()
        {
            Console.WriteLine($"Walking from A to B will take {CalculateETA()}h");

        }
    }
}
