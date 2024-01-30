namespace ManageStudentScore.Repositories.Inferfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IStudentRepository StudentRepository { get; }
        Task<int> Complete();
    }
}
