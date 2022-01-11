using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using simple_payroll_desktop.dao;
using simple_payroll_desktop.entities;
using simple_payroll_desktop.business.pay_schedules;

namespace simple_payroll_desktop.business
{
    public class PaySchedulesManager
    {

        private readonly I18nService i18n;
        private PayScheduleDAO payScheduleDAO;
        private WorkerDAO workerDAO;

        private WeeklyPayScheduleManager weeklyManager;

        public PaySchedulesManager(I18nService i18n, PayScheduleDAO payScheduleDAO, WorkerDAO workerDAO)
        {
            this.i18n = i18n;
            this.payScheduleDAO = payScheduleDAO;
            this.workerDAO = workerDAO;
            weeklyManager = new WeeklyPayScheduleManager();
        }

        public IList<PayRateType> payRateTypesForPayScheduleType(PayScheduleType payScheduleType)
        {
            List<PayRateType> result = new List<PayRateType>((IEnumerable<PayRateType>)Enum.GetValues(typeof(PayRateType)));
            if (payScheduleType is PayScheduleType.OneTime)
            {
                return result;
            }
            result.Remove(PayRateType.FixedPay);
            if (payScheduleType is PayScheduleType.Monthly)
            {
                return result;
            }
            result.Remove(PayRateType.Monthly);
            return result;
        }

        public IList<TrackingType> trackingTypeForPayRateType(PayRateType payRateType)
        {
            List<TrackingType> result = new List<TrackingType>();
            if (payRateType is PayRateType.Hourly)
            {
                result.Add(TrackingType.HoursPerDayInAWeek);
                result.Add(TrackingType.HoursPerDayInAMonth);
                result.Add(TrackingType.HoursPerWeekInAMonth);
                return result;
            }
            if (payRateType is PayRateType.Daily)
            {
                result.Add(TrackingType.DayPerDayInAWeek);
                result.Add(TrackingType.DayPerDayInAMonth);
                result.Add(TrackingType.DaysPerWeekInAWeek);
                result.Add(TrackingType.DaysPerWeekIn4Weeks);
                result.Add(TrackingType.DaysPerMonthInAMonth);
                return result;
            }
            if (payRateType is PayRateType.Weekly)
            {
                result.Add(TrackingType.WeekPerWeekInAMonth);
                result.Add(TrackingType.WeeksPerMonthInAMonth);
                return result;
            }
            return result;
        }

        public IList<PaySchedule> allPaySchedules()
        {
            return payScheduleDAO.allPaySchedules();
        }

        public void savePaySchedule(PaySchedule paySchedule)
        {
            if (paySchedule.Id == 0)
            {
                payScheduleDAO.savePaySchedule(paySchedule);
            }
            else
            {
                payScheduleDAO.updatePaySchedule(paySchedule);
            }
        }

        public void deletePaySchedule(PaySchedule paySchedule)
        {
            if (canDelete(paySchedule))
            {
                payScheduleDAO.deletePaySchedule(paySchedule);
            }
            else
            {
                throw new InvalidOperationException(i18n.Placeholder("The pay schedule is already assigned. First delete the employees assigned to this pay schedule or change their pay schedule"));
            }
        }

        private bool canDelete(PaySchedule paySchedule)
        {
            int workersWithPaySchedule = workerDAO.workersWithDenominationCount(paySchedule.Id);
            return workersWithPaySchedule == 0;
        }

        /**
         * Get the pay period for the pay schedule that contains the date parameter
         */
        public PayPeriod getPayPeriod(PaySchedule paySchedule, DateTime date)
        {
            //TODO other pay Schedule Types
            switch (paySchedule.Type)
            {
                case PayScheduleType.Weekly:
                    return weeklyManager.getPayPeriod(paySchedule, date);
                case PayScheduleType.Biweekly:
                    break;
                case PayScheduleType.Monthly:
                    break;
                case PayScheduleType.OneTime:
                    break;
                default:
                    break;
            }
            return new PayPeriod
            {
                PeriodStart = DateTime.Today.AddDays(-7),
                PeriodEnd = DateTime.Today,
                PayDay = DateTime.Today.AddDays(-1)
            };
        }

        public PayPeriod previousPayPeriod(PaySchedule paySchedule, PayPeriod period)
        {
            //TODO other pay schedule types
            switch (paySchedule.Type)
            {
                case PayScheduleType.Weekly:
                    return weeklyManager.previousPayPeriod(period);
                case PayScheduleType.Biweekly:
                    break;
                case PayScheduleType.Monthly:
                    break;
                case PayScheduleType.OneTime:
                    break;
                default:
                    break;
            }
            throw new NotImplementedException();
        }

        public PayPeriod nextPayPeriod(PaySchedule paySchedule, PayPeriod period)
        {
            //TODO other pay schedule types
            switch (paySchedule.Type)
            {
                case PayScheduleType.Weekly:
                    return weeklyManager.nextPayPeriod(period);
                case PayScheduleType.Biweekly:
                    break;
                case PayScheduleType.Monthly:
                    break;
                case PayScheduleType.OneTime:
                    break;
                default:
                    break;
            }
            throw new NotImplementedException();
        }

        
    }
}
