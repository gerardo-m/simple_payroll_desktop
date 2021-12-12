using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_payroll_desktop.entities
{

    public enum PayScheduleType
    {
        Weekly,
        Biweekly,
        Monthly,
        OneTime
    }

    public enum PayRateType
    {
        Hourly,
        Daily,
        Weekly,
        Monthly,
        FixedPay
    }

    public enum TrackingType
    {
        HoursPerDayInAWeek,
        HoursPerDayInAMonth,
        HoursPerWeekInAMonth,
        DayPerDayInAWeek,
        DayPerDayInAMonth,
        DaysPerWeekInAWeek,
        DaysPerWeekIn4Weeks,
        DaysPerMonthInAMonth,
        WeekPerWeekInAMonth,
        WeeksPerMonthInAMonth
    }

    public class PaySchedule
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public PayScheduleType Type { get; set; }
        public PayRateType PayRateType { get; set; }
        public TrackingType TrackingType { get; set; }

        public DateTime BasePeriodStart { get; set; }
        public DateTime BasePeriodEnd { get; set; }
        public DateTime BasePayDay { get; set; }


    }
}
