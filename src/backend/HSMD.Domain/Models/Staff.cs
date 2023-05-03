using HSMD.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSMD.Domain.Models
{
    public class Staff : AuditableBaseEntity
    {
        public int Staff_AddressId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime? BirthDate { get; set; }
        public string? Gender { get; set; }
        public DateTime Date_Joined_Hospital { get; set; }
        public DateTime Date_Left_Hospital { get; set; }

        public StaffAddress? StaffAddress { get; set; }

        public Staff() { }
    }
}
/*This is a C# class named Staff, which inherits from AuditableBaseEntity (not shown here). 
 * The class has several properties that represent attributes of a hospital staff member,
 * such as their name, birth date, gender, and dates of joining and leaving the hospital.

The class also has a property named Staff_AddressId, which represents the ID of the address
associated with the staff member. This property is likely to be a foreign key that links to
another table or entity that represents the staff member's address.

The Staff class also has a reference to a StaffAddress object, represented by the StaffAddress 
property. This indicates that a Staff object can have an associated StaffAddress object, and 
suggests that the two classes are related in some way.

Finally, the class has a default constructor, which initializes a new instance of the class 
with default values.
*/