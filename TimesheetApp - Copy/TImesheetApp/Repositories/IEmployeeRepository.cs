using TimesheetApp.Models;

namespace TimesheetApp.Repositories
{
    public interface IEmployeeRepository
    {
        Task<Employee> AddEmployee(Employee employee);
        //Employee AddEmployee(Employee employee);
        Task<IEnumerable<Employee>> GetAllEmployees();
        Task<Employee> GetEmployeeById(int employeeId);
        Task<bool> DeleteEmployee(int employeeId);
    }
}
