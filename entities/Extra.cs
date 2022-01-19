using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_payroll_desktop.entities
{

    public enum ExtraType{
        AdditionalPay,
        Discount
    }
    public class Extra
    {

        public int Id { get; set; }
        public ExtraType Type { get; set; }
        public string Concept { get; set; }
        public decimal Amount { get; set; }
        public Payroll Payroll { get; set; }
    }
}
