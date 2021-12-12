using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using simple_payroll_desktop.entities;

namespace simple_payroll_desktop.business
{
    public class PaySchedulesManager
    {

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
    }
}
