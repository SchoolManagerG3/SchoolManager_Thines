using Microsoft.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagerApp.Models
{
    public class SchoolManagerRepository : ISchoolManagerRepository
    {
        private SchoolManagerContext _context;

        public SchoolManagerRepository(SchoolManagerContext context)
        {
            _context = context;
        }

        public IEnumerable<Student> GetAllStudents()
        {
            var students = _context.Students.ToList();

            return students;
        }

        public IEnumerable<Course> GetAllCourses()
        {
            var courses = _context.Courses.ToList();

            return courses;
        }
    }
}
