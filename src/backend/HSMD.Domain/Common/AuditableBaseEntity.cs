using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSMD.Domain.Common
{
    public class AuditableBaseEntity
    {
        public int Id { get; set; }  // Primary Key
        public string? CreatedBy { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
        public DateTime? DateModified { get; set; }

    }
}

/*The `AuditableBaseEntity` class is a base class that provides 
 * common properties for entities that require auditing functionality. 
 * It has the following properties:

- `Id`: an integer property that serves as the primary key for the entity.
- `CreatedBy`: a string property that represents the user who created the entity.
- `DateCreated`: a DateTime property that represents the date and time 
when the entity was created. It has a default value of the current date and time.
- `DateModified`: a nullable DateTime property that represents the date 
and time when the entity was last modified. It is nullable because the 
entity may not have been modified yet.*/
