using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DAL.Entities;

public partial class Transactionsdoctor
{
    [Key]
    public int TransDoctorId { get; set; }
    public int? DoctorId { get; set; }
    public string? Transactiontype { get; set; }
    public double? Amount { get; set; }
    public string? Paymentmethod { get; set; }
    public DateTime? TransactionDate { get; set; }
    public string? Status { get; set; }
    public string? Description { get; set; }
    public DateTime? Tansactiontime { get; set; }
    public string? DoctorName { get; set; }
    public virtual Doctor? Doctor { get; set; }
}
