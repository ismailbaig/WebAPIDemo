using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MS.MVCDemo.Interface;
using MS.MVCDemo.Models;
using System.Threading.Tasks;

namespace MS.MVCDemo.Implementation
{
    public class Repository : IRepository
    {
        public async Task<IList<StudentViewModel>> GetAllStudents()
        {
            IList<StudentViewModel> studentVM = null;

            studentVM = new List<StudentViewModel>();

            studentVM.Add(new StudentViewModel { Name = "Ismail", Address = "BTM" });
            studentVM.Add(new StudentViewModel { Name = "Baig2", Address = "BTM" });

            return studentVM;
        }
    }
}