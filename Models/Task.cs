using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EF.Models
{
  public class Task
  {
    public Guid TaskId { get; set; }
    public Guid CategoydD { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }
    public Priority PriorityTask { get; set; }
    public DateTime Date { get; set; }

    public virtual Category? Category { get; set; }
  }

  public enum Priority
  {
    Low,
    Medium,
    High
  }
}