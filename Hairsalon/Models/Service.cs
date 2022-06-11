using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hairsalon.Models
{
    public class Service
    {
        public int ServiceId { get; set; }

        public string ServiceName { get; set; }

        public double ServicePrice { get; set; }

        public string ServiceMaterials { get; set; }

        // child reference
        public List<Appointment> Appointments { get; set; }
    }
}
