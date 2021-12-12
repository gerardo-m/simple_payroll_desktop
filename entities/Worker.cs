using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_payroll_desktop.entities
{
    public class Worker
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName1 { get; set; }
        public string LastName2 { get; set; }
        public string CI { get; set; }
        public decimal PayRate { get; set; }
        public PayRateType PayRateType { get; set; }
        public PaySchedule PaySchedule { get; set; }
        public Denomination Denomination { get; set; }

    }
}
