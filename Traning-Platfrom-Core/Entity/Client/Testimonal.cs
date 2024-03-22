using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traning_Platfrom_Core.Entity.Shared;

namespace Traning_Platfrom_Core.Entity.Client
{
    public class Testimonial : SharedEntity
    {
        public string Comment { get; set; }
        public int RateCount { get; set; }
        public virtual JobSeeker JobSeeker { get; set; }
    }
}
