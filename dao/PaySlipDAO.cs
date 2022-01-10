using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using simple_payroll_desktop.entities;

namespace simple_payroll_desktop.dao
{
    public interface PaySlipDAO
    {

        void savePaySlip(PaySlip paySlip);
        IList<PaySlip> getPaySlips(int payrollId);
    }
}
