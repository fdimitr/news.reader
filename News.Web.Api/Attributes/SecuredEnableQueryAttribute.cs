using Microsoft.AspNet.OData;
using Microsoft.AspNet.OData.Query;

namespace News.Web.Api.Attributes
{
    public class SecuredEnableQueryAttribute: EnableQueryAttribute
    {
        public SecuredEnableQueryAttribute()
        {
            this.AllowedFunctions = AllowedFunctions.None;
            this.AllowedQueryOptions = AllowedQueryOptions.None;
            this.AllowedArithmeticOperators = AllowedArithmeticOperators.None;
            this.PageSize = 20;
            this.MaxNodeCount = 10;
            this.MaxTop = 20;
            this.MaxSkip = 20;
            this.MaxOrderByNodeCount = 5;
            this.MaxAnyAllExpressionDepth = 1;
            this.MaxExpansionDepth = 0;
        }
    }
}
