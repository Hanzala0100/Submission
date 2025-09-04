using TimesheetApp.Models;

namespace TimesheetApp.Services
{
    public interface ITimesheetService
    {
        Task<Timesheet> AddTimesheet(Timesheet timesheet);
        Task<IEnumerable<Timesheet>> GetAllTimesheets();
        Task<Timesheet> GetTimesheetById(int timesheetId);
        Task<bool> DeleteTimesheet(int timesheetId);
        Task<IEnumerable<Timesheet>> GetTimesheetByEmployeeId(int employeeId);
    }
}
