using TImesheetApp.Models;

namespace TImesheetApp.Repositories
{
    public interface IAuthRepository
    {
        LoginResponseViewModel Login(LoginViewModel loginEmployee);
    }
}
