using Microsoft.EntityFrameworkCore;

namespace ReginaNews.Models
{
    public class NewsContext :DbContext
    {
        public NewsContext (DbContextOptions<NewsContext> options)
            : base(options)
        {
        }

        public DbSet<Category> Category { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<ContactUs> ContactUs { get; set; }
        public DbSet<TeamMember> TeamMember  { get; set; }
        public DbSet<LoginModel> LoginModel { get; set; }
        public DbSet<Register> Register { get; set; }


    }

}
