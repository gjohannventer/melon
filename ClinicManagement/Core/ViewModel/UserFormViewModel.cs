using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace ClinicManagement.Core.ViewModel
{
    public class UserFormViewModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        public bool? IsActive { get; set; }
        [Required]
        public List<SelectListItem> RolesList { get; set; }
    }
}