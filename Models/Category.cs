using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EF.Models
{
  public class Category
  {
    [Key]
    public Guid Id { get; set; }

    [Required]
    [MaxLength(150)]
    public string? Name { get; set; }
    public string? Description { get; set; }
    public virtual ICollection<Task>? Tasks { get; set; }
  }
}