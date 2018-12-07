using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MS.MVCDemo.Models;

namespace MS.MVCDemo.Controllers.api
{
    public class StudentApiController : ApiController
    {
        public IHttpActionResult GetStudents()
        {
            IList<StudentViewModel> studentVM = null;

            studentVM = new List<StudentViewModel>();

            studentVM.Add(new StudentViewModel { Name = "Ismail", Address="BTM" });
            studentVM.Add(new StudentViewModel { Name = "Baig2", Address="BTM" });

            if (studentVM.Count == 0)
            {
                return NotFound();
            }

            return Ok(studentVM);
        }

        //Get action methods of the previous section
        public IHttpActionResult PostNewStudent(StudentViewModel student)
        {
            if (!ModelState.IsValid)
                return BadRequest("Invalid data.");

            //using (var ctx = new SchoolDBEntities())
            //{
            //    ctx.Students.Add(new Student()
            //    {
            //        StudentID = student.Id,
            //        FirstName = student.FirstName,
            //        LastName = student.LastName
            //    });

            //    ctx.SaveChanges();
            //}

            return Ok();
        }
    }
}