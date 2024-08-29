namespace DesignPatterns.BehavioralDesignPatterns.TemplateMethodPattern.Solution
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
