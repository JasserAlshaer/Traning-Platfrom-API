using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traning_Platfrom_Core.Dtos.JobSeeker.Profile
{
    public class SocialMediaDTO
    {
        public int JobSeekerId { get; set; }
        public string FaceBook { get; set; }
        public string Github {  get; set; }
        public string LinkedIn { get; set; }
        public string Instgram { get; set; }
    }
}
