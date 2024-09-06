using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehavioralDesignPatterns.MementoPattern.Solution
{
    // Memento class to store the state of the TextEditor
    public class MementoSolution
    {
        public string Text { get; private set; }

        public MementoSolution(string text)
        {
            Text = text;
        }
    }
}
