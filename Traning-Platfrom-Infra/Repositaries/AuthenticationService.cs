using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traning_Platfrom_Core.Context;
using Traning_Platfrom_Core.Dtos.JobSeeker;
using Traning_Platfrom_Core.Dtos.Login;
using Traning_Platfrom_Core.Dtos.Logout;
using Traning_Platfrom_Core.Dtos.OrganizationDTO;
using Traning_Platfrom_Core.Dtos.User;
using Traning_Platfrom_Core.IRepositaries;

namespace Traning_Platfrom_Infra.Repositaries
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly TrainingPlatformDbContext _context;
        public AuthenticationService(TrainingPlatformDbContext context)
        {
            _context = context;
        }

        public Task CreateJobSeekerAccountAsync(CreateJobSeekerDTO dto)
        {
            throw new NotImplementedException();
        }

        public Task CreateOrganizationAccountAsync(CreateOrganizationDTO dto)
        {
            throw new NotImplementedException();
        }

        public Task CreateUserAsync(CreateUserDTO dto)
        {
            throw new NotImplementedException();
        }

        public Task LoginAsync(LoginDTO dto)
        {
            throw new NotImplementedException();
        }

        public Task LogoutAsync(LogoutDTO dto)
        {
            throw new NotImplementedException();
        }
    }
}
