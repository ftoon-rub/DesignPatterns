namespace DesignPatterns.BehavioralDesignPatterns.CommandPattern.Problem.Problem2
{
    public class TextEditorProblem
    {
        private string _text = "";
        private Stack<string> _undoStack = new Stack<string>();
        private Stack<string> _redoStack = new Stack<string>();

        public void Type(string newText)
        {
            _undoStack.Push(_text); // SRP violated: undo logic inside Type method
            _text += newText;
            _redoStack.Clear(); // SRP violated: redo stack logic inside Type method
        }

        public void Undo()
        {
            if (_undoStack.Count > 0)
            {
                _redoStack.Push(_text); // SRP violated: redo logic inside Undo method
                _text = _undoStack.Pop();
            }
        }

        public void Redo()
        {
            if (_redoStack.Count > 0)
            {
                _undoStack.Push(_text); // SRP violated: undo logic inside Redo method
                _text = _redoStack.Pop();
            }
        }

        public string GetText() => _text;
    }
}
