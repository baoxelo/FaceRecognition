using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FaceRecognition.Models
{
    [Table("Student")]
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        [StringLength(50)]
        public required string StudentName { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        [StringLength(50)]
        public required string StudentId { get; set;}

    }
}
