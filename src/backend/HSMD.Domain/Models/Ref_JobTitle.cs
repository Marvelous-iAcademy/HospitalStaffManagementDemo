using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSMD.Domain.Models
{
    public class Ref_JobTitle
    {
        public int Job_Title_Code { get; set; }
        public string? Job_Title_Description { get; set; }

        public Ref_JobTitle() { }
    }
}
/*This is a C# class named Ref_JobTitle that represents a reference 
 * table for job titles. The class has two properties that represent 
 * attributes of a job title, including a job title code and a description of the job title.

The Job_Title_Code property is likely to be used as a unique 
identifier for each job title in the reference table. 
The Job_Title_Description property provides a textual description of the job title.

The class also includes an empty constructor, which can be used to 
create a new instance of the Ref_JobTitle class without any parameters.

Overall, this class seems to represent a reference table for job 
titles that can be used in a database or other data storage system to 
standardize job titles across an organization.*/