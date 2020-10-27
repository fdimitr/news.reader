using Microsoft.EntityFrameworkCore;
using News.Web.Api.Models;


namespace News.Web.Api.DataAccess
{
    public class DataContext: DbContext
    {
        public DbSet<NewsSource> NewsSources { get; set; }


        public DataContext(DbContextOptions<DataContext> options): base(options)
        {
            Database.EnsureCreated();
        }
    }
}
