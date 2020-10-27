using Microsoft.AspNet.OData;
using Microsoft.AspNet.OData.Query;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using News.Web.Api.Attributes;
using News.Web.Api.DataAccess;
using News.Web.Api.Models;
using System.Collections.Generic;
using System.Linq;

namespace News.Web.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NewsController : ControllerBase
    {
        private readonly ILogger<NewsController> _logger;
        private readonly DataContext _dataContext;

        public NewsController(ILogger<NewsController> logger, DataContext dataContext)
        {
            _logger = logger;
            _dataContext = dataContext;
        }

        [HttpGet]
        [SecuredEnableQueryAttribute(AllowedQueryOptions = AllowedQueryOptions.Filter, AllowedFunctions = AllowedFunctions.StartsWith)]
        public IQueryable<Source> Get()
        {
            return _dataContext.Sources;
        }
    }
}
