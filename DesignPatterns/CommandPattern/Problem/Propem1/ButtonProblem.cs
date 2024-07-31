namespace DesignPatterns.CommandPattern.Problem.Propem1
{
    internal class ButtonProblem
    {
        private string _lable;

        public void click()
        {
            Console.WriteLine("we don't now what will be here ");
        }
        public string lable
        {
            get
            {
                return _lable;
            }
            set { _lable = value; }
        }
    }
}
