using Microsoft.EntityFrameworkCore;
using TimesheetApp.Data;
using TimesheetApp.Models;

namespace TimesheetApp.Repositories
{
    public class TimesheetRepository : ITimesheetRepository
    {
        private readonly TimesheetDbContext _context;
        public TimesheetRepository(TimesheetDbContext context)
        {
            _context = context;
        }

        // ADD TIMESHEET
        public async Task<Timesheet> AddTimesheet(Timesheet timesheet)
        {
            var newTimesheet = await _context.Timesheets.AddAsync(timesheet);
            _context.SaveChanges();
            return timesheet;
        }

        // GET ALL TIMESHEET
        public async Task<IEnumerable<Timesheet>> GetAllTimesheets()
        {
            var timesheets = await _context.Timesheets.ToListAsync();
            return timesheets;
        }

        // GET TIMESHEET BY ID
        public async Task<Timesheet> GetTimesheetById(int timesheetId)
        {
            var timesheet = await _context.Timesheets.FirstOrDefaultAsync(t => t.TimesheetId == timesheetId);
            return timesheet;
        }

        // DELETE TIMESHEET
        public async Task<bool> DeleteTimesheet(int timesheetId)
        {
            var timesheet = await _context.Timesheets.FindAsync(timesheetId);
            if (timesheet != null)
            {
                _context.Remove(timesheet);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        // GET TIMESHEET BY EMPLOYEE ID
        public async Task<IEnumerable<Timesheet>> GetTimesheetByEmployeeId(int employeeId)
        {
            var timesheets = await _context.Timesheets.Where(t => t.EmployeeId == employeeId).ToListAsync();
            return timesheets;
        }
    }
}
