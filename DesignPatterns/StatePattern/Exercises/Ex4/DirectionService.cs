namespace DesignPatterns.StatePattern.Exercises.Ex4
{
    internal class DirectionService
    {
        private IDirectionState _directionState;
        public IDirectionState directionState 
        { 
            get { return _directionState; }
            set { _directionState = value; }
        }

        public void GetDirection()
        {
            _directionState.GetDirection();
        }

    }
}
