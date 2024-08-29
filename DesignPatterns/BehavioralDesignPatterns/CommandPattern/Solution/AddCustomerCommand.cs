using DesignPatterns.BehavioralDesignPatterns.CommandPattern.Main;

namespace DesignPatterns.BehavioralDesignPatterns.CommandPattern.Solution
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
