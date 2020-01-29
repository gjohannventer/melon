using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClinicManagement.Core.ViewModel
{
    public class test
    {
        public bool? IsActive { get; set; }
        public IEnumerable<SelectListItem> RolesList { get; set; }
    }
}