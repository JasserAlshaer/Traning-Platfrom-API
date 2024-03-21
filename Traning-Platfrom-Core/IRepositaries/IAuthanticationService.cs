using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traning_Platfrom_Core.Dtos.JobSeeker;
using Traning_Platfrom_Core.Dtos.Login;
using Traning_Platfrom_Core.Dtos.Logout;
using Traning_Platfrom_Core.Dtos.OrganizationDTO;
using Traning_Platfrom_Core.Dtos.User;

namespace Traning_Platfrom_Core.IRepositaries
{
    public interface IAuthenticationService
    {
        Task CreateJobSeekerAccountAsync(CreateJobSeekerDTO dto);
        Task CreateOrganizationAccountAsync(CreateOrganizationDTO dto);
        Task CreateUserAsync(CreateUserDTO dto);
        Task LoginAsync(LoginDTO dto);
        Task LogoutAsync(LogoutDTO dto);
    }
}
