using Microsoft.AspNet.OData;
using System.Linq;
using System.Threading.Tasks;

namespace News.Web.Api.Repository.Interfaces
{
    public interface IBaseRepository<T> where T : class
    {
        Task<T> Create(T entity);
        Task<bool> Delete(int id);
        void Dispose();
        IQueryable<T> GetAll();
        Task<T> GetById(int id);
        Task<bool> Patch(int id, Delta<T> patch);
    }
}