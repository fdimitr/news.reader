using News.Web.Api.BusinessLogic.Interfaces;
using News.Web.Api.Models;
using News.Web.Api.Repository.Interfaces;
using System.Linq;

namespace News.Web.Api.BusinessLogic
{
    public class GroupLogic : IGroupLogic
    {
        IBaseRepository<Group> _repository;
        public GroupLogic(IGroupRepository repository)
        {
            _repository = repository;
        }

        public IQueryable<Group> GetGroups()
        {
            return _repository.GetAll();
        }
    }
}
