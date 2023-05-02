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
