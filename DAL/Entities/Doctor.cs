using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entities;

public partial class Doctor
{
    [Key]
    public int DoctorId { get; set; }
    public string? Locationdoctor { get; set; }
    public string? Qualiification { get; set; }
    public string? Specialization { get; set; }
    public string? Certificationfile { get; set; }
    public string? Birthfile { get; set; }
    public int? SpecializationId { get; set; }
    public int? Statedoctor { get; set; }
    public double? EarningDoctortotal { get; set; }
    public double? AmountsDue { get; set; }
    public string? Infodoctor { get; set; }
    public double? PricePerHour { get; set; }
    public double? Ratingdoctor { get; set; }
    public int? Ratingint { get; set; }
    public string? Experience { get; set; }
    public string? Addresss { get; set; }
    public string? Educationdetails { get; set; }
    public virtual ICollection<Appointment> Appointments { get; set; }
    public virtual ICollection<Feedback> Feedbacks { get; set; } 
    public virtual ICollection<NotAvailableTime> NotAvailableTimes { get; set; }
    public virtual ICollection<AvailableTime> AvailableTimes { get; set; }
    public virtual Specialization? SpecializationNavigation { get; set; }
    public virtual ICollection<Transactionsdoctor> Transactionsdoctors { get; set; }

    [ForeignKey(nameof(User))]
    public Guid UserId { get; set; }
    public virtual AspNetUser User { get; set; }
}
