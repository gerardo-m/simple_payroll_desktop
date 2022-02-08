using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using simple_payroll_desktop.dao;
using simple_payroll_desktop.entities;

namespace simple_payroll_desktop.business.payrolls
{
    public class PayrollCalculator
    {
        private readonly PaySlipDAO paySlipDAO;

        public PayrollCalculator(PaySlipDAO paySlipDAO)
        {
            this.paySlipDAO = paySlipDAO;
        }

        /// <summary>
        /// Calculates TrackedTime, TrackedAmount, AdditionalAmount and BalanceDue for the provided Payroll
        /// </summary>
        /// <param name="payroll"></param>
        /// <returns>The provided payroll with the TrackedTime, TrackedAmount, AdditionalAmount and BalanceDue
        /// properties populated</returns>
        public Payroll calculate(Payroll payroll)
        {
            payroll.ExtrasAmount = calculateExtrasAmount(payroll.Extras);
            payroll.TrackedTime = calculateTrackedTime(payroll.TrackingEntries);
            payroll.TrackedAmount = payroll.TrackedTime * payroll.PayRate;
            payroll.BalanceDue = calculateBalanceDue(payroll);
            return payroll;
        }

        public decimal calculateTrackedTime(IList<TrackingEntry> entries)
        {
            decimal trackedTime = 0;
            foreach (TrackingEntry entry in entries)
            {
                trackedTime += entry.TrackingValue;
            }
            return trackedTime;
        }

        public decimal calculateExtrasAmount(IList<Extra> extras)
        {
            decimal extrasTotal = 0;
            foreach (Extra extra in extras)
                if (extra.Type == ExtraType.AdditionalPay)
                    extrasTotal += extra.Amount;
                else
                    extrasTotal -= extra.Amount;
            return extrasTotal;
        }

        public decimal calculateBalanceDue(Payroll payroll)
        {
            decimal balance = payroll.TotalAmount;
            IList<PaySlip> paySlips = paySlipDAO.getPaySlips(payroll.Id);
            foreach (PaySlip paySlip in paySlips)
            {
                if (paySlip.IsValid)
                    balance -= paySlip.Amount;
            }
            return balance;
        }
    }
}
