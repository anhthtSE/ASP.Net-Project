using ManageStudentScore.Models;
using Microsoft.EntityFrameworkCore;

namespace ManageStudentScore.Datas
{
    public class DbInitializer
    {
        public void Init(MyDBContext context)
        {
            ArgumentNullException.ThrowIfNull(context, nameof(context));
            context.Database.EnsureCreated();

            if (context.Students.Any() || context.Teachers.Any()) return;

            var students = new List<Student>();
            for (int i = 0; i <= 100; i++)
            {
                students.Add(new Student
                {
                    Name = $"Student{i}",
                    Score = new Random().Next(0, 100),
                });
            }
            context.Students.AddRange(students);

            var teachers = new List<Teacher>();
            for (int i = 0; i <= 100; i++)
            {
                teachers.Add(new Teacher
                {
                    Name = $"Teacher{i}",
                });
            }
            context.Teachers.AddRange(teachers);

            context.SaveChanges();
            


        }
    }
}