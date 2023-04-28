using HSMD.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSMD.Domain.Models
{
    public class HospitalAddress : AuditableBaseEntity
    {
        public int BuildingNumber { get; set; }
        public string? StreetName { get; set; }
        public string? AreaLocality { get; set; }
        public string? LandMark { get; set; }
        public string? City { get; set; }
        public int Zip_PostalCode { get; set; }
        public string? State_Province { get; set; } 
        
        // Explain here too
        public ICollection<Hospital>? Hospital { get; set; }
    }
}
