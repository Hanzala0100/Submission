using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TimesheetApp.Models;
using TimesheetApp.Services;

namespace TimesheetApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TimesheetController : ControllerBase
    {
        private readonly ITimesheetService _timesheetService;
        public TimesheetController(ITimesheetService timesheetService)
        {
            _timesheetService = timesheetService;
        }

        // ADD TIMESHEET
        [HttpPost("AddTimesheet")]
        [Authorize]
        public async Task<IActionResult> AddTimesheet([FromBody] Timesheet timesheet)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest();

                int employeeId = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier)?.Value);
                timesheet.EmployeeId = employeeId;

                var newTimesheet = await _timesheetService.AddTimesheet(timesheet);
                if (newTimesheet != null)
                    return CreatedAtAction(actionName: "GetTimesheetById",
                                        routeValues: new { timesheetId = newTimesheet.TimesheetId }, value: newTimesheet);

                return Ok("New timesheet didn't get added");
            }
            catch (Exception ex)
            {
                return StatusCode(500, new
                {
                    message = "Failed to add new timehsheet",
                    details = ex.Message
                });
            }
        }

        // GET ALL TIMESHEET
        [HttpGet("GetAllTimesheets")]
        [Authorize]
        public async Task<IActionResult> GetAllTimesheet()
        {
            try
            {
                var timesheets = await _timesheetService.GetAllTimesheets();

                if (timesheets != null || timesheets.Any())
                    return Ok(timesheets);

                return Ok("No timesheets found");
            }
            catch (Exception ex)
            {
                return StatusCode(500, new
                {
                    message = "Failed to get all timesheets",
                    details = ex.Message
                });
            }
        }

        // GET TIMESHEET BY ID
        [HttpGet("GetTimesheetById")]
        [Authorize]
        public async Task<IActionResult> GetTimesheetById([FromQuery] int timesheetId)
        {
            try
            {
                var timesheet = await _timesheetService.GetTimesheetById(timesheetId);

                if (timesheet != null)
                    return Ok(timesheet);

                return Ok($"No timesheet available for given Id {timesheetId}");
            }
            catch (Exception ex)
            {
                return StatusCode(500, new
                {
                    message = "Failed to get timeseet by Id",
                    details = ex.Message
                });
            }
        }

        // DELETE TIMESHEET
        [HttpDelete("DeleteTimesheet")]
        [Authorize]
        public async Task<IActionResult> DeleteTimesheet([FromQuery] int timesheetId)
        {
            try
            {
                var timesheet = await _timesheetService.DeleteTimesheet(timesheetId);

                if (timesheet)
                    return Ok($"Timesheet with Id {timesheetId} deleted successfully");

                return Ok($"Employee with Id {timesheetId} does not exists");
            }
            catch (Exception ex)
            {
                return StatusCode(500, new
                {
                    message = "Failed to delete timesheet",
                    details = ex.Message
                });
            }
        }

        // GET TIMESHEET BY EMPLOYEE ID
        [HttpGet("GetTimesheetByEmployeeId")]
        [Authorize]
        public async Task<IActionResult> GetTimesheetByEmployeeId()
        {
            try
            {
                int employeeId = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier)?.Value);

                var timesheets = await _timesheetService.GetTimesheetByEmployeeId(employeeId);

                if (timesheets != null || timesheets.Any())
                    return Ok(timesheets);

                return Ok("No timesheets found for this employee");
            }
            catch (Exception ex)
            {
                return StatusCode(500, new
                {
                    message = "Failed to get timeseet by employee Id",
                    details = ex.Message
                });
            }
        }
    }
}
