using Microsoft.EntityFrameworkCore;
using TimesheetApp.Models;

namespace TimesheetApp.Data
{
    public class TimesheetDbContext : DbContext
    {
        public TimesheetDbContext() { }
        public TimesheetDbContext(DbContextOptions options) : base(options) { }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Timesheet> Timesheets { get; set; }
    }
}
