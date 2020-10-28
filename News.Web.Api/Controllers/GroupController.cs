using Microsoft.AspNet.OData.Query;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using News.Web.Api.Attributes;
using News.Web.Api.BusinessLogic.Interfaces;
using News.Web.Api.Models;
using System.Linq;

namespace News.Web.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GroupController : ControllerBase
    {
        private readonly ILogger<GroupController> _logger;
        private readonly IGroupLogic _groupLogic;

        public GroupController(ILogger<GroupController> logger, IGroupLogic groupLogic)
        {
            _logger = logger;
            _groupLogic = groupLogic;
        }

        [HttpGet]
        [SecuredEnableQueryAttribute(AllowedQueryOptions = AllowedQueryOptions.Filter, AllowedFunctions = AllowedFunctions.StartsWith)]
        public IQueryable<Group> Get()
        {
            return _groupLogic.GetGroups();
        }
    }
}
