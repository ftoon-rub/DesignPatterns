namespace DesignPatterns.TemplateMethodPattern
{
    internal class GenerateReportTask : Task
    {
        //it use the defulte constrator from the base class
        protected override void doExecute()
        {
            Console.WriteLine("GenerateReportTask solution");
        }
    }
}
