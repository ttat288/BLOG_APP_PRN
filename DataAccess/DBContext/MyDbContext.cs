using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;
using BlogObject;
using System;

namespace DataAccess.DBContext
{
    public class MyDbContext : DbContext
    {
        public DbSet<User> UserTb { get; set; }
        public DbSet<Post> PostTb { get; set; }
        public DbSet<Like> LikeTb { get; set; }
        public DbSet<Comment> CommentTb { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfigurationRoot configuration = GetConfiguration();
            string connectionString = configuration.GetConnectionString("ConnectionString");

            optionsBuilder.UseSqlServer(connectionString);
        }

        private IConfigurationRoot GetConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            return builder.Build();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Like>().HasKey(l => new { l.userID, l.postID });
        }
    }
}
