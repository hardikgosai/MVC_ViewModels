using Getri_ViewModels.Models;

namespace Getri_ViewModels.ViewModel
{
    public class EmployeeDetailsViewModel
    {
        public Employee Employee { get; set; }

        public Address Address { get; set; }

        public string PageTitle { get; set; }

        public string PageHeader { get; set; } 
    }
}
