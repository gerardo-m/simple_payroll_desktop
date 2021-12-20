using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using simple_payroll_desktop.dao;
using simple_payroll_desktop.entities;
using simple_payroll_desktop.business.tracking_entries;

namespace simple_payroll_desktop.business
{
    public class TrackingEntriesManager
    {

        private readonly I18nService i18n;
        private TrackingEntryDAO trackingEntryDAO;

        private TrackingEntryGenerator generator;

        public TrackingEntriesManager(I18nService i18n, TrackingEntryDAO trackingEntryDAO)
        {
            this.i18n = i18n;
            this.trackingEntryDAO = trackingEntryDAO;
            generator = new TrackingEntryGenerator();
        }

        public void saveTrackingEntries(IList<TrackingEntry> entries)
        {
            foreach (TrackingEntry entry in entries)
            {
                if (entry.Id == 0)
                    trackingEntryDAO.saveTrackingEntry(entry);
                else
                    trackingEntryDAO.updateTrackingEntry(entry);
            }
        }

        public IList<TrackingEntry> getTrackingEntries(PayPeriod period, Worker worker)
        {
            IList<TrackingEntry> dbEntries = trackingEntryDAO.getTrackingEntries(worker.Id, period.PeriodStart, period.PeriodEnd);
            if (dbEntries.Count == 0)
                return generator.generateTrackingEntries(worker.PaySchedule.TrackingType, period, worker);
            else
            {
                foreach (TrackingEntry entry in dbEntries)
                    entry.Worker = worker;
                return dbEntries;
            }
        }
    }
}
