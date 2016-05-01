using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagerApp.ViewModels
{
    public class CreateCourseViewModel
    {
        [Required]
        public string Name { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public int StudentId { get; set; }

        public int TeacherId { get; set; }

    }
}
