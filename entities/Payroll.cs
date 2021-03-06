using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_payroll_desktop.entities
{

    public enum PayrollStatus
    {
        Open,
        Closed,
        ClosedAndPaid,
        Cancelled
    }
    public class Payroll
    {

        public int Id { get; set; }
        public DateTime PeriodStart { get; set; }
        public DateTime PeriodEnd { get; set; }
        public DateTime Date { get; set; }
        public decimal PayRate { get; set; }
        public PayRateType PayRateType { get; set; }
        public decimal TrackedTime { get; set; }
        public decimal TrackedAmount { get; set; }
        public decimal ExtrasAmount { get; set; }
        public decimal TotalAmount { 
            get
            {
                return TrackedAmount + ExtrasAmount;
            }
        }
        public decimal BalanceDue { get; set; }
        public PaySchedule PaySchedule { get; set; }
        public Worker Worker { get; set; }
        public PayScheduleType PayScheduleType { get; set; }
        public IList<TrackingEntry> TrackingEntries { get; set; }
        public IList<Extra> Extras { get; set; }
        public PayrollStatus Status { get; set; }
    }
}
