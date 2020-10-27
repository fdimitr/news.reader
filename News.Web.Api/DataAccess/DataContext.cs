using Microsoft.EntityFrameworkCore;
using News.Web.Api.Models;
using System;

namespace News.Web.Api.DataAccess
{
    public class DataContext : DbContext
    {
        public DbSet<Source> Sources { get; set; }
        public DbSet<Models.News> News { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Subscription> Subscriptions { get; set; }
        public DbSet<User> Users { get; set; }


        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Default values
            modelBuilder.Entity<Models.News>().Property(e => e.TimeStamp).HasColumnType("timestamp without time zone").HasDefaultValueSql("NOW()").ValueGeneratedOnAdd();


            modelBuilder.Entity<Source>().Property<DateTime?>(e => e.LastLoadedTime).HasConversion(
                 v => v.HasValue ? v.Value.ToUniversalTime() : v,
                 v => v.HasValue ? DateTime.SpecifyKind(v.Value, DateTimeKind.Utc) : v);

            modelBuilder.Entity<Subscription>().Property<DateTime?>(e => e.LastLoadedTime).HasConversion(
                 v => v.HasValue ? v.Value.ToUniversalTime() : v,
                 v => v.HasValue ? DateTime.SpecifyKind(v.Value, DateTimeKind.Utc) : v);
        }
    }
}
