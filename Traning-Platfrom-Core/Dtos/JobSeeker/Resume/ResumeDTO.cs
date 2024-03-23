using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Traning_Platfrom_Core.Enums.Enums;

namespace Traning_Platfrom_Core.Dtos.JobSeeker.Resume
{
    public class ResumeDTO
    {
        public int JobSeekerId { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Nationality { get; set; }
        public string MaritalStatus { get; set; }
        public DateTime DateofBirth { get; set; }
        public string FullAddress { get; set; }
        public string Gender { get; set; }
        public string Qualification { get; set; }
    }
}
