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
