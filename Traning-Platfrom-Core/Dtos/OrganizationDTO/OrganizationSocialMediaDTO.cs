using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traning_Platfrom_Core.Dtos.OrganizationDTO
{
    public class OrganizationSocialMediaDTO
    {
        public int OrganizationId { get; set; }
        public string? FaceBookLink { get; set; }
        public string? TwitterLink { get; set; }
        public string? LinkedInLink { get; set; }
        public string? WebsiteUrl { get; set; }

    }
}
