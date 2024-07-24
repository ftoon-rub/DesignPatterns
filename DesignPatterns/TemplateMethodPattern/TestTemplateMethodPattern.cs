using System.Diagnostics;

namespace DesignPatterns.TemplateMethodPattern
{
    internal class TestTemplateMethodPattern : ITestState, IUmlVeiwer
    {
        public void Test()
        {
            Console.WriteLine("Start TestTemplateMethodPattern Class\n");
            ViewDiagram();
            Console.WriteLine("Problem");
            Console.WriteLine("// 1 problem: is code duplication every time i create this structure, add prop AuditTrail and initialize it on the constractor\n // 2 problem: there is no blueprint interface or abstract class to ensure that every Task class created on further will have an execute method or AuditTrail object\n");
            Console.WriteLine("Like this");
            AuditTrailProblem auditTrailProblem = new();
            GenerateReportTaskProblem generateReportTask = new(auditTrailProblem);
            generateReportTask.execute();
            Console.WriteLine("\n");
            Console.WriteLine("solution");
            GenerateReportTask generateReport = new();
            Console.WriteLine("can't call generateReport.doExecute() method directly because it's use protected access modifier (it's make the method visible just for the sub classes) ");
            //generateReport.doExecute();
            Console.WriteLine("so we will call generateReport.execute() method that call doExecute() method inside it\n\nLike this:");
            generateReport.execute();

            Console.WriteLine("\n");



        }

        public void ViewDiagram()
        {
            string appDomin = AppDomain.CurrentDomain.BaseDirectory;
            string imagePath = Path.Combine(appDomin, @"PatternUmlDiagram\TemplateMethodPattern.png");

            // Check if the file exists
            if (System.IO.File.Exists(imagePath))
            {
                try
                {
                    // Start the default image viewer process
                    Process.Start("mspaint.exe", imagePath);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error opening image: " + ex.Message);
                }
            }
            else
            {
                Console.WriteLine("Image file not found: " + imagePath);
            }
        }
    }
}
