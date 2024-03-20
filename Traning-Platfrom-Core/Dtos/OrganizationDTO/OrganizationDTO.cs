using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traning_Platfrom_Core.Dtos.OrganizationDTO
{
    public class OrganizationDTO
    {
        public string Name { get; set; }
        public string Pio { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string ProfileImage { get; set; }
        public string PreviewVideoPath { get; set; }
        public DateTime YearFounded { get; set; }
        public string GitHubLink { get; set; }
        public string FaceBookLink { get; set; }
        public string TwitterLink { get; set; }
        public string LinkdeInLink { get; set; }
    }
}
