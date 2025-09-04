using TimesheetApp.Models;

namespace TimesheetApp.Services
{
    public interface IEmployeeService
    {
        Task<Employee> AddEmployee(Employee employee);
        Task<IEnumerable<Employee>> GetAllEmployees();
        Task<Employee> GetEmployeeById(int employeeId);
        Task<bool> DeleteEmployee(int employeeId);
    }
}
