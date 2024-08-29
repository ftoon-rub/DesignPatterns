namespace DesignPatterns.BehavioralDesignPatterns.CommandPattern.Solution.Proplem2
{
    // Invoker class adheres to SRP by handling command execution logic
    public class CommandManager
    {
        private Stack<ICommand> _undoStack = new Stack<ICommand>();
        private Stack<ICommand> _redoStack = new Stack<ICommand>();

        public void ExecuteCommand(ICommand command)
        {
            command.Execute(); // DIP adhered: depends on abstraction, not concrete command
            _undoStack.Push(command);
            _redoStack.Clear();
        }

        public void Undo()
        {
            if (_undoStack.Count > 0)
            {
                var command = _undoStack.Pop();
                command.Unexecute(); // DIP adhered: depends on abstraction, not concrete command
                _redoStack.Push(command);
            }
        }

        public void Redo()
        {
            if (_redoStack.Count > 0)
            {
                var command = _redoStack.Pop();
                command.Execute(); // DIP adhered: depends on abstraction, not concrete command
                _undoStack.Push(command);
            }
        }
    }
}
