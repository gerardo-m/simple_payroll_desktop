using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_payroll_desktop.entities
{

    public enum AdditionalType{
        ExtraPay,
        Discount
    }
    public class Additional
    {

        public int Id { get; set; }
        public AdditionalType Type { get; set; }
        public string Concept { get; set; }
        public decimal Amount { get; set; }
        public Payroll Payroll { get; set; }
    }
}
