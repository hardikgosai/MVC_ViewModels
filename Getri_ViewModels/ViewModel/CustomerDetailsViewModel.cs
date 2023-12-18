using Getri_ViewModels.Models;

namespace Getri_ViewModels.ViewModel
{
    public class CustomerDetailsViewModel
    {
        public Customer Customer { get; set; }

        public List<CustomerAddress> Address { get; set; }
    }
}
