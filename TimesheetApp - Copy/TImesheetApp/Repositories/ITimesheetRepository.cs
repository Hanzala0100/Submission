using TimesheetApp.Models;

namespace TimesheetApp.Repositories
{
    public interface ITimesheetRepository
    {
        Task<Timesheet> AddTimesheet(Timesheet timesheet);
        Task<IEnumerable<Timesheet>> GetAllTimesheets();
        Task<Timesheet> GetTimesheetById(int timesheetId);
        Task<bool> DeleteTimesheet(int timesheetId);
        Task<IEnumerable<Timesheet>> GetTimesheetByEmployeeId(int employeeId);
    }
}
