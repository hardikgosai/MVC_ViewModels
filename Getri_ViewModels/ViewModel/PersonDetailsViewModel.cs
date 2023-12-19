using Getri_ViewModels.Models;

namespace Getri_ViewModels.ViewModel
{
    public class PersonDetailsViewModel
    {
        public Person Person { get; set; }

        public List<PersonAddress> Addresses { get; set; }
    }
}
