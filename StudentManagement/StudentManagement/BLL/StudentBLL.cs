using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentManagement.DAL;
using StudentManagement.Models;

namespace StudentManagement.BLL
{
    public class StudentBLL
    {
        private StudentDAL _studentDAL = new();
        public List<Student> GetAllStudents()
        {
            return _studentDAL.GetAllStudents();
        }

        public void addNewStudent(Student x)
        {
            _studentDAL.addNewStudent(x);
        }

        public void removeStudent(Student x) { 
            _studentDAL.removeStudent(x);
        }

        public void updateStudent(Student x) { 
            _studentDAL.updateStudent(x);
        }

    }
}
