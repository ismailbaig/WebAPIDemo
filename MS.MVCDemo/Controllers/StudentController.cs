﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Http;
using MS.MVCDemo.Models;

namespace MS.MVCDemo.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {

            IEnumerable<StudentViewModel> students = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:60909/api/");
                var responseTask = client.GetAsync("studentapi");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<StudentViewModel[]>();
                    readTask.Wait();

                    students = readTask.Result;
                }
                else
                {
                    students = Enumerable.Empty<StudentViewModel>();

                    ModelState.AddModelError(string.Empty, "An Error occured, contact admin!!");

                }
            }           
            
            return View(students);
        }

        public ActionResult create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult create(StudentViewModel student)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:60909/api/studentapi/postnewstudent");

                //HTTP POST
                var postTask = client.PostAsJsonAsync<StudentViewModel>("student", student);
                postTask.Wait();

                var result = postTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
            }

            ModelState.AddModelError(string.Empty, "Server Error. Please contact administrator.");

            return View(student);
        }
    }
}