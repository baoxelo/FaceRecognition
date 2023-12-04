using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaceRecognition.Models
{
    public class Attendance
    {
        [Key]
        public int Id { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime AttendanceDate { get; set; }

        [Column(TypeName = "nvarchar(500)")]
        [DataType(DataType.MultilineText)]
        public string? Note { get; set; }

        public double Attend {  get; set; }

        [NotMapped]
        public IList<Student> Students { get; set; }
        
    }
    
}
