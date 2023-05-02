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
