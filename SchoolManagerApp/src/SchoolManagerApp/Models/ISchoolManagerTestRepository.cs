using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagerApp.Models
{
    public interface ISchoolManagerTestRepository
    {
        List<Student> GetTestStudents();
    }
}
