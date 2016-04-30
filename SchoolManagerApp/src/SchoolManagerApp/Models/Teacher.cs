using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagerApp.Models
{
    public class Teacher
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
        
        public int CourseId { get; set; }

        public virtual Course CourseName { get; set; }

        public ICollection<Course> Courses { get; set; }
    }
}
