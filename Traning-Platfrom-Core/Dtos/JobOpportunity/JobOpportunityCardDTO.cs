using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Traning_Platfrom_Core.Enums.Enums;

namespace Traning_Platfrom_Core.Dtos.JobOpportunity
{
    public class JobOpportunityCardDTO
    {
        public int  Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string? Region { get; set; }
        public string JobLevel { get; set; }

        public string JobType      { get; set; }
        public int    JobFieldId   { get; set; }
        public string? JobField      { get; set; }
        public string Gender        {    get; set; }
        public string Qualification { get; set; }
        public string JobLocation    { get; set; }
        public int? OrganizationId { get; set; }
        public string? OrganizationName { get; set; }
        public string? OrganizationProfileImage { get; set; }
        public DateTime? AppliedDate { get; set; }
        public DateTime? CreationDate { get; set; }
        public int? ApplicationAmount { get; set; }
        public bool? IsThereInterview { get; set; }
        public int? InterviewId       { get; set; }
    }
}
