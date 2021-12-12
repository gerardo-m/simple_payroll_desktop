using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using simple_payroll_desktop.dao;
using simple_payroll_desktop.entities;

namespace simple_payroll_desktop.business
{
    public class PaySchedulesManager
    {

        private readonly I18nService i18n;
        private PayScheduleDAO payScheduleDAO;

        public PaySchedulesManager(I18nService i18n, PayScheduleDAO payScheduleDAO)
        {
            this.i18n = i18n;
            this.payScheduleDAO = payScheduleDAO;
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
            // TODO
            return true;
        }
    }
}
