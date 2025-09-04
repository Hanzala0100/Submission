using Microsoft.EntityFrameworkCore;
using TimesheetApp.Data;
using TimesheetApp.Models;

namespace TimesheetApp.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly TimesheetDbContext _context;
        public EmployeeRepository(TimesheetDbContext context)
        {
            _context = context;
        }

        // ADD EMPLOYEE
        public async Task<Employee> AddEmployee(Employee employee)
        {
            var newEmployee = await _context.Employees.AddAsync(employee);
            _context.SaveChanges();
            return employee;
        }

        // GET ALL EMPLOYEES
        public async Task<IEnumerable<Employee>> GetAllEmployees()
        {
            var employees = await _context.Employees.ToListAsync();
            return employees;
        }

        // GET EMPLOYEE BY ID
        public async Task<Employee> GetEmployeeById(int employeeId)
        {
            var employee = await _context.Employees.FirstOrDefaultAsync(e => e.EmployeeId == employeeId);
            return employee;
        }

        // DELETE EMPLOYEE
        public async Task<bool> DeleteEmployee(int employeeId)
        {
            var employee = await _context.Employees.FindAsync(employeeId);
            if (employee != null)
            {
                _context.Remove(employee);
                _context.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
