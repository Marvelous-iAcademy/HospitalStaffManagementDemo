using HSMD.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSMD.Domain.Models
{
    public class Staff_Job_Title : AuditableBaseEntity
    {
        [ForeignKey(nameof(Staff))]
        public int StaffId { get; set; }
        [ForeignKey(nameof(Ref_JobTitle))]
        public int Job_Title_Code { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }

        public virtual Staff? Staff { get; set; }

        public Staff_Job_Title() { }
    }
}

/*This is a C# class named `Staff_Job_Title` that represents the 
 * job titles held by staff members in an organization. 
 * The class inherits from an `AuditableBaseEntity` class, 
 * which suggests that it may be used in an audit trail to track 
 * changes to the job titles held by staff members.

The class has several properties that represent attributes of a 
staff job title, including a `StaffId` property that is a foreign 
key reference to the `Staff` class, and a `Job_Title_Code` property 
that is a foreign key reference to the `Ref_JobTitle` class. 
This suggests that there is a relationship between the `Staff_Job_Title`, 
`Staff`, and `Ref_JobTitle` classes, and that each staff member can 
hold multiple job titles.

The class also includes `DateFrom` and `DateTo` properties that 
represent the start and end dates of each job title held by a staff member.

The `Staff` property is a virtual property that provides a navigation 
property to the associated `Staff` object, and can be used to access 
related data from other tables in the database.

Overall, this class seems to represent a many-to-many relationship 
between the `Staff` and `Ref_JobTitle` classes, and includes information 
about the job titles held by staff members, as well as the dates during 
which they held those job titles.*/