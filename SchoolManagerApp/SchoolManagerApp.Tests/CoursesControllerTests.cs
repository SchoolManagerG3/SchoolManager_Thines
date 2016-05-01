using Microsoft.AspNet.Mvc;
using Moq;
using SchoolManagerApp.Controllers;
using SchoolManagerApp.Models;
using SchoolManagerApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace SchoolManagerApp.Tests
{
    public class CoursesControllerTests
    {


        [Fact]
        public void IndexReturnsAViewResultWithAListOfCourses()
        {
            //Arrange
            var mockRepo = new Mock<ISchoolManagerRepository>();
            mockRepo.Setup(r => r.GetAllCourses()).Returns(GetTestCourses());
            var controller = new CoursesController(mockRepo.Object);
            //Act
            var result = Assert.IsType<ViewResult>(controller.Index());
            var model = Assert.IsAssignableFrom<IEnumerable<CreateCourseViewModel>>
                (result.ViewData.Model);

            //Assert
            Assert.Equal(2, model.Count());

        }



        private List<Course> GetTestCourses()
        {
            var course = new List<Course>();
            course.Add(new Course()
            {
                Name ="Computing",
                

            });
            course.Add(new Course()
            {
                Name = "System Development"
            });
            return course;
        }
    }
}
