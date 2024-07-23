namespace DesignPatterns.TemplateMethodPattern
{
    internal class TransferMoneyTask : Task
    {
        private AuditTrail _auditTrail;

        public TransferMoneyTask(AuditTrail auditTrail)
        {
            _auditTrail = auditTrail;
        }
        public override void doExecute()
        {
            throw new NotImplementedException();
        }
    }
}
