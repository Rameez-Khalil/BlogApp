using Bloggie.Web.Models.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace Bloggie.Web.Data
{
    public class BloggieDBContext : DbContext
    {
        public BloggieDBContext(DbContextOptions options) : base(options)
        {
            /*
             * We will pass these DbContextOptions from program.cs file
             * These params will then be passed onto the base class.
             */
        }

        public DbSet<BlogPost> BlogPosts { get; set; }
        public DbSet<Tag> Tags { get; set; }
    }
}
