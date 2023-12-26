using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entities;

public partial class Feedbackwebsite
{
    [Key]
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Email { get; set; }
    public string? Message { get; set; }
    public DateTime? CreatedAt { get; set; }
    public int? State { get; set; }
    public virtual AspNetUser User { get; set; }
    [ForeignKey(nameof(User))]
    public Guid UserId { get; set; }
}
