using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FaceRecognition.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(50)]
        [Column(TypeName = "nvarchar(50)")]
        public required string StudentName { get; set; }

        [Required, MaxLength(50)]
        [Column(TypeName = "nvarchar(50)")]
        public required string StudentId { get; set;}

    }
}
