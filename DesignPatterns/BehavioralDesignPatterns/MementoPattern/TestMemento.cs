using DesignPatterns.BehavioralDesignPatterns.MementoPattern.Exercises.Ex1;
using DesignPatterns.BehavioralDesignPatterns.MementoPattern.Exercises.EX2;
using DesignPatterns.BehavioralDesignPatterns.MementoPattern.Main;
using DesignPatterns.BehavioralDesignPatterns.MementoPattern.Problem;
using DesignPatterns.BehavioralDesignPatterns.MementoPattern.Solution;

namespace DesignPatterns.BehavioralDesignPatterns.MementoPattern
{
    public class TestMemento : TestBehavioralPatternsTemplate
    {

        protected override void OopUsedInPattern()
        {
            Console.WriteLine("\t- Encapsulation:\r\nThe internal state of the Originator is hidden from the Caretaker. The Memento captures the state without exposing how it is stored.");
            Console.WriteLine("\t- Abstraction:\r\nThe Caretaker abstracts away the details of how states are stored and restored. The Memento provides a simplified interface to store the state.");
            Console.WriteLine("\t- Inheritance:\r\nNot directly used in this pattern, but you can create subclasses of Originator or Memento for specific use cases.");
            Console.WriteLine("\t- Polymorphism:\r\nWhile polymorphism is not central in this basic implementation, it can be used if we abstract Memento and Originator into interfaces or base classes.");
        }

        protected override void PatternComponents()
        {
            Console.WriteLine("\t- Originator: The object whose state needs to be saved and restored.\r\n");
            Console.WriteLine("\t- Memento: Stores the state of the Originator.\r\n");
            Console.WriteLine("\t- Caretaker: Responsible for keeping the Memento but does not modify its contents or access the Originator state.\r\n");
        }

        protected override void PatternDescription()
        {
            Console.WriteLine("\t- The Memento Pattern is a behavioral design pattern that allows capturing and storing the current state of an object in a way that the object can be restored later to this state without violating encapsulation. The main idea is to store the object’s internal state externally, but without exposing that state to external parties.");
            Console.WriteLine("\n");
            Console.WriteLine("When to Use:\r\n\t-When you need to save and restore an object's state (undo/redo functionality).\r\nWhen you want to implement checkpoints or save game states.\r\nWhen the state of the object is complex, and you want to encapsulate it without exposing its details.");
        }

        protected override void SolidUsedInPattern()
        {
            Console.WriteLine("\t- Single Responsibility Principle (SRP):\r\nEach class has a single responsibility. The Memento only stores the state, the Originator is responsible for saving/restoring its state, and the Caretaker manages the saved states.\n");
            Console.WriteLine("\t- Open/Closed Principle (OCP):\r\nThe pattern can be extended with new functionality (e.g., adding logging, modifying how states are saved) without modifying existing classes.\n");
            Console.WriteLine("\t- Liskov Substitution Principle (LSP):\r\nEach component of the pattern can be replaced by its subtype (if we had different versions of Memento, Originator, or Caretaker), and the program would still work correctly.\n");
            Console.WriteLine("\t- Interface Segregation Principle (ISP):\r\nThe Memento interface is not directly exposed, so it avoids exposing unnecessary methods to the Caretaker.\n");
            Console.WriteLine("\t- Dependency Inversion Principle (DIP):\r\nThe Caretaker depends on abstractions (Memento interface) rather than concrete implementations, though in this simple example we are not using interfaces, the concept still applies.\n");
        }

        protected override void TestDesignPatternMain()
        {
            // OOP: Abstraction - The exact details of how the state is saved and restored are abstracted away.
            var originator = new Originator<string>();
            var caretaker = new Caretaker<string>();

            // Save states and undo
            originator.State = "State 1";
            Console.WriteLine($"Current State: {originator.State}");
            caretaker.SaveState(originator); // State 1 saved
            caretaker.HistoryContent();

            originator.State = "State 2";
            Console.WriteLine($"Current State: {originator.State}");
            caretaker.SaveState(originator); // State 2 saved
            caretaker.HistoryContent();

            originator.State = "State 3";
            Console.WriteLine($"Current State: {originator.State}");
            caretaker.HistoryContent();

            caretaker.Undo(originator); // Undo to State 2
            Console.WriteLine($"After Undo: {originator.State}");
            caretaker.HistoryContent();
                    
            caretaker.Undo(originator); // Undo to State 1
            Console.WriteLine($"After Undo: {originator.State}");
            caretaker.HistoryContent();

        }

        protected void TestDesignPatternProblem()
        {
            Console.WriteLine("\t- Problem Example: Text Editor with Undo Functionality\r\nScenario: You have a simple text editor where users can type text and you want to implement an undo feature. The text editor needs to be able to revert to previous versions of the text when the user performs an undo action.");
            Console.WriteLine("\t -Issues:\r\nThe TextEditor class is responsible for both managing the text and handling the history of changes, which violates SRP.\r\nThe implementation is not easily extensible if you want to add more features, like redo functionality or saving multiple states.");
            
            var editor = new TextEditor();
            editor.Type("First Version");
            Console.WriteLine(editor); // Output: First Version

            editor.Type("Second Version");
            Console.WriteLine(editor); // Output: Second Version

            editor.Undo();
            Console.WriteLine(editor); // Output: First Version

            editor.Undo();
            Console.WriteLine(editor); // Output: (empty string)
        }

        protected void TestDesignPatternSolution()
        {
            var editor = new TextEditorOriginator();
            var history = new HistoryCaretaker();

            editor.Type("First Version");
            history.SaveState(editor);

            Console.WriteLine(editor); // Output: First Version

            editor.Type("Second Version");
            history.SaveState(editor);

            Console.WriteLine(editor); // Output: Second Version

            history.Undo(editor);
            Console.WriteLine(editor); // Output: First Version

            history.Undo(editor);
            Console.WriteLine(editor); // Output: (empty string)

        }
        public void Exercises()
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

            Document document = new Document();
            DocumentHistory history = new DocumentHistory();

            document.SetContent("a", "b", "c");
            history.Save(document);

            document.SetContent("d", "e", "f");
            history.Save(document);

            history.Undo(document);

        }

        protected override void Ex1()
        {
            throw new NotImplementedException();
        }
    }
}
