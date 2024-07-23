namespace DesignPatterns.TemplateMethodPattern
{
    internal abstract class Task
    {
        private AuditTrail _auditTrail;
        protected Task(AuditTrail auditTrail)
        {
            _auditTrail = auditTrail;
        }
        public void execute()
        {
            _auditTrail.record();

            doExecute();
            Console.WriteLine("Generate Report");
        }

        public abstract void doExecute();
    }
}
