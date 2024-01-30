using ManageStudentScore.Models;
using ManageStudentScore.Repositories.Inferfaces;
using Microsoft.EntityFrameworkCore;

namespace ManageStudentScore.Repositories.Implements
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MyDBContext _context;
        private IStudentRepository _studentRepository;

        public UnitOfWork(MyDBContext context)
        {
            _context = context;
        }

        public IStudentRepository StudentRepository
        {
            get
            {
                if (this._studentRepository == null)
                {
                    this._studentRepository = new StudentRepository(_context);
                }
                return _studentRepository;
            }
        }

        public async Task<int> Complete()
        {
            return await _context.SaveChangesAsync();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
