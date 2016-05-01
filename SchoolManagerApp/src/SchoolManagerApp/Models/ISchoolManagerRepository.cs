using SchoolManagerApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagerApp.Models
{
    public interface ISchoolManagerRepository
    {
        IEnumerable<Student> GetAllStudents();
        IEnumerable<Course> GetAllCourses();
        void AddCourses(CreateCourseViewModel model);
    }
}
