using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehavioralDesignPatterns.MementoPattern.Solution
{
    // Caretaker class to manage the history of states
    public class HistoryCaretaker
    {
        private readonly Stack<MementoSolution> _mementos = new Stack<MementoSolution>();

        public void SaveState(TextEditorOriginator editor)
        {
            _mementos.Push(editor.SaveState());
        }

        public void Undo(TextEditorOriginator editor)
        {
            if (_mementos.Count > 0)
            {
                var memento = _mementos.Pop();
                editor.RestoreState(memento);
            }
        }
    }
}
