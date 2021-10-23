using Microsoft.EntityFrameworkCore;
using PreAceleracion.Octubre.Entities;

namespace PreAceleracion.Octubre.Context
{
    public class DisneyContext : DbContext
    {
        private const string Schema = "disney";
        public DisneyContext(DbContextOptions options): base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.HasDefaultSchema(Schema);
            modelBuilder.Entity<Character>().HasData(
                new Character()
                {
                    Id = 1,
                    Image = null
                });
        }

        public DbSet<Character> Characters { get; set; }
    }
}
