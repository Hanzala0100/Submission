using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TimesheetApp.Models;
using TimesheetApp.Services;

namespace TimesheetApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;
        private readonly PasswordHasher<Employee> _passwordHasher;

        public EmployeeController(IEmployeeService employeeService, PasswordHasher<Employee> passwordHasher)
        {
            _employeeService = employeeService;
            _passwordHasher = passwordHasher;
        }

        // ADD EMPLOYEE
        [HttpPost("AddEmployee")]
        public async Task<IActionResult> AddEmployee([FromBody] Employee employee)
        {
            try
            {
                if (employee == null)
                    return BadRequest("Employee data is null");

                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                if (!string.IsNullOrEmpty(employee.PasswordHash))
                {
                    employee.PasswordHash = _passwordHasher.HashPassword(employee, employee.PasswordHash);
                }

                var newEmployee = await _employeeService.AddEmployee(employee);
                if (newEmployee != null)
                    return CreatedAtAction(actionName: "GetEmployeeById",
                                           routeValues: new { employeeId = newEmployee.EmployeeId }, value: newEmployee);

                return Ok("New employee didn't get added");
            }
            catch (Exception ex)
            {
                return StatusCode(500, new
                {
                    message = "Failed to add new employee",
                    details = ex.Message
                });
            }
        }

        // GET ALL EMPLOYEES
        [HttpGet("GetAllEmployees")]
        [Authorize]
        public async Task<IActionResult> GetAllEmployees()
        {
            try
            {
                var employees = await _employeeService.GetAllEmployees();

                if (employees != null)
                    return Ok(employees);

                return Ok("No employees found");
            }
            catch (Exception ex)
            {
                return StatusCode(500, new
                {
                    message = "Failed to get all employees",
                    details = ex.Message
                });
            }
        }

        // GET EMPLOYEE BY ID
        [HttpGet("GetEmployeeById")]
        [Authorize]
        public async Task<IActionResult> GetEmployeeById([FromQuery] int employeeId)
        {
            try
            {
                var employee = await _employeeService.GetEmployeeById(employeeId);

                if (employee != null)
                    return Ok(employee);

                return Ok($"Employee with Id {employeeId} does not exists");
            }
            catch (Exception ex)
            {
                return StatusCode(500, new
                {
                    message = "Failed to get employee by Id",
                    details = ex.Message
                });
            }
        }

        // DELETE EMPLOYEE
        [HttpDelete("DeleteEmployee")]
        [Authorize]
        public async Task<IActionResult> DeleteEmployee([FromQuery] int employeeId)
        {
            try
            {
                var employee = await _employeeService.DeleteEmployee(employeeId);

                if (employee)
                    return Ok("Employee deleted successfully");

                return Ok($"Employee with Id {employeeId} does not exists");
            }
            catch (Exception ex)
            {
                return StatusCode(500, new
                {
                    message = "Failed to delete employee",
                    details = ex.Message
                });
            }
        }
    }
}
