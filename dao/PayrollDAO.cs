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
        Payroll getPayrollByPeriod(int workerId, PayPeriod period);
        Payroll getPayroll(int payrollId);
        IList<Payroll> getPayrollsByWorker(int workerId);

        int getPayrollCount(int workerId);
        /// <summary>
        /// Must return the count of payrolls for a worker with status
        /// [PayrollStatus.Closed] or [PayrollStatus.ClosedAndPaid]
        /// </summary>
        /// <param name="workerId"></param>
        /// <returns></returns>
        int getClosedPayrollCount(int workerId);

        void savePayroll(Payroll payroll);
        void updatePayroll(Payroll payroll);
        void deletePayroll(Payroll payroll);

    }
}
