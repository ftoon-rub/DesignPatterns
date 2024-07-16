namespace DesignPatterns.MementoPattern
{
    internal class TestMemento
    {
        public void Test()
        {
            Caretaker caretaker = new();
            Originator originator = new();

            originator.SetContent("a");
            caretaker.Save(originator);

            originator.SetContent("c");
            caretaker.Save(originator);

            originator.SetContent("b");
            caretaker.Save(originator);

            caretaker.Undo(originator);

            
        }
    }
}
