using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FaceRecognition.Models;
[Table("Attendance")]
public partial class Attendance
{
    public int Id { get; set; }

    [DisplayName("Attendance date")]
    public DateTime AttendanceDate { get; set; }

    [Column(TypeName = "nvarchar(500)")]
    public string? Note { get; set; }
}
