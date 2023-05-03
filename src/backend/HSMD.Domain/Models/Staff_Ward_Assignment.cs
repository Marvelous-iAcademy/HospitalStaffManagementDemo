using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSMD.Domain.Models
{
    public class Staff_Ward_Assignment
    {
        [ForeignKey(nameof(Staff))]
        public int StaffId { get; set; }
        [ForeignKey(nameof(Ward))]
        public int Ward_Id { get; set; }
        public DateTime Date_From { get; set; }
        public DateTime Date_To { get; set; }

        public virtual Staff? Staff { get; set; }
    }
}

/*This is a C# class named `Staff_Ward_Assignment` that 
 * represents a staff member's assignment to a specific ward in a hospital. 
 * The class has four properties that represent attributes of staff ward assignments, 
 * including a `StaffId` property that represents the ID of the staff member 
 * who is assigned to the ward, a `Ward_Id` property that represents the ID of 
 * the ward to which the staff member is assigned, a `Date_From` property that 
 * represents the starting date of the assignment, and a `Date_To` property 
 * that represents the ending date of the assignment.

The `StaffId` and `Ward_Id` properties are likely to be used as 
foreign key references to the `Staff` and `Ward` classes, respectively. 
This suggests that there is a relationship between the `Staff_Ward_Assignment`, 
`Staff`, and `Ward` classes, and that each staff member can be assigned 
to different wards at different times.

The `Staff_Ward_Assignment` class includes a navigation property named `Staff`, 
which is a reference to the `Staff` class. This property allows access to the 
`Staff` object associated with a specific staff ward assignment, which can be useful 
for retrieving additional information about the staff member.

Overall, this class seems to represent a many-to-many relationship between the 
`Staff` and `Ward` classes, and includes information about staff member assignments 
to specific wards, as well as the dates of those assignments.*/
