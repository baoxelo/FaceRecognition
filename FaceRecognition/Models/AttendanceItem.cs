using System;
using System.Collections.Generic;

namespace FaceRecognition.Models;

public partial class AttendanceItem
{
    public int Id { get; set; }

    public int? StudentId { get; set; }

    public int? AttendanceId { get; set; }

    public string? Status { get; set; }

    public string? Note { get; set; }
}
