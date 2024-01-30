using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ManageStudentScore.Models
{
    [Table("Enrollment")]
    public class Enrollment
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [ForeignKey(nameof(Student))]
        public int StudentID { get; set; } = 0;
        [Required]
        [ForeignKey(nameof(Course))]
        public int CourseID { get; set; } = 0;
        [Required]
        [ForeignKey(nameof(Teacher))]
        public int TeacherID { get; set; } = 0;

        public Student Student { get; set; } = new Student();
        public Teacher Teacher { get; set; } = new Teacher();
        public Course Course { get; set; } = new Course();
    }
}
