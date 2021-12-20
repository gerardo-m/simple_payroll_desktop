using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_payroll_desktop.entities
{

    public class TrackingEntry
    {
        public int Id { get; set; }
        public PayRateType Period { get; set; }
        public PayRateType TrackingUnit { get; set; }
        public decimal TrackingValue { get; set; }
        public DateTime Date { get; set; }
        public Worker Worker { get; set; }
    }
}
