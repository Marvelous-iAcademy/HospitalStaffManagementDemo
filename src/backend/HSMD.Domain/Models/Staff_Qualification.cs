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
