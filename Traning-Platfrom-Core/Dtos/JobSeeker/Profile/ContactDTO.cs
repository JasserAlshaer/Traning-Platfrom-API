using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traning_Platfrom_Core.Dtos.JobSeeker.Profile
{
    public class ContactDTO
    {
        public int JobSeekerId { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string Major { get; set; }
        public string Lanaguage { get; set; }
    }
}
