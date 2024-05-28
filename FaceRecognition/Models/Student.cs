using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace FaceRecognition.Models;

public partial class Student
{
    public int Id { get; set; }

    [DisplayName("Student's name")]
    [Column(TypeName = "nvarchar(50)")]
    public string? Name { get; set; }

    [DisplayName("Student's ID")]
    [Column(TypeName = "nvarchar(50)")]

    public string? StudentId { get; set; }

    [DisplayName("Student's email")]
    [Column(TypeName = "nvarchar(50)")]
    public string? Email { get; set; }

    [DisplayName("Phone number")]
    [Column(TypeName = "nvarchar(50)")]
    public string? PhoneNumber { get; set; }

    [DisplayName("Date of birth")]
    public DateOnly? Birthdate { get; set; }
}
