using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Traning_Platfrom_Core.Enums.Enums;

namespace Traning_Platfrom_Core.Dtos.EducationHistory
{
    public class EducationHistoryDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Specification { get; set; }
        public string OrganizationName { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string? Description { get; set; }
        public string GPA { get; set; }
        public GradingSystem GradingSystem { get; set; }
        public EducationCertificationType EducationCertificationType { get; set; }
        public int JobSeekerId { get; set; }
    }
}
