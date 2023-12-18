using Getri_ViewModels.Models;
using Getri_ViewModels.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace Getri_ViewModels.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            EmployeeDetailsViewModel viewModel = new EmployeeDetailsViewModel();
            
            viewModel.Employee = new Employee();
            viewModel.Employee.EmpId = 101; 
            viewModel.Employee.EmpName = "John";
            viewModel.Employee.EmpSal = 10000;
            viewModel.Employee.EmpGender = "Male";
            viewModel.Employee.EmpDept = "IT";
            viewModel.Employee.AddressId = 1;

            viewModel.Address = new Address();
            viewModel.Address.AddressId = 1;
            viewModel.Address.Country = "India";
            viewModel.Address.State = "Karnataka";
            viewModel.Address.City = "Bangalore";
            viewModel.Address.Pincode = 560001;
            
            viewModel.PageTitle = "Employee Details";
            viewModel.PageHeader = "Employee Information";
            
            return View(viewModel);            
        }
    }
}
