namespace DesignPatterns.TemplateMethodPattern
{
    internal abstract class Task
    {
        private AuditTrail _auditTrail;
        public Task()
        {
            _auditTrail = new AuditTrail();
        }
        public Task(AuditTrail auditTrail)
        {
            _auditTrail = auditTrail;
        }
        public void execute()
        {
            _auditTrail.record();
              
            doExecute();
            Console.WriteLine("Task solution");
        }

        public abstract void doExecute();
    }
}
