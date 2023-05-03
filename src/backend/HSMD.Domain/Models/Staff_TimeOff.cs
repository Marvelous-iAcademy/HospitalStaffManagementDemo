using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSMD.Domain.Models
{
    public class Staff_TimeOff
    {
        public int Staff_Id { get; set; }
        public int Ward_Id { get; set; }
        public DateTime Date_From { get; set; }
        public DateTime Date_To { get; set; }
    }
}

/*This is a C# class named `Staff_TimeOff` that represents 
 * time off taken by a staff member in a hospital. 
 * The class has four properties that represent attributes 
 * of staff time off, including a `Staff_Id` property that 
 * represents the ID of the staff member who took the time off, 
 * a `Ward_Id` property that represents the ID of the ward in 
 * which the staff member works, a `Date_From` property that 
 * represents the starting date of the time off, and a `Date_To` 
 * property that represents the ending date of the time off.

The `Staff_Id` and `Ward_Id` properties are likely to be used as 
foreign key references to the `Staff` and `Ward` classes, 
respectively. This suggests that there is a relationship between 
the `Staff_TimeOff`, `Staff`, and `Ward` classes, and that each 
staff member can take time off from work in different wards.

The `Staff_TimeOff` class does not inherit from any other class, 
so it does not include any additional functionality or behavior 
beyond its properties.

Overall, this class seems to represent a one-to-many relationship 
between the `Staff` and `Ward` classes, and includes information 
about the time off taken by staff members, as well as the wards 
in which they work.*/
