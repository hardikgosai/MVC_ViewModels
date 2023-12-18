using Getri_ViewModels.Models;
using Getri_ViewModels.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace Getri_ViewModels.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            List<StudentDetailViewModel> studentList = new List<StudentDetailViewModel>();
            Student student = new Student();
            student.StudentId = 101;
            student.Name = "John";
            student.Gender = "Male";
            student.Branch = "CSE";
            student.Section = "A";
            StudentAddress address = new StudentAddress();
            address.StudentId = 101;
            address.Country = "India";
            address.State = "Karnataka";
            address.City = "Bangalore";
            address.Pincode = 560001;
            StudentDetailViewModel studentDetailViewModel = new StudentDetailViewModel();
            studentDetailViewModel.Student = student;
            studentDetailViewModel.Address = address;
            studentList.Add(studentDetailViewModel);

            student = new Student();
            student.StudentId = 102;
            student.Name = "Mary";
            student.Gender = "Female";
            student.Branch = "CSE";
            student.Section = "B";
            address = new StudentAddress();
            address.StudentId = 102;
            address.Country = "India";
            address.State = "Gujarat";
            address.City = "Ahmedabad";
            address.Pincode = 380001;
            studentDetailViewModel = new StudentDetailViewModel();
            studentDetailViewModel.Student = student;
            studentDetailViewModel.Address = address;
            studentList.Add(studentDetailViewModel);
            return View(studentList);
        }
    }
}
