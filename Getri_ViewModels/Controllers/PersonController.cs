using Getri_ViewModels.Models;
using Getri_ViewModels.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace Getri_ViewModels.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            List<PersonDetailsViewModel> personDetailsViewModels = new List<PersonDetailsViewModel>();

            Person person= new Person()
            {
                PersonId = 1,
                Name = "John",
                Contact = "1234567890",
                Email = "abc@xyz.com",
                Gender = "Male"
            };

            List<PersonAddress> Addreses = new List<PersonAddress>()
            {
                new PersonAddress()
                {                    
                    PersonId = 1,                    
                    City = "Jamnagar",
                    State = "Gujarat",
                    Country = "India",
                    Pincode = 123456
                },
                new PersonAddress()
                {
                    PersonId = 1,                    
                    City = "Indor",
                    State = "MadhyaPradesh",
                    Country = "India",
                    Pincode = 123456
                }
            };

            PersonDetailsViewModel personDetailsViewModel = new PersonDetailsViewModel()
            {
                Person = person,
                Addresses = Addreses
            };

            personDetailsViewModels.Add(personDetailsViewModel);

            Person person1 = new Person()
            {
                PersonId = 2,
                Name = "Mary",
                Contact = "1234567890",
                Email = "abc@xyz.com",
                Gender = "Female"
            };

            List<PersonAddress> Addresses1 = new List<PersonAddress>()
            {
                new PersonAddress()
                {
                    PersonId = 2,
                    City = "Rajkot",
                    State = "Gujarat",
                    Country = "India",
                    Pincode = 123456
                },
                new PersonAddress()
                {
                    PersonId = 2,
                    City = "Ujjain",
                    State = "MadhyaPradesh",
                    Country = "India",
                    Pincode = 123456
                }
            };

            PersonDetailsViewModel personDetailsViewModel2 = new PersonDetailsViewModel()
            {
                Person = person1,
                Addresses = Addresses1
            };

            personDetailsViewModels.Add(personDetailsViewModel2);

            return View(personDetailsViewModels);
        }
    }
}
