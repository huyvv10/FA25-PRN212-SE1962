using System;
using System.Collections.Generic;

namespace StudentManagement.Models;

public partial class Department
{
    public string DeptId { get; set; } = null!;

    public string DeptName { get; set; } = null!;

    public virtual ICollection<Student> Students { get; set; } = new List<Student>();
}
