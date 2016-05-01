using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using SchoolManagerApp.Models;
using SchoolManagerApp.ViewModels;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace SchoolManagerApp.Controllers
{
    public class CoursesController : Controller
    {
        private ISchoolManagerRepository _repository;

        public CoursesController(ISchoolManagerRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Index()
        {
            var model = _repository.GetAllCourses()
               .Select(c => new CreateCourseViewModel()
               {
                   Name = c.Name,
                   StartDate = c.StartDate
               });
            return View(model);

        }
        public IActionResult Create()
        {
            return View(new CreateCourseViewModel());
        }

        [HttpPost]
        public IActionResult Create(CreateCourseViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            _repository.AddCourses(model);
            return RedirectToAction("Index");
        }
    }
}
