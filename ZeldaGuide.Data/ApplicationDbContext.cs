using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ZeldaGuide.Data.Entities;

namespace ZeldaGuide.Data;
public class ApplicationDbContext : IdentityDbContext<UserEntity, IdentityRole<int>, int>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options) { }

    public DbSet<ToDoEntity> ToDos {get; set;} = null!;
    public DbSet<MainQuestEntity> MainQuests {get; set;} = null!;
    public DbSet<SideAdventureEntity> SideAdventures {get; set;} = null!;
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<UserEntity>().ToTable("Users");
    }

}