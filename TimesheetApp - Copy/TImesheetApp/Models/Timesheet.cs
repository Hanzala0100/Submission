using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TimesheetApp.Models
{
    public class Timesheet
    {
        [Key]
        public int TimesheetId { get; set; }
        [ForeignKey("EmployeeId")]
        public int EmployeeId { get; set; }
        public virtual Employee? Employee { get; set; }
        public string ProjectName { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime TaskDate { get; set; }

        [Range(0, 24, ErrorMessage = "Hours worked must be between 0 and 24.")]
        public decimal HoursWorked { get; set; }

        public string TaskDescription { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
