using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace HospitalAPI.Models.Class
{
    public class Patient
    {
        public int PatientId { get; set; }
        [Required,StringLength(100)]
        public string FirstName { get; set; }
        [Required, StringLength(100)]
        public string LastName { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string City { get; set; }
        [Required, Column(TypeName = "date"), DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public string DOB { get; set; }
        [Required,StringLength(12)]
        public string Phone { get; set; }
        [Required,StringLength(50)]
        public string Email { get; set; }
        //nev
        public virtual ICollection<Appointment> Appointments { get; set; }
    }
}
