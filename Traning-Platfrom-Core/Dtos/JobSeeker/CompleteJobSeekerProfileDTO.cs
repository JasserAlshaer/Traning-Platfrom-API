using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traning_Platfrom_Core.Dtos.JobSeeker
{
    public class CompleteJobSeekerProfileDTO
    {
        public string JobSeekerId { get; set; }
        public string ResumeFilePath { get; set; }
        public string ProfileImagePath { get; set; }
        public string Address { get; set; }
        public bool IsHaveDrivingLicense { get; set; }
        public string ProfileBio { get; set; }
    }
}
