using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using simple_payroll_desktop.entities;

namespace simple_payroll_desktop.dao
{
    public interface TrackingEntryDAO
    {

        IList<TrackingEntry> getTrackingEntries(int workerId, DateTime from, DateTime to);
        void saveTrackingEntry(TrackingEntry trackingEntry);
        void updateTrackingEntry(TrackingEntry trackingEntry);
    }
}
