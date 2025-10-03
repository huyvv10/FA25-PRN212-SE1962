using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsDemo
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int YOB { get; set; }
        public string Gender { get; set; }

        public string Course { get; set; }
        public Student(int id, string name, int yob, string gender, string course) { 
            Id = id;
            Name = name;
            YOB = yob;
            Gender = gender;
            Course = course;
        }    

    }
}
