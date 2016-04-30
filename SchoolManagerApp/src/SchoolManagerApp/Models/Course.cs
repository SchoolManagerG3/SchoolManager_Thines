using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagerApp.Models
{
    public class Course
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }
      
        public int StudentId { get; set; }

        public int TeacherId { get; set; }

        public virtual Student StudentName { get; set; }

        public ICollection<Student> Students { get; set; }

   
    }
}
