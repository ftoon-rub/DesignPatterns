namespace DesignPatterns.BehavioralDesignPatterns.TemplateMethodPattern.Problem
{
    internal class GenerateReportTaskProblem
    {
        // 1 problem: is code duplication every time i create this structure, add prop AuditTrail and initialize it on the constractor
        // 2 problem: there is no blueprint interface or abstract class to ensure that every Task class created on further will have an execute method or AuditTrail object

        private AuditTrailProblem _auditTrail;
        public GenerateReportTaskProblem(AuditTrailProblem auditTrail)
        {
            _auditTrail = auditTrail;
        }

        public void execute()
        {
            _auditTrail.record();
            Console.WriteLine("GenerateReportTaskProblem");
        }
    }
}
