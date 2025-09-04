using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using TimesheetApp.Models;
using TImesheetApp.Models;
using TImesheetApp.Repositories;

namespace TImesheetApp.Services
{
    public class AuthService : IAuthService
    {
        private readonly IAuthRepository _authRepository;
        private readonly IConfiguration _configuration;
        public AuthService(IAuthRepository authRepository, IConfiguration configuration)
        {
            _authRepository = authRepository;
            _configuration = configuration;
        }

        LoginResponseViewModel IAuthService.Login(LoginViewModel loginEmployee)
        {
            var response = _authRepository.Login(loginEmployee);
            if (response.Employee != null)
            {
                response.Token = GenerateAccessToken(response.Employee);
            }
            return response;
        }

        string GenerateAccessToken(Employee employee)
        {
            var issuer = _configuration["JwtSettings:issuer"];
            var audience = _configuration["JwtSettings:audience"];
            var securityKey = _configuration["JwtSettings:securityKey"];

            var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(securityKey));
            var signingCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, employee.EmployeeId.ToString()),
                new Claim(ClaimTypes.Name, employee.UserName),
            };
            var tokenOptions = new JwtSecurityToken(
                issuer: issuer,
                audience: audience,
                claims: claims,
                expires: DateTime.Now.AddMinutes(30),
                signingCredentials: signingCredentials);

            var tokenString = new JwtSecurityTokenHandler().WriteToken(tokenOptions);
            return tokenString;
        }
    }
}
