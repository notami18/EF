using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EF.Models;
using Microsoft.EntityFrameworkCore;

namespace EF
{
  public class TaksContext : DbContext
  {
    public DbSet<Category> Categories { get; set; }
    public DbSet<EF.Models.Task> Tasks { get; set; }
    public TaksContext(DbContextOptions<TaksContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<Category>(category =>
      {
        category.ToTable("Categoria");
        category.HasKey(c => c.CategoryId);

        category.Property(c => c.Name)
          .IsRequired()
          .HasMaxLength(150);

        category.Property(c => c.Description);
      });

      modelBuilder.Entity<EF.Models.Task>(task =>
      {
        task.ToTable("Tarea");
        task.HasKey(t => t.TaskId);
        task.HasOne(t => t.Category)
          .WithMany(c => c.Tasks)
          .HasForeignKey(t => t.CategoryId);
        task.Property(t => t.Title)
          .IsRequired()
          .HasMaxLength(200);
        task.Property(t => t.Description);
        task.Property(t => t.PriorityTask);
        task.Property(t => t.Date);

        task.Ignore(t => t.Resumen);
      });
    }
  }
}