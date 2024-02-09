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
  }
}