using ManageStudentScore.Models;
using ManageStudentScore.Repositories.Inferfaces;

namespace ManageStudentScore.Repositories.Implements
{
    public class StudentRepository : Repository<Student>, IStudentRepository
    {
        public StudentRepository(MyDBContext context) : base(context) { }       
    }
}
