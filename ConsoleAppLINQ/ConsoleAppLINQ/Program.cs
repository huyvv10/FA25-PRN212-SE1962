using System;
using System.Collections.Generic;

namespace LinqPractice
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int DepartmentId { get; set; }
    }

    public class Department
    {
        public int Id { get; set; }
        public string DeptName { get; set; }
    }

    public class Course
    {
        public int Id { get; set; }
        public string CourseName { get; set; }
        public int Credits { get; set; }
    }

    public class Enrollment
    {
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public string Grade { get; set; }

    }

    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DepartmentId { get; set; }
    }

    public static class DataSourse
    {
        public static List<Student> Students = new List<Student>()
        {
            new Student() { Id = 1, Name = "Cong", Age = 20, DepartmentId = 1 },
            new Student() { Id = 2, Name = "Hoa", Age = 22, DepartmentId = 2 },
            new Student() { Id = 3, Name = "Xa", Age = 21, DepartmentId = 1 },
            new Student() { Id = 4, Name = "Hoi", Age = 18, DepartmentId = 3 },
            new Student() { Id = 5, Name = "Chu", Age = 26, DepartmentId = 2 },
            new Student() { Id = 6, Name = "Nghia", Age = 32, DepartmentId = 1 },
            new Student() { Id = 7, Name = "Viet", Age = 24, DepartmentId = 1 },
            new Student() { Id = 8, Name = "Nam", Age = 22, DepartmentId = 2 }
        };

        public static List<Department> Departments = new List<Department>()
        {
            new Department() { Id = 1, DeptName = "Computer Science" },
            new Department() { Id = 2, DeptName = "Business Administration" },
            new Department() { Id = 3, DeptName = "Electrical Engineering" },

        };

        public static List<Course> Courses = new List<Course>()
        {
            new Course(){ Id=101, CourseName="Data Structures", Credits=4},
            new Course(){ Id=102, CourseName="Algorithms", Credits=4},
            new Course(){ Id=103, CourseName="Marketing 101", Credits=3},
            new Course(){ Id=104, CourseName="Corporate Finance", Credits=3},
            new Course(){ Id=105, CourseName="Circuit Analysis", Credits=4},
            new Course(){ Id=106, CourseName="Digital Systems", Credits=4},
        };

        public static List<Enrollment> Enrollments = new List<Enrollment>()
        {
            new Enrollment(){ StudentId=1, CourseId=101, Grade="A"},
            new Enrollment(){ StudentId=1, CourseId=102, Grade="B"},
            new Enrollment(){ StudentId=2, CourseId=103, Grade="A"},
            new Enrollment(){ StudentId=2, CourseId=104, Grade="C"},
            new Enrollment(){ StudentId=3, CourseId=101, Grade="B"},
            new Enrollment(){ StudentId=3, CourseId=105, Grade="A"},
            new Enrollment(){ StudentId=4, CourseId=105, Grade="B"},
            new Enrollment(){ StudentId=4, CourseId=106, Grade="A"},
            new Enrollment(){ StudentId=5, CourseId=103, Grade="B"},
            new Enrollment(){ StudentId=5, CourseId=104, Grade="A"},
            new Enrollment(){ StudentId=6, CourseId=106, Grade="C"},
            new Enrollment(){ StudentId=7, CourseId=101, Grade="B"},
            new Enrollment(){ StudentId=8, CourseId=104, Grade="B"},
        };

        public static List<Teacher> Teachers = new List<Teacher>()
        {
            new Teacher(){ Id=1, Name="Dr. Huy", DepartmentId=1},
            new Teacher(){ Id=2, Name="Prof. Chau", DepartmentId=2},
            new Teacher(){ Id=3, Name="Dr. Thang", DepartmentId=3},
        };

        public class Program
        {
            private static void Main(string[] args)
            {
                //List all student with age >=22
                var q1 = DataSourse.Students
                        .Where(s => s.Age > 22);

                foreach (var s in q1) Console.WriteLine(s.Name +" - "+ s.Age);
                Console.WriteLine();
                //var q2 = DataSourse.Students.Select(s => s.Name.StartsWith("H"));
                var q2 = DataSourse.Students.Where(s => s.Name.StartsWith("H"));
                foreach (var s in q2) Console.WriteLine(s.Name);

                //Get name age student with age >22
                var q3 = DataSourse.Students
                        .Where(s => s.Age > 22)
                        .Select(s => s.Name.ToUpper() + " "+ s.Age);
                foreach (var s in q3) Console.WriteLine(s);

                //Sort by Age Asc
                Console.WriteLine("Sort by Age asc");
                var q4 = DataSourse.Students
                        .OrderBy(s => s.Age);

                foreach (var s in q4) Console.WriteLine(s.Id +" "+s.Name +" "+ s.Age);

                Console.WriteLine();
                //Sort by Age Desc
                Console.WriteLine("Sort by Age Desc");
                var q5 = DataSourse.Students
                        .OrderByDescending(s => s.Age);
                foreach (var s in q5) Console.WriteLine(s.Id + " " + s.Name + " " + s.Age);
            }
        }
    }
}
