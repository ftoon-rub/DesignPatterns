namespace DesignPatterns.TemplateMethodPattern
{
    internal class TransferMoneyTask : Task
    {
        // it use the constrator from the base class
        public TransferMoneyTask(AuditTrail auditTrail) : base(auditTrail)
        {
        }

        protected override void doExecute()
        {
            Console.WriteLine("TransferMoneyTask solution");
        }
    }
}
