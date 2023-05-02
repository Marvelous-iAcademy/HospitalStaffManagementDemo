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
