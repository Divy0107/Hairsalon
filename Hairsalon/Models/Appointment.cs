using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Hairsalon.Models
{
    public class Appointment
    {
        public string AppointmentId { get; set; }

        public string ServiceId { get; set; }

        [DataType(DataType.Time)]
        public DateTime Time { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        //parent reference

        public Service Service { get; set; }
    }
}
