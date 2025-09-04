using TimesheetApp.Models;
using TimesheetApp.Repositories;

namespace TimesheetApp.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;
        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        // ADD EMPLOYEE
        public async Task<Employee> AddEmployee(Employee employee)
        {
            return await _employeeRepository.AddEmployee(employee);
        }

        // GET ALL EMPLOYEES
        public async Task<IEnumerable<Employee>> GetAllEmployees()
        {
            return await _employeeRepository.GetAllEmployees();
        }

        // GET EMPLOYEE BY ID
        public async Task<Employee> GetEmployeeById(int employeeId)
        {
            return await _employeeRepository.GetEmployeeById(employeeId);
        }

        // DELETE EMPLOYEE 
        public async Task<bool> DeleteEmployee(int employeeId)
        {
            return await _employeeRepository.DeleteEmployee(employeeId);
        }
    }
}
