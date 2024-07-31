namespace DesignPatterns.CommandPattern.Solution.Proplem2
{
    public class TextEditor
    {
        private string _text = "";

        public void AddText(string text)
        {
            //SRP adhered: only responsible for adding text
            _text += text; 
        }

        public void RemoveText(string text)
        {
            if (_text.EndsWith(text))
            {
                // SRP adhered: only responsible for removing text
                _text = _text.Substring(0, _text.Length - text.Length); 
            }
        }

        // SRP adhered: only responsible for getting text
        public string GetText() => _text; 
    }
}
