namespace DesignPatterns.BehavioralDesignPatterns.MementoPattern.Exercises
{
    internal class MomentoDocument
    {
        private readonly string Content;
        private readonly string fontName;
        private readonly string fontSize;

        public MomentoDocument(string Content, string fontName, string fontSize)
        {
            this.Content = Content;
            this.fontName = fontName;
            this.fontSize = fontSize;
        }
        /// <summary>
        /// get the current states
        /// </summary>
        /// <returns></returns>
        public MomentoDocument GetState()
        {
            return this;
        }
        public string GetAllState()
        {
            return $"{Content}, {fontName}, {fontSize}";
        }
        public string GetContentState()
        {
            return Content;
        }
        public string GetfontNameState()
        {
            return fontName;
        }
        public string GetfontSizeState()
        {
            return fontSize;
        }

    }
}
