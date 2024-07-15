using Microsoft.EntityFrameworkCore;
using TaskSystem.Domain.Entity;

namespace TaskSystem.Infrastructure
{
    public class TaskSystemDbContext : DbContext
    {
        public TaskSystemDbContext(DbContextOptions<TaskSystemDbContext> options) : base(options)
        {

        }

        public DbSet<TaskEntity> Tasks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TaskEntity>()
                .Property(t => t.Tag)
                .HasConversion<string>();
        }
    }
}
