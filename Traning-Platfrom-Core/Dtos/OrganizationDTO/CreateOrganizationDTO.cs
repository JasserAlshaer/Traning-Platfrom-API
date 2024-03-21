using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traning_Platfrom_Core.Dtos.OrganizationDTO
{
    public class CreateOrganizationDTO
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string Phone { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        //Organization Details
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
        public int OrganizationAdminId { get; set; }
    }
}
