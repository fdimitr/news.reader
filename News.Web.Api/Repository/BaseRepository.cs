using Microsoft.AspNet.OData;
using Microsoft.EntityFrameworkCore;
using News.Web.Api.DataAccess;
using News.Web.Api.Repository.Interfaces;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace News.Web.Api.Repository
{
    public abstract class BaseRepository<T> : IDisposable, IBaseRepository<T> where T : class
    {
        protected DataContext dataContext { get; set; }

        public BaseRepository(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public IQueryable<T> GetAll()
        {
            return dataContext.Set<T>();
        }

        public async Task<T> GetById(int id)
        {
            return await dataContext.Set<T>().FindAsync(id);
        }

        public async Task<T> Create(T entity)
        {
            var result = dataContext.Set<T>().Add(entity);
            await dataContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<bool> Patch(int id, Delta<T> patch)
        {
            T entity = await GetById(id);
            if (entity != null)
            {
                patch.Patch(entity);

                try
                {
                    int result = await dataContext.SaveChangesAsync();
                    return result > 0 ? true : false;
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (EntityExists(id))
                    {
                        throw;
                    }
                }
            }
            return false;
        }

        public async Task<bool> Delete(int id)
        {
            T entity = await dataContext.Set<T>().FindAsync(id);
            if (entity == null)
            {
                return false;
            }

            dataContext.Set<T>().Remove(entity);
            var result = await dataContext.SaveChangesAsync();
            return result > 0 ? true : false;
        }

        protected bool EntityExists(int id)
        {
            return dataContext.Set<T>().Find(id) != null;
        }

        public void Dispose()
        {
            dataContext.Dispose();
        }
    }
}
