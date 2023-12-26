using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entities;

public partial class Appointment
{
    [Key]
    public int ApointmentId { get; set; }
    public virtual AspNetUser User { get; set; }

    [ForeignKey(nameof(User))]
    public Guid UserId { get; set; }
    public string? Starttime { get; set; }
    public string? Endtime { get; set; }
    public string? Doctornotes { get; set; }
    public string? Patientnotes { get; set; }
    public int? Apointmentprice { get; set; }
    public decimal? Rating { get; set; }
    public DateOnly? BookingDate { get; set; }
    public string? Dosage { get; set; }
    public string? Dosagefrequency { get; set; }
    public string? Medicationinstructions { get; set; }
    public int? Confirmappointment { get; set; }
    public string? JoinUrl { get; set; }

}
