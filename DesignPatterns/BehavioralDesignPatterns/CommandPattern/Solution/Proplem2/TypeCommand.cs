namespace DesignPatterns.BehavioralDesignPatterns.CommandPattern.Solution.Proplem2
{
    /// <summary>
    /// ConcreteCommand for typing text
    /// </summary>
    public class TypeCommand : ICommand
    {
        private TextEditor _editor;
        private string _text;

        public TypeCommand(TextEditor editor, string text)
        {
            _editor = editor;
            _text = text;
        }

        public void Execute()
        {
            // SRP adhered: only responsible for execution
            _editor.AddText(_text);
        }

        public void Unexecute()
        {
            // SRP adhered: only responsible for unexecution
            _editor.RemoveText(_text);
        }
    }
}
