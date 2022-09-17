using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalAPI.Models.Class
{
    public class Appointment
    {
        public int AppointmentId { get; set; }
        public string Type { get; set; }
        [Required, Column(TypeName = "date"), DisplayFormat(DataFormatString ="{0:yyyy-MM-dd}",ApplyFormatInEditMode =true)]

        public DateTime AppointmentDate { get; set; }

        [Required, Column(TypeName = "date"), DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]

        public DateTime AppointmentTime { get; set; }

        public string AppointmentDes { get; set; }
        [ForeignKey("Patient")]
        public int PatientId { get; set; }
        [ForeignKey("Doctor")]
        public int DoctorId { get; set; }

        //Nev
        public virtual Doctor Doctor { get; set; }
        public virtual Patient Patient { get; set; }
    }
}
