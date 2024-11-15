using System.Collections.Generic;
using System.Reflection.Emit;

namespace DataAnnotations
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }  // Users tablosunu tanımladık

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
