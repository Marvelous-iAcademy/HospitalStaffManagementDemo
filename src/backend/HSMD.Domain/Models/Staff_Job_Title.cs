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
