using News.Web.Api.Models;
using System.Linq;

namespace News.Web.Api.BusinessLogic.Interfaces
{
    public interface ISourceLogic
    {
        IQueryable<Source> GetSourcesByGroup(int groupId);
    }
}
