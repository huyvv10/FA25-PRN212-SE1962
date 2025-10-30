using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentManagement.DAL;
using StudentManagement.Models;

namespace StudentManagement.BLL
{
    public class DepartmentBLL
    {
        private DepartmentDAL _departmentDAL;
        public List<Department> GetAllDepartment()
        {
            _departmentDAL = new DepartmentDAL();
            return _departmentDAL.GetAllDepartment();
        }
    }
}
