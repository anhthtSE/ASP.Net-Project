using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ManageStudentScore.Models
{
    [Table("Student")]
    public class Student
    {
        [Key]
        public int ID {  get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; } = string.Empty;
        [Required]
        public double Score { get; set; } = double.NaN;

    }
}
