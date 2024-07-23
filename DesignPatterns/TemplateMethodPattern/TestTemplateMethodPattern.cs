namespace DesignPatterns.TemplateMethodPattern
{
    internal class TestTemplateMethodPattern : ITestState
    {
        public void Test()
        {
            Console.WriteLine("Start TestStrategy Class\n");
            Console.WriteLine("Problem");

            Console.WriteLine("// 1 problem: is code duplication every time i create this structure, add prop AuditTrail and initialize it on the constractor\n // 2 problem: there is no blueprint interface or abstract class to ensure that every Task class created on further will have an execute method or AuditTrail object");
            Console.WriteLine("\n");

        }
    }
}
