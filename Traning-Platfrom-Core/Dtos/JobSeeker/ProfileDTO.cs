using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traning_Platfrom_Core.Dtos.JobSeeker
{
    public class ProfileDTO
    {
        public int JobSeekerId { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Pio { get; set; }
        public string FaceBook { get; set; }
        public string Github { get; set; }
        public string LinkedIn { get; set; }
        public string Instgram { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string Major { get; set; }
        public string Lanaguage { get; set; }
    }
}
