using CleanArch.Domain.Interfaces;
using CleanArch.Infra.Context;
using Microsoft.EntityFrameworkCore;

namespace CleanArch.Infra.Repositories
{
    public class BaseRepository<T> : IRepository<T> where T : class
    {
        private readonly ApplicationDbContext _applicationDbContext;
        public BaseRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public async Task<IReadOnlyList<T>> GetAll()
        {
            return await _applicationDbContext.Set<T>().ToListAsync();
        }

        public async Task Insert(T obj)
        {
            await _applicationDbContext.Set<T>().AddAsync(obj);
        }

        public void Delete(T id)
        {
           _applicationDbContext.Remove<T>(id);
        }

        public async Task<T> SelectById(int id)
        {
            var teste = await _applicationDbContext.Set<T>().FindAsync(id);
            return teste;
        }

        public void Update(T obj)
        {
            _applicationDbContext.Attach<T>(obj);
            _applicationDbContext.Entry(obj).State = EntityState.Modified;            
        }      
    }
}
