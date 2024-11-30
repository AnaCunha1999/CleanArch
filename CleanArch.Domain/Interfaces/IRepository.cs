namespace CleanArch.Domain.Interfaces
{
    public interface IRepository<T> where T : class
    {
        Task Insert(T obj);
        void Update(T obj);
        void Delete(T id);
        Task<T> SelectById(int id);
        Task<IReadOnlyList<T>> GetAll();
    }
}
