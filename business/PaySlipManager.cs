using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using simple_payroll_desktop.entities;
using simple_payroll_desktop.dao;

namespace simple_payroll_desktop.business
{
    public class PaySlipManager
    {

        private readonly I18nService i18n;
        private readonly PayrollManager payrollManager;

        private readonly PaySlipDAO paySlipDAO;

        public PaySlipManager(I18nService i18n, PayrollManager payrollManager, PaySlipDAO paySlipDAO)
        {
            this.i18n = i18n;
            this.payrollManager = payrollManager;
            this.paySlipDAO = paySlipDAO;
        }

        public IList<PaySlip> getPaysSlips(int payrollId)
        {
            return paySlipDAO.getPaySlips(payrollId);
        }

        public PaySlip createNewPaySlip(Payroll payroll)
        {
            PaySlip paySlip = new PaySlip();
            paySlip.Extras = payroll.Extras.ToList();
            paySlip.Amount = 0;
            paySlip.WorkerCI = payroll.Worker.CI;
            paySlip.WorkerFullName = payroll.Worker.ToString();
            paySlip.PayrollTotal = payroll.TotalAmount;
            paySlip.PreviouslyPaid = calculatePreviouslyPaidForPayroll(payroll);
            paySlip.TrackedWorkAmount = payroll.TrackedAmount;
            paySlip.TrackedWorkConcept = payrollManager.getTrackedTimeLocalizedDetails(payroll);
            paySlip.IsValid = true;
            paySlip.Payroll = payroll;
            return paySlip;
        }

        private decimal calculatePreviouslyPaidForPayroll(Payroll payroll)
        {
            // TODO
            return 0;
        }

        public void savePaySlip(PaySlip paySlip)
        {
            if (paySlip.Id == 0)
                paySlipDAO.savePaySlip(paySlip);
            else
                throw new ArgumentException("Can't modify a saved Pay Slip");
        }
    }
}
