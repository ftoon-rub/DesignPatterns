namespace DesignPatterns.MementoPattern
{
    internal class TestMemento : ITestState
    {
        public void Test()
        {
            //Caretaker caretaker = new();
            //Originator originator = new();

            //originator.SetContent("a");
            //caretaker.Save(originator);

            //originator.SetContent("c");
            //caretaker.Save(originator);

            //originator.SetContent("b");
            //caretaker.Save(originator);

            //caretaker.Undo(originator);

            Document document = new Document();
            DocumentHistory history = new DocumentHistory();

            document.SetContent("a","b","c");
            history.Save(document);

            document.SetContent("d", "e", "f");
            history.Save(document);

            history.Undo(document);

        }
    }
}
