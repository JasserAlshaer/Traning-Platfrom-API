using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traning_Platfrom_Core.Dtos.JobSeeker;
using Traning_Platfrom_Core.Dtos.Login;
using Traning_Platfrom_Core.Dtos.Logout;
using Traning_Platfrom_Core.Dtos.Organization;
using Traning_Platfrom_Core.Dtos.User;
using Traning_Platfrom_Core.IRepositaries;

namespace Traning_Platfrom_Infra.Repositaries
{
    public class AuthenticationService : IAuthenticationService
    {
        public Task CreateJobSeekerAccount(CreateJobSeekerDTO dto)
        {
            throw new NotImplementedException();
        }

        public Task CreateOrganizationAccount(CreateOrganizationDTO dto)
        {
            throw new NotImplementedException();
        }

        public Task CreateUser(CreateUserDTO dto)
        {
            throw new NotImplementedException();
        }

        public Task Login(LoginDTO dto)
        {
            throw new NotImplementedException();
        }

        public Task Logout(LogoutDTO dto)
        {
            throw new NotImplementedException();
        }
    }
}
