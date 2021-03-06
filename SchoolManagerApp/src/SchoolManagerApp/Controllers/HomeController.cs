﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using SchoolManagerApp.Models;
using SchoolManagerApp.ViewModels;

namespace SchoolManagerApp.Controllers
{
    public class HomeController : Controller
    {
        private ISchoolManagerRepository _repository;

        public HomeController(ISchoolManagerRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Index()
        {
            var model = _repository.GetAllStudents()
               .Select(s => new CreateStudentViewModel()
                {
                    FirstName = s.FirstName,
                    LastName = s.LastName,
                    PersonalNumber = s.PersonalNumber
                });
            return View(model);

        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";
            var courses = _repository.GetAllCourses();
            return View(courses);
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
