using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DAL.Entities;

public partial class Specialization
{
    [Key]
    public int SpecializationId { get; set; }
    public string? Namespecialization { get; set; }
    public string? Descriptionspecialization { get; set; }
    public string? Picturespecialization { get; set; }
    public string? Videospecializaion { get; set; }
    public virtual ICollection<Doctor> Doctors { get; set; } = new List<Doctor>();
}
