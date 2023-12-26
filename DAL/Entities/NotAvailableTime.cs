using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entities;

public partial class NotAvailableTime
{
    [Key]
    public int NotavailableId { get; set; }

    [ForeignKey(nameof(Doctor))]
    public int? DoctorId { get; set; }
    public string? Timenotavailble { get; set; }
    public virtual Doctor? Doctor { get; set; }


}
