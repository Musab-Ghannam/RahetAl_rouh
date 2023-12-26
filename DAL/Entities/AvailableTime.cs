using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class AvailableTime
    {
        [Key]
        public int Id { get; set; }
        public DateTime StartAppointment { get; set; }
        public DateTime EndAppointment { get; set; }

        [ForeignKey(nameof(Doctor))]
        public int? DoctorId { get; set; }
        public virtual Doctor? Doctor { get; set; }
    }
}
