using Newtonsoft.Json;

namespace DesignPatterns
{
    internal class DocumentHistory
    {
        private Stack<MomentoDocument> history = new Stack<MomentoDocument>();

        public void Save(Document document)
        {
            history.Push(document.CreateState());
            Console.WriteLine($"Caretaker Saveing currnet state");

        }

        public void Undo(Document document)
        {
            if (history.Count>0)
            {
                var res = history.Pop();
                document.Restore(res);
                Console.WriteLine($"Undo And the Currnet Status: {res.GetAllState()}");
                
                Console.Write($"stack history:");
                foreach (var item in history)
                    Console.Write($"{JsonConvert.SerializeObject(item.GetAllState())} ");
            }
            else
            {
                Console.WriteLine("there is no status to undo");
            }
        }
    }
}
