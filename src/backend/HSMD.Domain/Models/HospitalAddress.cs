using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSMD.Domain.Models
{
    public class HospitalAddress
    {
        public int BuildingNumber { get; set; }
        public string? StreetName { get; set; }
        public string? Area_locality { get; set; }
        public string? LandMark { get; set; }
        public string? City { get; set; }
        public int Zip_PostalCode { get; set; }
        public string? State_Province { get; set; }

        public ICollection<Hospital>? Hospitals { get; set; }
    }
}
