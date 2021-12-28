using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using simple_payroll_desktop.entities;

namespace simple_payroll_desktop.dao
{
    public interface PayrollDAO
    {

        /// <summary>
        /// Returns the payroll for the provided workerId and period
        /// If there is no payroll that met these requirements it should return null
        /// </summary>
        /// <param name="workerId"></param>
        /// <param name="period"></param>
        /// <returns></returns>
        Payroll getPayroll(int workerId, PayPeriod period);
    }
}
