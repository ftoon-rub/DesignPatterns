using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehavioralDesignPatterns.MementoPattern.Solution
{
    // Originator class that manages the state of the TextEditor
    public class TextEditorOriginator
    {
        private string _text = "";

        public void Type(string text)
        {
            _text = text;
        }

        public MementoSolution SaveState()
        {
            return new MementoSolution(_text);
        }

        public void RestoreState(MementoSolution memento)
        {
            _text = memento.Text;
        }

        public override string ToString()
        {
            return _text;
        }
    }
}
