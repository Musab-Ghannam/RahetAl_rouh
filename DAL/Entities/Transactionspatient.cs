using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DAL.Entities;

public partial class Transactionspatient
{
    [Key]
    public int TranscpatientId { get; set; }
    public int? PatiantId { get; set; }
    public string? Transpatienttiontype { get; set; }
    public double? Amount { get; set; }
    public string? Paymentmethod { get; set; }
    public DateTime? TransactionDate { get; set; }
    public string? Status { get; set; }
    public string? Description { get; set; }
    public DateTime? Tansactiontime { get; set; }
    public virtual Patient? Patiant { get; set; }
}
