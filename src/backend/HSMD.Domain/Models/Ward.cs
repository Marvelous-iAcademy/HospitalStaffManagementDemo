using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSMD.Domain.Models
{
    public class Ward
    {
        public int Ward_Id { get; set; }
        public string? Ward_Name { get; set; }
        public string? Ward_Location { get; set; }
        public string? Ward_Description { get; set; }

        public Ward() { }
    }
}

/*This is a class definition for a `Ward` entity. 
 * It has properties for the ward ID, ward name, 
 * ward location, and ward description.

The `Ward_Id` property is likely to be a primary key that 
uniquely identifies each ward in the database. 

The `Ward_Name` property represents the name of the ward, 
which could be used to identify it. The `Ward_Location` 
property could be used to indicate where the ward is physically 
located within the hospital, such as a specific floor or wing.

The `Ward_Description` property could be used to provide additional 
information about the ward, such as its purpose, 
the types of patients it serves, or any specialized 
equipment or services that it provides.*/