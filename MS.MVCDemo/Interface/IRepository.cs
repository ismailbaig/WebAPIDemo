using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MS.MVCDemo.Models;
using System.Threading.Tasks;

namespace MS.MVCDemo.Interface
{
    public interface IRepository
    {
        //Task<IList<StudentViewModel>> GetAllStudents();
        IList<StudentViewModel> GetAllStudents();
    }
}