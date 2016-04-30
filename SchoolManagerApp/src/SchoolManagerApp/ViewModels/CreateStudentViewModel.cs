using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagerApp.ViewModels
{
    public class CreateStudentViewModel
    {
        [Required][Display(Name ="First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Personal Number")]
        public long PersonalNumber { get; set; }
    }
}
