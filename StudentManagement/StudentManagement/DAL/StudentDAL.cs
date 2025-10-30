using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StudentManagement.Models;

namespace StudentManagement.DAL
{
    public class StudentDAL
    {
        private StudentManagementDbContext _context;
        public List<Student> GetAllStudents()
        {
            _context = new StudentManagementDbContext();
            return _context.Students
                    .Include(m => m.Major)
                    .Include(d => d.Dept)
                    .ToList();
        }

        public void addNewStudent(Student x)
        {
            _context = new();
            _context.Students.Add(x);
            _context.SaveChanges();
        }

        public void removeStudent(Student x)
        {
            _context = new();
            _context.Students.Remove(x);
            _context.SaveChanges();
        }

        public void updateStudent(Student x) { 
            _context= new();
            _context.Students.Update(x);
            _context.SaveChanges();
        }
    }
}
