
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace Blog.Models
{
    public class BlogDbContext : IdentityDbContext<ApplicationUser>
    {
        public BlogDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public virtual DbSet<Article> Atricles { get; set; }

        public static BlogDbContext Create()
        {
            return new BlogDbContext();
        }
    }
}