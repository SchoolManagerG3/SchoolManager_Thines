using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagerApp.Models
{
    public class Class
    {
        
        public int Id { get; set; }

        public string Name { get; set; }
      
        public int StudentId { get; set; }
      
        public int TeacherId { get; set; }

        public ICollection<Student> Students { get; set; }

        public ICollection<Teacher> Teachers { get; set; }


    }
}
