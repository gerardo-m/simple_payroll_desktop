using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using simple_payroll_desktop.entities;

namespace simple_payroll_desktop.forms.controls.track_work
{
    public class TrackerControlSelector
    { 

        public BaseTrackerControl getTrackerControl(TrackingType trackingType, IList<TrackingEntry> entries, ILogger logger, I18nService i18nService)
        {
            switch (trackingType)
            {
                /*case TrackingType.HoursPerDayInAWeek:
                    break;
                case TrackingType.HoursPerDayInAMonth:
                    break;
                case TrackingType.HoursPerWeekInAMonth:
                    break;*/
                case TrackingType.DayPerDayInAWeek:
                    return new DaysDayWeekTrackerControl(logger, i18nService, entries);
                /*case TrackingType.DayPerDayInAMonth:
                    break;
                case TrackingType.DaysPerWeekInAWeek:
                    break;
                case TrackingType.DaysPerWeekIn4Weeks:
                    break;
                case TrackingType.DaysPerMonthInAMonth:
                    break;
                case TrackingType.WeekPerWeekInAMonth:
                    break;
                case TrackingType.WeeksPerMonthInAMonth:
                    break;*/
                default:
                    return new DefaultTrackerControl(entries);
            }
        }
    }
}
