﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ManageStudentScore.Models
{
    [Table("Teacher")]
    public class Teacher
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; } = string.Empty;
        
        
    }
}
