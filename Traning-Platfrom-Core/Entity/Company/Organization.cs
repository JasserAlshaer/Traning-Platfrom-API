﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traning_Platfrom_Core.Entity.Lookups;
using Traning_Platfrom_Core.Entity.Shared;
using Traning_Platfrom_Core.Entity.UserConfiguration;
using static Traning_Platfrom_Core.Enums.Enums;

namespace Traning_Platfrom_Core.Entity.Company
{
    public class Organization : SharedEntity
    {
        public string Name { get; set; }
        public string Pio { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string ProfileImage { get; set; }
        public string PreviewVideoPath { get; set; }
        public string? WebsiteUrl { get; set; }
        public DateTime YearFounded { get; set; }
        public string TeamSize { get; set; }
        public string? GitHubLink { get; set; }
        public string? FaceBookLink { get; set; }
        public string? TwitterLink { get; set; }
        public string? LinkdeInLink { get; set; }
        public Cities City { get; set; }
        public string Country { get; set; }
        public virtual JobField JobField { get; set; }
        public virtual  OrganizationAdmin OrganizationAdmin { get; set; }
        public virtual  List<JobOpportunity> JobOpportunities { get; set; }
    }
}
