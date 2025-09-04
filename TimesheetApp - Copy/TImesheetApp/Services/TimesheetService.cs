using TimesheetApp.Models;
using TimesheetApp.Repositories;

namespace TimesheetApp.Services
{
    public class TimesheetService : ITimesheetService
    {
        private readonly ITimesheetRepository _timesheetRepository;
        public TimesheetService(ITimesheetRepository timesheetRepository)
        {
            _timesheetRepository = timesheetRepository;
        }

        // ADD TIMESHEET
        public async Task<Timesheet> AddTimesheet(Timesheet timesheet)
        {
            return await _timesheetRepository.AddTimesheet(timesheet);
        }

        // GET ALL TIMESHEETS
        public async Task<IEnumerable<Timesheet>> GetAllTimesheets()
        {
            return await _timesheetRepository.GetAllTimesheets();
        }

        // GET TIMESHEET BY ID
        public async Task<Timesheet> GetTimesheetById(int timesheetId)
        {
            return await _timesheetRepository.GetTimesheetById(timesheetId);
        }

        // DELETE TIMESHEET
        public async Task<bool> DeleteTimesheet(int timesheetId)
        {
            return await _timesheetRepository.DeleteTimesheet(timesheetId);
        }

        // GET TIMESHEET BY EMPLOYEE ID
        public async Task<IEnumerable<Timesheet>> GetTimesheetByEmployeeId(int employeeId)
        {
            return await _timesheetRepository.GetTimesheetByEmployeeId(employeeId);
        }
    }
}
