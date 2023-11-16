using ZeldaGuide.Data.Entities;

namespace ZeldaGuide.Data;
public class ApplicationDbContext : IdentityDbContext<UserEntity, IdentityRole<int>, int>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options) { }

    public DbSet<ToDoEntity> ToDos {get; set;} = null!;
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<UserEntity>().ToTable("Users");
    }

}

