using System.ComponentModel.DataAnnotations;

namespace PFPE_CSharp_Tasks.Web.ViewModels
{
    public class CreateTestViewModel
    {
        [Display(Name = "name"), Required(ErrorMessage = "required")]
        public string Name { get; set; }
    }
}
