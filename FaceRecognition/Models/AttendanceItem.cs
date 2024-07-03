using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace FaceRecognition.Models;

public partial class AttendanceItem
{
    public int Id { get; set; }

    [ForeignKey(nameof(Student))]
    public int StudentForeignID { get; set; }
    public Student Student { get; set; }

    public string? StudentId { get; set; }

    [ForeignKey(nameof(Attendance))]
    public int AttendanceId { get; set; }
    public Attendance Attendance { get; set; }

    public string? Status { get; set; }

    public string? Note { get; set; }
}
