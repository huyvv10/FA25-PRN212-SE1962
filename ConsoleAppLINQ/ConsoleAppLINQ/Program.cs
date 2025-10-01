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

    public static class DataSource
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
                var q1 = DataSource.Students
                        .Where(s => s.Age > 22);

                foreach (var s in q1) Console.WriteLine(s.Name + " - " + s.Age);
                Console.WriteLine();

                //var q2 = DataSource.Students.Select(s => s.Name.StartsWith("H"));
                var q2 = DataSource.Students.Where(s => s.Name.StartsWith("H"));
                foreach (var s in q2) Console.WriteLine(s.Name);

                //Get name age student with age >22
                var q3 = DataSource.Students
                        .Where(s => s.Age > 22)
                        .Select(s => s.Name.ToUpper() + " " + s.Age);
                foreach (var s in q3) Console.WriteLine(s);

                //Sort by Age Asc
                Console.WriteLine("Sort by Age asc");
                var q4 = DataSource.Students
                        .OrderBy(s => s.Age);

                foreach (var s in q4) Console.WriteLine(s.Id + " " + s.Name + " " + s.Age);

                Console.WriteLine();
                //Sort by Age Desc
                Console.WriteLine("Sort by Age Desc");
                var q5 = DataSource.Students
                        .OrderByDescending(s => s.Age);
                foreach (var s in q5) Console.WriteLine(s.Id + " " + s.Name + " " + s.Age);

                // 6. Grouping - Students grouped by Department CS
                Console.WriteLine("Group by Dept");
                var q6 = DataSource.Students.GroupBy(s => s.DepartmentId);
                foreach (var s in q6)
                {
                    Console.WriteLine($"Dept : {s.Key}");
                    foreach (var s2 in s) Console.WriteLine($"{s2.Id,5} - {s2.Name,10}");    
                }

                // 7. Joining - Students with Department name
                Console.WriteLine("---Join ---");
                var q7 = DataSource.Students
                        .Join(DataSource.Departments, s => s.DepartmentId, d => d.Id,
                        (s, d) => new { s.Id, s.Name, d.DeptName });

                foreach (var s in q7) Console.WriteLine($"{s.Id,-5} {s.Name,-8} {s.DeptName,40}");

                // 8. Multi-join - Student with Courses
                var q8 = DataSource.Students
                        .Join(DataSource.Enrollments,
                        s => s.Id, e => e.StudentId, (s, e) => new { s.Id, s.Name, e.CourseId })
                        .Join(DataSource.Courses,
                        se => se.CourseId, c => c.Id, (se, c) => new { se.Id, se.Name, c.CourseName });

                foreach (var s in q8) Console.WriteLine($"{s.Id,-5} {s.Name,-8} {s.CourseName,30}");

                // 9. Quantifier - Any student named "Xa"?
                bool q9 = DataSource.Students.Any(s => s.Name == "hoa");
                if (q9) Console.WriteLine($"There is existing Xa in the list.");
                else Console.WriteLine("No");
                Console.WriteLine("-----Quantifier - All-----");
                // 10. Quantifier - All students older than 18?
                bool q10 = DataSource.Students.All(s => s.Age >= 18);
                if (q10) Console.WriteLine($"Yes.");
                else Console.WriteLine("No");

                // 11. Element - First student in CS
                //Select top (1) from tb
                Console.WriteLine("--- First ---");
                var q11 = DataSource.Students.First(s => s.DepartmentId == 1);
                Console.WriteLine(q11.Id + " - " + q11.Name);

                //Get the first oldest in CS
                Console.WriteLine("Sort by Age desc");
                var q11_1 = DataSource.Students
                        .OrderByDescending(s => s.Age)
                        .First(s2=>s2.DepartmentId==1);
                Console.WriteLine(q11_1.Id + " - " + q11_1.Name);

                // 12. Element - FirstOrDefault (safe)
                Console.WriteLine("---FirstOrDefault---");
                var q12 = DataSource.Students
                    .FirstOrDefault(s=>s.Age >= 10);
                Console.WriteLine($"{q12? .Name ?? "No student qualifier"}");

                // 13. Aggregation - Average age of Business students
                var q13 = DataSource.Students
                            .Where(s => s.DepartmentId == 2)
                            .Average(s => s.Age);
                Console.WriteLine($"Average age of BE: {q13}");
                // 14. Aggregation - Count of CS students
                //14.1 Count number of student
                int q14_1 = DataSource.Students.Count();
                Console.WriteLine("--- Count ------");
                Console.WriteLine($"Number of student: {q14_1}");

                int q14_2 = DataSource.Students.Count(s=>s.DepartmentId==1);
                Console.WriteLine($"Number of student in CS: {q14_2}");
                // 15. Aggregation - Max age
                var q15 = DataSource.Students
                            .Where(s => s.DepartmentId == 2)
                            .Max(s => s.Age);
                Console.WriteLine($"Oldest age of BE: {q15}");

                // 16. Aggregation - Min credits


                // 17. Set - Distinct Departments from students


                // 18. Partitioning - First 3 students



                // 19. Partitioning - Skip first 5 students


            }
        }
    }
}