using System;
using System.Collections.Generic;

namespace StudentManagement.Models;

public partial class Student
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Gender { get; set; } = null!;

    public DateTime Dob { get; set; }

    public string Skills { get; set; } = null!;

    public string Address { get; set; } = null!;

    public string MajorId { get; set; } = null!;

    public string DeptId { get; set; } = null!;

    public virtual Department Dept { get; set; } = null!;

    public virtual Major Major { get; set; } = null!;
}
