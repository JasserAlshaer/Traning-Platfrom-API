using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traning_Platfrom_Core.Dtos.JobSeeker
{
    public class TopJobSeekerDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string JobTitle {  get; set; }
        public string Image { get; set; }
        public int ExperienceInDays { get; set; }
    }
}
