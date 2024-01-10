using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FaceRecognition.Models
{
    public class Subject
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        [StringLength(50)]
        public string Name { get; set; }

        [Column(TypeName = "nvarchar(500)")]
        [StringLength(500)]
        public string Description { get; set; }

        [ForeignKey(nameof(Instructor))]
        public int InstructorId { get; set; }

        public Instructor Instructor { get; set; }
    }
}
