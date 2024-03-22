using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traning_Platfrom_Core.Dtos.EducationHistory;
using Traning_Platfrom_Core.Dtos.Experience;

namespace Traning_Platfrom_Core.Dtos.JobSeeker
{
    public class JobSeekerCompleteProfileDTO
    {
        public int JobSeekerId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Pio { get; set; }
        public string FaceBook { get; set; }
        public string Github { get; set; }
        public string LinkedIn { get; set; }
        public string Instgram { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Major { get; set; }
        public string Lanaguage { get; set; }
        public string Nationality { get; set; }
        public string MaritalStatus { get; set; }
        public DateTime DateofBirth { get; set; }
        public string FullAddress { get; set; }
        public string Gender { get; set; }
        public string Image { get; set; }
        public string ResumePath { get; set; }
        public int ExperienceInDays { get; set; }
        public string Qualification { get; set; }
        public List<ExperienceDTO> Experiences { get; set; }
        public List<EducationHistoryDTO> Educations { get; set; }

    }
}
