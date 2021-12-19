using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using simple_payroll_desktop.entities;

namespace simple_payroll_desktop.business.pay_schedules
{
    class WeeklyPayScheduleManager
    {

        public PayPeriod getPayPeriod(PaySchedule paySchedule, DateTime date)
        {
            TimeSpan periodStartDifference = date - paySchedule.BasePeriodStart;
            TimeSpan periodEndMinusStart = paySchedule.BasePeriodEnd - paySchedule.BasePeriodStart;
            TimeSpan payDayMinusPeriodStart = paySchedule.BasePayDay - paySchedule.BasePeriodStart;
            int periodStartDayDifference = periodStartDifference.Days;
            int daysPastPeriodStart = periodStartDayDifference % 7;
            DateTime periodStart = date.AddDays(-daysPastPeriodStart);
            return new PayPeriod
            {
                PeriodStart = periodStart,
                PeriodEnd = periodStart.AddDays(periodEndMinusStart.Days),
                PayDay = periodStart.AddDays(payDayMinusPeriodStart.Days)
            };
        }

        public PayPeriod previousPayPeriod(PayPeriod period)
        {
            return new PayPeriod
            {
                PeriodStart = period.PeriodStart.AddDays(-7),
                PeriodEnd = period.PeriodEnd.AddDays(-7),
                PayDay = period.PayDay.AddDays(-7)
            };
        }

        public PayPeriod nextPayPeriod(PayPeriod period)
        {
            return new PayPeriod
            {
                PeriodStart = period.PeriodStart.AddDays(7),
                PeriodEnd = period.PeriodEnd.AddDays(7),
                PayDay = period.PayDay.AddDays(7)
            };
        }
    }
}
