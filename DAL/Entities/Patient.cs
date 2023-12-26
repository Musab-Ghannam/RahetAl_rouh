using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entities;

public partial class Patient
{
    [Key]
    public int PatiantId { get; set; }

    [ForeignKey(nameof(User))]
    public Guid UserId { get; set; }
    public virtual AspNetUser User { get; set; }
    public double? Wallet { get; set; }
    public virtual ICollection<Feedback> Feedbacks { get; set; }

    public virtual ICollection<Feedbackwebsite> Feedbackwebsites { get; set; } 

    public virtual ICollection<Transactionspatient> Transactionspatients { get; set; } 

}
