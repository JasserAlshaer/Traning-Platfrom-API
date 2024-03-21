using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Serilog;
using System.Configuration;
using System.IdentityModel.Tokens.Jwt;
using System.Net;
using System.Reflection;
using System.Text;
using Traning_Platfrom_Core.Context;
using Traning_Platfrom_Core.IRepositaries;
using Traning_Platfrom_Infra.Repositaries;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers().AddNewtonsoftJson();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
//Configure DB
builder.Services.AddDbContext<TrainingPlatformDbContext>(options=>
options.UseMySQL(builder.Configuration.GetConnectionString("Default")));
//Configure Implementation Scope 
builder.Services.AddScoped<IAuthenticationService, AuthenticationService>();
builder.Services.AddScoped<IJobSeekerService, JobSeekerService>();
builder.Services.AddScoped<IOrganizationService, OrganizationService>();
builder.Services.AddScoped<ISharedService, SharedService>();
//swagger with enable for summary 
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "Training Platform API",
    });

    // Configure JWT authentication for Swagger
    var securityScheme = new OpenApiSecurityScheme
    {
        Name = "JWT Authentication",
        Description = "Enter your JWT token",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.Http,
        Scheme = "bearer", // Important: Use "bearer" lowercase
        BearerFormat = "JWT",
        Reference = new OpenApiReference
        {
            Type = ReferenceType.SecurityScheme,
            Id = "Bearer"
        }
    };

    options.AddSecurityDefinition("Bearer", securityScheme);

    var securityRequirement = new OpenApiSecurityRequirement
    {
        { securityScheme, new List<string>() }
    };

    options.AddSecurityRequirement(securityRequirement);

    var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));
});
string mainDir = Directory.GetCurrentDirectory();
string loggerPath = mainDir+builder.Configuration.GetSection("LoggerPath").Value;
Serilog.Log.Logger = new LoggerConfiguration().
                WriteTo.File(loggerPath, rollingInterval: RollingInterval.Day).
                CreateLogger();

//JWT
// Add authentication services
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = false,
            ValidateAudience = false,
            ValidateLifetime = false,
            ValidateIssuerSigningKey = false,
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration.GetValue<string>("TokenSecrect")))
        };
    });

//CORS ORIGIN
builder.Services.AddCors(opt =>
{
    opt.AddPolicy(name: "X", builder =>
    {
        builder.AllowAnyOrigin()
            .AllowAnyHeader()
            .AllowAnyMethod();
    });
});


var app = builder.Build();

// Configure the HTTP request pipeline.

try
{
    Log.Information("Appliing Configuration");
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseCors("X");
    app.UseAuthentication();
    app.UseAuthorization();
    app.UseHttpsRedirection();

    app.UseAuthorization();

    app.Use(async (context, next) =>
    {
        var authorizeAttribute = context.GetEndpoint()?.Metadata?.GetMetadata<AuthorizeAttribute>();

        if (authorizeAttribute != null)
        {
            var tokenString = context.Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last();
            if (string.IsNullOrEmpty(tokenString))
            {
                context.Response.StatusCode = (int)HttpStatusCode.Unauthorized;
                await context.Response.WriteAsync("Unauthorized");
                return;
            }
            String toke = "Bearer " + tokenString;
            var jwtEncodedString = toke.Substring(7);
            var token = new JwtSecurityToken(jwtEncodedString: jwtEncodedString);
            DateTime dateTime = DateTime.UtcNow;
            DateTime expires = token.ValidTo;
            try
            {
                if (dateTime >= expires)
                {
                    context.Response.StatusCode = (int)HttpStatusCode.Unauthorized;
                    await context.Response.WriteAsync("Unauthorized");
                    return;
                }
            }
            catch (SecurityTokenException)
            {
                context.Response.StatusCode = (int)HttpStatusCode.Unauthorized;
                await context.Response.WriteAsync("Unauthorized");
                return;
            }
        }
        await next();
    });
    app.MapControllers();
    Log.Information("API Starting Successfully");
    app.Run();

}
catch (Exception ex)
{
    Log.Fatal("Could Not Strart API");
    Log.Error(ex.Message);
}




