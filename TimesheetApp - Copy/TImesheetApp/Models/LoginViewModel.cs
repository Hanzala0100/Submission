using System.ComponentModel.DataAnnotations;

namespace TImesheetApp.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Employee Id is required for login")]
        public int EmployeeId { get; set; }

        [Required(ErrorMessage = "Username is required for login")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Password is required for login")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
