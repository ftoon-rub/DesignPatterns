namespace DesignPatterns.TemplateMethodPattern
{
    internal class GenerateReportTask : Task
    {
        public GenerateReportTask(AuditTrail auditTrail) : base(auditTrail)
        {
        }

        public override void doExecute()
        {
            throw new NotImplementedException();
        }
    }
}
