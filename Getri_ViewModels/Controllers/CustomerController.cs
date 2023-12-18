using Getri_ViewModels.Models;
using Getri_ViewModels.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace Getri_ViewModels.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            List<CustomerDetailsViewModel> Customers = new List<CustomerDetailsViewModel>();
            Customer customer = new Customer();
            customer.CustomerId = 101;
            customer.CustomerName = "John";
            customer.CustomerEmail = "abc@xyz.com";
            customer.CustomerContact = "1234567890";
            customer.CustomerGender = "Male";

            CustomerAddress address = new CustomerAddress();
            address.CustomerId = 101;
            address.Country = "India";
            address.State = "Karnataka";
            address.City = "Bangalore";
            address.Pincode = 560001;

            CustomerAddress address1 = new CustomerAddress();
            address1.CustomerId = 101;
            address1.Country = "India";
            address1.State = "Gujarat";
            address1.City = "Ahmedabad";
            address1.Pincode = 380001;


            CustomerDetailsViewModel customerDetailsViewModel = new CustomerDetailsViewModel();
            customerDetailsViewModel.Customer = customer;
            
            customerDetailsViewModel.Address = new List<CustomerAddress>();

            customerDetailsViewModel.Address.Add(address);
            customerDetailsViewModel.Address.Add(address1);
            Customers.Add(customerDetailsViewModel);

            return View(Customers);
        }
    }
}
