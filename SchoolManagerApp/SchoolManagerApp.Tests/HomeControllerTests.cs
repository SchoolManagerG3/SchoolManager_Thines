using Microsoft.AspNet.Mvc;
using Moq;
using SchoolManagerApp.Controllers;
using SchoolManagerApp.Models;
using SchoolManagerApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Telerik.JustMock.Helpers;
using Xunit;

namespace SchoolManagerApp.Tests
{
    public class HomeControllerTests
    {
        //private ISchoolManagerTestRepository _testRepository;

        //public HomeControllerTests(ISchoolManagerTestRepository testRepository)
        //{
        //    _testRepository = testRepository;
        //}

        [Fact]
        public void IndexReturnsAViewResultWithAListOfStudents()
        {
            //Arrange
            var mockRepo = new Mock<ISchoolManagerRepository>();
            mockRepo.Setup(r => r.GetAllStudents()).Returns(GetTestStudents());
            var controller = new HomeController(mockRepo.Object);
            //Act
            var result = Assert.IsType<ViewResult>(controller.Index());
            var model = Assert.IsAssignableFrom<IEnumerable<CreateStudentViewModel>>
                (result.ViewData.Model);

            //Assert
            Assert.Equal(2, model.Count());

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
