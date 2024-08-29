using Newtonsoft.Json;

namespace DesignPatterns.BehavioralDesignPatterns.MementoPattern.Exercises
{
    internal class Document

    {
        private string Content = string.Empty;
        private string FontName = string.Empty;
        private string FontSize = string.Empty;
        /// <summary>
        /// change the currnet content
        /// </summary>
        /// <param name="content"></param>
        public void SetContent(string content, string fontName, string fontSize)
        {
            Content = content;
            FontName = fontName;
            FontSize = fontSize;
            Console.WriteLine($"Originator Set Current Text: {Content}, {FontName},{FontSize}");
        }
        /// <summary>
        /// create new state (memento) with the currnet content
        /// </summary>
        /// <returns></returns>
        public MomentoDocument CreateState()
        {
            var mementoObj = new MomentoDocument(Content, FontName, FontSize);
            Console.WriteLine($"Originator createing memento state with content");
            Console.WriteLine(JsonConvert.SerializeObject(mementoObj.GetContentState()));
            Console.WriteLine(JsonConvert.SerializeObject(mementoObj.GetfontSizeState()));
            Console.WriteLine(JsonConvert.SerializeObject(mementoObj.GetfontNameState()));
            return mementoObj;
        }
        /// <summary>
        /// restore the currnet memento state
        /// </summary>
        /// <param name="memento"></param>
        public void Restore(MomentoDocument memento)
        {
            var currentM = memento.GetState();
            Console.WriteLine($"Originator Restored currentM Text: {currentM.GetContentState()}");
            Console.WriteLine($"Originator Restored currentM Text: {currentM.GetfontNameState()}");
            Console.WriteLine($"Originator Restored currentM Text: {currentM.GetfontSizeState()}");
        }
    }
}
