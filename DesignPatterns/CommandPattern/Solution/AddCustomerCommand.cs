namespace DesignPatterns.CommandPattern
{
    internal class AddCustomerCommand : ICommand
    {
        private CustomerService _customerService;

        public AddCustomerCommand(CustomerService customerService)
        {
            _customerService = customerService;
        }

        public void execute()
        {
            _customerService.addCustomer();
            Console.WriteLine(nameof(AddCustomerCommand));
        }
    }
}
