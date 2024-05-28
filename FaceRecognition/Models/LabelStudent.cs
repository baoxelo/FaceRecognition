using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FaceRecognition.Models;
[Table("LabelStudent")]
public partial class LabelStudent
{
    public int Id { get; set; }

    [DisplayName("Label in Emgu CV")]
    public int LabelName { get; set; }

    [DisplayName("Student's ID")]
    [Column(TypeName = "nvarchar(50)")]
    public string StudentId { get; set; }
}
