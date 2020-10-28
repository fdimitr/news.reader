using News.Web.Api.BusinessLogic.Interfaces;
using News.Web.Api.Models;
using System;
using System.Linq;

namespace News.Web.Api.BusinessLogic
{
    public class SourceLogic : ISourceLogic
    {
        public IQueryable<Source> GetSourcesByGroup(int groupId)
        {
            throw new NotImplementedException();
        }
    }
}
