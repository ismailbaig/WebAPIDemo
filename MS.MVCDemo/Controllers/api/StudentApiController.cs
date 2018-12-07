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
    }
}