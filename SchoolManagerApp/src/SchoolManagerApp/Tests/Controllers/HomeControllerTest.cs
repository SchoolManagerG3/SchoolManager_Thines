using Microsoft.AspNet.Mvc;
using SchoolManagerApp.Controllers;
using SchoolManagerApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace SchoolManagerApp.Tests.Controllers
{
   
    public class HomeControllerTest
    {
        private SchoolManagerRepository _repository;

        public HomeControllerTest(SchoolManagerRepository repository)
        {
            _repository = repository;
        }
        [Fact]
        public void Index()
        {
            //Arrange
            HomeController controller = new HomeController(_repository);

            //Act
            ViewResult result = controller.Index() as ViewResult;

            //Assert
            Assert.NotNull(result);
        }

    }
}
