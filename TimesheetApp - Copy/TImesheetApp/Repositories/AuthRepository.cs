using Microsoft.AspNetCore.Identity;
using TimesheetApp.Data;
using TimesheetApp.Models;
using TImesheetApp.Models;

namespace TImesheetApp.Repositories
{
    public class AuthRepository : IAuthRepository
    {
        private readonly TimesheetDbContext _context;
        private readonly PasswordHasher<Employee> _passwordHasher;


        public AuthRepository(TimesheetDbContext context, PasswordHasher<Employee> passwordHasher)
        {
            _context = context;
            _passwordHasher = passwordHasher;
        }

        // LOGIN
        LoginResponseViewModel IAuthRepository.Login(LoginViewModel loginEmployee)
        {
            var employee = _context.Employees.FirstOrDefault(e => e.EmployeeId == loginEmployee.EmployeeId
                                  && e.UserName == loginEmployee.UserName);

            LoginResponseViewModel response;

            if (employee == null)
                return response = new LoginResponseViewModel { Employee = null, IsSuccess = false, Token = " " };

            var passwordCheck = _passwordHasher.VerifyHashedPassword(employee, employee.PasswordHash, loginEmployee.Password);
            if (passwordCheck != PasswordVerificationResult.Success)
                return response = new LoginResponseViewModel { Employee = null, IsSuccess = false, Token = " " };


            return response = new LoginResponseViewModel { Employee = employee, IsSuccess = true, Token = " " };
        }
    }
}
