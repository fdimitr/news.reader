using News.Web.Api.DataAccess;
using News.Web.Api.Models;
using News.Web.Api.Repository.Interfaces;

namespace News.Web.Api.Repository
{
    public class GroupRepository : BaseRepository<Group>, IGroupRepository
    {
        public GroupRepository(DataContext dataContext): base(dataContext)
        {

        }
    }
}
