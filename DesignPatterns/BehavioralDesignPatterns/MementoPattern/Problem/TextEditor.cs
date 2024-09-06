using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehavioralDesignPatterns.MementoPattern.Problem
{
    public class TextEditor
    {
        private string _text = "";
        private readonly Stack<string> _history = new Stack<string>();

        public void Type(string text)
        {
            _history.Push(_text); // Save the current state before changing it
            _text = text;
        }

        public void Undo()
        {
            if (_history.Count > 0)
            {
                _text = _history.Pop(); // Revert to the previous state
            }
        }

        public override string ToString()
        {
            return _text;
        }
    }
}
