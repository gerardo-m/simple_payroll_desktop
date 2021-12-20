using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using simple_payroll_desktop.entities;

namespace simple_payroll_desktop.business.tracking_entries
{
    public class TrackingEntryGenerator
    {

        public IList<TrackingEntry> generateTrackingEntries(TrackingType trackingType, PayPeriod period, Worker worker)
        {
            switch (trackingType)
            {
                case TrackingType.HoursPerDayInAWeek:
                    break;
                case TrackingType.HoursPerDayInAMonth:
                    break;
                case TrackingType.HoursPerWeekInAMonth:
                    break;
                case TrackingType.DayPerDayInAWeek:
                    return generateForDayPerDay(period, worker);
                case TrackingType.DayPerDayInAMonth:
                    return generateForDayPerDay(period, worker);
                case TrackingType.DaysPerWeekInAWeek:
                    break;
                case TrackingType.DaysPerWeekIn4Weeks:
                    break;
                case TrackingType.DaysPerMonthInAMonth:
                    break;
                case TrackingType.WeekPerWeekInAMonth:
                    break;
                case TrackingType.WeeksPerMonthInAMonth:
                    break;
                case TrackingType.MonthsPerMonthInAMonth:
                    break;
                default:
                    break;
            }
            //TODO
            throw new NotImplementedException();
        }

        private IList<TrackingEntry> generateForDayPerDay(PayPeriod period, Worker worker)
        {
            DateTime date = period.PeriodStart;
            List<TrackingEntry> entries = new List<TrackingEntry>();
            while (date <= period.PeriodEnd)
            {
                TrackingEntry entry = new TrackingEntry
                {
                    Period = PayRateType.Daily,
                    TrackingUnit = PayRateType.Daily,
                    TrackingValue = 0,
                    Date = date,
                    Worker = worker
                };
                entries.Add(entry);
                date = date.AddDays(1);
            }
            return entries;
        }
    }
}
