using Blog.Models;
using Microsoft.EntityFrameworkCore;

namespace Blog.Infra
{
    public class BlogContext : DbContext
    {

        public BlogContext(DbContextOptions<BlogContext> options) 
            :base(options)
        {
                
        } 

        public DbSet<PostModel> Posts { get; set; }        
    }
}
