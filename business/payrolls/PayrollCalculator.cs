using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using simple_payroll_desktop.entities;

namespace simple_payroll_desktop.business.payrolls
{
    public class PayrollCalculator
    {
        /// <summary>
        /// Calculates TrackedTime, TrackedAmount, AdditionalAmount and BalanceDue for the provided Payroll
        /// </summary>
        /// <param name="payroll"></param>
        /// <returns>The provided payroll with the TrackedTime, TrackedAmount, AdditionalAmount and BalanceDue
        /// properties populated</returns>
        public Payroll calculate(Payroll payroll)
        {
            payroll.AdditionalsAmount = calculateAdditionalsAmount(payroll.Additionals);
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

        public decimal calculateAdditionalsAmount(IList<Additional> additionals)
        {
            decimal additionalsTotal = 0;
            foreach (Additional additional in additionals)
                if (additional.Type == AdditionalType.ExtraPay)
                    additionalsTotal += additional.Amount;
                else
                    additionalsTotal -= additional.Amount;
            return additionalsTotal;
        }

        public decimal calculateBalanceDue(Payroll payroll)
        {
            // TODO after implementing PaySlip
            return payroll.TotalAmount;
        }
    }
}
