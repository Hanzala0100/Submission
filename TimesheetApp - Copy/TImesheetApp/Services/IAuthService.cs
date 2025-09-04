using TImesheetApp.Models;

namespace TImesheetApp.Services
{
    public interface IAuthService
    {
        LoginResponseViewModel Login(LoginViewModel loginEmployee);
    }
}
