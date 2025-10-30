using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentManagement.Models;

namespace StudentManagement.DAL
{
    public class MajorDAL
    {
        private StudentManagementDbContext _context;

        public List<Major> GetAllMajor()
        {
            _context = new StudentManagementDbContext();
            return _context.Majors.ToList();
        }


    }
}
