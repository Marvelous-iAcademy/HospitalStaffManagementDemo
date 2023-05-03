using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSMD.Domain.Models
{
    public class Staff_Qualification
    {
        public int StaffId { get; set; }
        public int QualificationCode { get; set; }
        public DateTime DateObtained { get; set; }

        public Staff_Qualification() { }
    }
}

/*This is a C# class named `Staff_Qualification` that 
 * represents the qualifications obtained by staff 
 * members in an organization. 
 * The class has three properties that represent attributes of a 
 * staff qualification, including a `StaffId` property that 
 * represents the ID of the staff member who obtained the 
 * qualification, a `QualificationCode` property that represents 
 * the code of the qualification obtained, and a `DateObtained` 
 * property that represents the date on which the qualification was obtained.

The `StaffId` and `QualificationCode` properties are likely to 
be used as foreign key references to the `Staff` and 
`Ref_Qualification` classes, respectively. 
This suggests that there is a relationship between the `Staff_Qualification`, 
`Staff`, and `Ref_Qualification` classes, and that each 
staff member can obtain multiple qualifications.

The `Staff_Qualification` class does not inherit from any other class, 
so it does not include any additional functionality or behavior beyond its properties.

Overall, this class seems to represent a one-to-many relationship between 
the `Staff` and `Ref_Qualification` classes, and includes 
information about the qualifications obtained by staff members, 
as well as the dates on which they obtained those qualifications.*/
