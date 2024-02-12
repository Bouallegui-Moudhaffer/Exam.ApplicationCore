namespace Exam.ApplicationCore.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        Task<int> SaveAsync();
        IGenericRepository<T> Repository<T>() where T : class;
    }
}
