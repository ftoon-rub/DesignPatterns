namespace DesignPatterns.CommandPattern.Solution.Proplem1
{
    public class Button
    {
        private string _lable;
        private ICommand command;

        public Button(ICommand command)
        {
            this.command = command;
        }

        public void click()
        {
            command.execute();
        }

        public string lable { get { return _lable; } set { _lable = value; } }
    }
}
