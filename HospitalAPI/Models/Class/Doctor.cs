using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalAPI.Models.Class
{
    public class Doctor
    {
         public int DoctorId { get; set; }
        [Required,StringLength(100)]

        public string FirstName { get; set; }

        [Required, StringLength(100)]

        public string LastName { get; set; }

        public string Specialist { get; set; }
        //nev
        public virtual ICollection<Appointment> Appointments { get; set; }
    }
}
