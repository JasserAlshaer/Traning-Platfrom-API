using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net.Mail;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Traning_Platfrom_Core.Context;
using Traning_Platfrom_Core.Dtos.Authantication;
using Traning_Platfrom_Core.Dtos.JobSeeker;
using Traning_Platfrom_Core.Dtos.Login;
using Traning_Platfrom_Core.Dtos.Logout;
using Traning_Platfrom_Core.Dtos.OrganizationDTO;
using Traning_Platfrom_Core.Dtos.User;
using Traning_Platfrom_Core.Entity.Client;
using Traning_Platfrom_Core.Entity.Company;
using Traning_Platfrom_Core.Entity.UserConfiguration;
using Traning_Platfrom_Core.IRepositaries;
using static Traning_Platfrom_Core.Enums.Enums;

namespace Traning_Platfrom_Infra.Repositaries
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly TrainingPlatformDbContext _context;
        private readonly IConfiguration _configuration;
        public AuthenticationService(TrainingPlatformDbContext context,IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }

        public async Task CreateJobSeekerAccountAsync(CreateJobSeekerDTO dto)
        {
            JobSeeker jobSeeker = new JobSeeker()
            {
                FirstName = dto.FirstName,
                SecondName = dto.SecondName,
                LastName = dto.LastName,
                EmailAddress = dto.EmailAddress,
                Phone = dto.Phone,
                UserName = dto.UserName,
                Password = dto.Password,
                BirthDate = dto.BirthDate,
                Gender = dto.Gender,
                IsProfileCompleted = false,
            };
            await _context.AddAsync(jobSeeker);
            await _context.SaveChangesAsync();
        }

        public async Task CreateOrganizationAccountAsync(CreateOrganizationDTO dto)
        {
            OrganizationAdmin organizationAdmin = new OrganizationAdmin()
            {
                FirstName = dto.FirstName,
                SecondName = dto.SecondName,
                LastName = dto.LastName,
                EmailAddress = dto.EmailAddress,
                Phone = dto.Phone,
                UserName = dto.UserName,
                Password = dto.Password,
            };
            await _context.AddAsync(organizationAdmin);
            await _context.SaveChangesAsync();
            if (organizationAdmin.Id > 0)
            {
                Organization organization = new Organization()
                {
                    Name = dto.Name,
                    Pio = dto.Pio,
                    Address = dto.Address,
                    Email = dto.Email,
                    ProfileImage = dto.ProfileImage,
                    PreviewVideoPath = dto.PreviewVideoPath,
                    YearFounded = dto.YearFounded,
                    GitHubLink = dto.GitHubLink,
                    FaceBookLink = dto.FaceBookLink,
                    TwitterLink = dto.TwitterLink,
                    LinkdeInLink = dto.LinkdeInLink,
                    OrganizationAdmin = organizationAdmin
                };
                await _context.AddAsync(organization);
                await _context.SaveChangesAsync();
            }
            else
            {
                _context.Remove(organizationAdmin);
                await _context.SaveChangesAsync();
            }
            

        }

        public async Task CreateUserAsync(CreateUserDTO dto)
        {
            User user = new User()
            {
                FirstName = dto.FirstName,
                SecondName = dto.SecondName,
                LastName = dto.LastName,
                EmailAddress = dto.EmailAddress,
                Phone = dto.Phone,
                UserName = dto.UserName,
                Password = dto.Password,
            };
            await _context.AddAsync(user);
            await _context.SaveChangesAsync();
        }

        public string GenerateJWTToken(TokenDTO dto)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenKey = Encoding.UTF8.GetBytes(_configuration.GetValue<string>("TokenSecrect"));
            var tokenDescriptior = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                        new Claim("UserType",dto.UserType),
                        new Claim("UserId",dto.UserId+""),
                        new Claim("OrganizationId",dto.OrganizationId+""),
                        new Claim("UserName",dto.UserName)
                }),
                Expires = DateTime.Now.AddHours(2),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(tokenKey)
                , SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptior);
            return tokenHandler.WriteToken(token);
        }

        public async Task<string> LoginAsync(LoginDTO dto)
        {
            if (dto.LoginType.Equals("Cand"))
            {
                var res = _context.JobSeekers.Where(x=>x.EmailAddress == dto.Email
                && x.Password == dto.Password).SingleOrDefault();
                if (res != null)
                {
                    return  GenerateJWTToken(new TokenDTO() { 
                    OrganizationId=null,
                    UserId=res.Id,
                    UserName=res.FirstName +" "+res.LastName,
                    UserType = "JobSeeker"
                    });
                }
                throw new Exception("Login Failed Either Email or Password Is UnCorrect");
            }else if (dto.LoginType.Equals("Org"))
            {
                var res = _context.OrganizationAdmins.Include(x=>x.Organizations)
                    .Where(x => x.EmailAddress == dto.Email
                && x.Password == dto.Password).SingleOrDefault();
                if (res != null)
                {
                    return GenerateJWTToken(new TokenDTO()
                    {
                        OrganizationId = res.Organizations.FirstOrDefault()?.Id,
                        UserId = res.Id,
                        UserName = res.FirstName + " " + res.LastName,
                        UserType = "Orfanization"
                    });
                }
                throw new Exception("Login Failed Either Email or Password Is UnCorrect");
            }
            else
            {
                throw new Exception("Not Allowd Yet");
            }
        }
    }
}
