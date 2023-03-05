using ETicketWebApp.Models;
using Microsoft.EntityFrameworkCore;

namespace ETicketWebApp.Data
{
  public class AppDbContext : DbContext
  {
    public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<LinkActor_Movie>().HasKey(am => new
      {
        am.ActorId,
        am.MovieId
      });

      modelBuilder.Entity<LinkActor_Movie>().HasOne(m => m.Movie).WithMany(am => am.LinkActor_Movies).HasForeignKey(m => m.MovieId);
      modelBuilder.Entity<LinkActor_Movie>().HasOne(m => m.Actor).WithMany(am => am.LinkActor_Movies).HasForeignKey(m => m.ActorId);

      base.OnModelCreating(modelBuilder);
    }

    public DbSet<Actor> Actors { get; set; }
    public DbSet<Movie> Movies { get; set; }
    public DbSet<LinkActor_Movie> LinkActor_Movie { get; set; }
    public DbSet<Producer> Producer { get; set; }
    public DbSet<Cinema> Cinemas { get; set; }
  }
}
