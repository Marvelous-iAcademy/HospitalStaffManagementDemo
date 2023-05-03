using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSMD.Domain.Models
{
    public class Ref_Qualification
    {
        public int QualificationCode { get; set; }
        public string? QualificationTitle { get; set; }
        public string? QualificationDescription { get; set; }

        public Ref_Qualification() { }
    }
}
/*This is a C# class named `Ref_Qualification` that represents a 
 * reference table for qualifications. The class has three properties that 
 * represent attributes of a qualification, including a qualification code,
 * a qualification title, and a description of the qualification.

The `QualificationCode` property is likely to be used as a unique identifier 
for each qualification in the reference table. The `QualificationTitle` 
property provides a textual title for the qualification, while the 
`QualificationDescription` property provides a more detailed description.

The class also includes an empty constructor, which can be used to create a 
new instance of the `Ref_Qualification` class without any parameters.

Overall, this class seems to represent a reference table for qualifications 
that can be used in a database or other data storage system to standardize 
qualifications across an organization.*/