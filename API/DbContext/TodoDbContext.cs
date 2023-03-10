using API.Model.Entity;
using Microsoft.EntityFrameworkCore;

namespace API.DbContext
{
    public class TodoDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public TodoDbContext(DbContextOptions<TodoDbContext> options) : base(options) { 
           
        }

        public DbSet<Todo> Todo => Set<Todo>();
        
    }
}
