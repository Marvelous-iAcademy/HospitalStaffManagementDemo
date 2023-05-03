using HSMD.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSMD.Domain.Models
{
    public class StaffAddress : AuditableBaseEntity
    {
        public int BuildingNumber { get; set; }
        public string? StreetName { get; set; }
        public string? Area_locality { get; set; }
        public string? LandMark { get; set; }
        public string? City { get; set; }
        public int Zip_PostalCode { get; set; }
        public string? State_Province { get; set; }

        public ICollection<Staff>? Staff { get; set; }
    }
}

/*This is a class definition for a `StaffAddress` entity. 
 * It has properties for the building number, street name, 
 * area/locality, landmark, city, zip/postal code, and state/province. 
 * It also has a collection of `Staff` entities that 
 * are associated with this address.

The `AuditableBaseEntity` suggests that this class is likely to 
inherit from a base class that contains auditing fields such as 
CreatedBy, CreatedOn, UpdatedBy, UpdatedOn, etc.*/
