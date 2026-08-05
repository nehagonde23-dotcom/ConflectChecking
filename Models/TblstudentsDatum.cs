using System;
using System.Collections.Generic;

namespace StudentCRUDOpretions_API.Models;

public partial class TblstudentsDatum
{
    public int StudentId { get; set; }

    public string? StudentName { get; set; }

    public string? City { get; set; }

    public int? Marks { get; set; }

    public string? Grade { get; set; }
}
