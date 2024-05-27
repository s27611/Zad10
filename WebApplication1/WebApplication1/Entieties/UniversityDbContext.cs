using Microsoft.EntityFrameworkCore;
using WebApplication1.Entieties.Configs;

namespace WebApplication1.Entieties;

public class UniversityDbContext : DbContext
{
    public virtual DbSet<Student> Students { get; set; }
    public virtual DbSet<Group> Groups { get; set; }


    public UniversityDbContext()
    {
        
    }

    public UniversityDbContext(DbContextOptions<UniversityDbContext> options) : base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(GroupEfConfig).Assembly);
    }
    
    
}