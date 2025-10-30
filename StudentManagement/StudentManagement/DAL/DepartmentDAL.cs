using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentManagement.Models;

namespace StudentManagement.DAL
{
    public class DepartmentDAL
    {
        private StudentManagementDbContext _context;

        public List<Department> GetAllDepartment()
        {
            _context = new StudentManagementDbContext();
            return _context.Departments.ToList();
        }
    }
}
