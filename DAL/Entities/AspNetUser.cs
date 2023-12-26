using DAL.Enums;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class AspNetUser : IdentityUser<Guid>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public status Status { get; set; }
        public UserType UserType { get; set; }
        public string IBan { get; set; }
        public string Image { get; set; }
        public bool? Gender { get; set; }
        public string? PhoneNumber { get; set; }
        public DateTime? Startedate { get; set; }
        public DateTime? Birthdate { get; set; }
        public virtual ICollection<Appointment> Appointments { get; set; }

    }
}
