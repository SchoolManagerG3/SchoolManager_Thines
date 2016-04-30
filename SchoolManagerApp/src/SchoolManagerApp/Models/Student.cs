using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagerApp.Models
{
    public class Student
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public long PersonalNumber { get; set; }

        public int CourseId { get; set; }

        public int ClassId { get; set; }

    }
}
