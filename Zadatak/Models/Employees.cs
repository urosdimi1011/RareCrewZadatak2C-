using System;
namespace Zadatak.Models
{
    public class Employees
    {
        public string Id { get; set; }
        public string EmployeeName { get; set; }
        public DateTime StarTimeUtc { get; set; }
        public DateTime EndTimeUtc { get; set; }
        public string EntryNotes { get; set; }
        public DateTime? DeletedOn { get; set; }


        public double TotalTimeWorked => (EndTimeUtc - StarTimeUtc).TotalHours;
    }
}
