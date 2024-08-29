namespace DesignPatterns.BehavioralDesignPatterns.TemplateMethodPattern.Solution
{
    internal abstract class Task
    {
        private AuditTrail _auditTrail;
        //GenerateReportTask use this constractor 
        protected Task()
        {
            _auditTrail = new AuditTrail();
        }
        //TransferMoneyTask use this constractor 
        protected Task(AuditTrail auditTrail)
        {
            _auditTrail = auditTrail;
        }
        public void execute()
        {
            Console.WriteLine("Task execute");
            _auditTrail.record();
            doExecute();
        }

        protected abstract void doExecute();
    }
}
