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

/*This is a C# class named `HospitalAddress` that represents the 
 * address of a hospital. The class has several properties that represent 
 * attributes of an address, such as building number, street name, 
 * area/locality, landmark, city, zip/postal code, and state/province.

The class also has a property named `Hospitals`, which is an 
`ICollection<Hospital>` type. This indicates that a `HospitalAddress` 
object can have a collection of associated `Hospital` objects, and suggests 
that the two classes are related in some way. This relationship could be a 
one-to-many relationship, where each `HospitalAddress` object can have multiple
`Hospital` objects associated with it.

Overall, this class seems to represent an address entity in a database or 
other data storage system, and includes information about the building and 
location of a hospital.*/