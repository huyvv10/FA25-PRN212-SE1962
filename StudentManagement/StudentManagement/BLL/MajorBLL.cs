using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentManagement.DAL;
using StudentManagement.Models;

namespace StudentManagement.BLL
{
    public class MajorBLL
    {
        private MajorDAL _majorDAL;
        public List<Major> GetAllMajor()
        {
            _majorDAL = new MajorDAL();
            return _majorDAL.GetAllMajor();
        } 
    }
}
