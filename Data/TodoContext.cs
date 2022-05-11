using Microsoft.EntityFrameworkCore;
using demoapi.Models;

namespace demoapi.Data
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> opt): base(opt)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TodoItem>().HasKey(p => new {p.name,p.val});
            modelBuilder.Entity<User>().HasKey(p => new {p.id});
            
        }

        public DbSet<TodoItem> item_labels { get; set; }
        public DbSet<User> users { get; set; }
 
    }
}