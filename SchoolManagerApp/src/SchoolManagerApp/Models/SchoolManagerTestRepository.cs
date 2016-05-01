using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagerApp.Models
{
    public class SchoolManagerTestRepository : ISchoolManagerTestRepository
    {
        List<Student> ISchoolManagerTestRepository.GetTestStudents()
        {
            throw new NotImplementedException();
        }

        private List<Student> GetTestStudents()
        {
            var student = new List<Student>();
            student.Add(new Student()
            {
                FirstName = "Thines",
                LastName = "Kumar",
                PersonalNumber = 198205047766

            });
            student.Add(new Student()
            {
                FirstName = "Cecilia",
                LastName = "Silvera",
                PersonalNumber = 198205045488
            });
            return student;
        }

    }
}
