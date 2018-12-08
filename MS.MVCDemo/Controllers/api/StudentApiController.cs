using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MS.MVCDemo.Models;
using MS.MVCDemo.Interface;
using MS.MVCDemo.Implementation;
using System.Threading.Tasks;

namespace MS.MVCDemo.Controllers.api
{
    public class StudentApiController : ApiController
    {
        private IRepository _iRepo = null;


        public StudentApiController(IRepository iRepo)
        {
            _iRepo = iRepo;
        }

        //public async IHttpActionResult GetStudents()
        //public async Task<HttpResponseMessage> GetStudents()
        public HttpResponseMessage GetStudents()
        {
            //IList<StudentViewModel> studentVM = null;

            //studentVM = new List<StudentViewModel>();

            //studentVM = await _iRepo.GetAllStudents();

            //if (studentVM.Count == 0)
            //{
            //    return NotFound();
            //}

            //return Ok(studentVM);

            return Request.CreateResponse(HttpStatusCode.OK, _iRepo.GetAllStudents());
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