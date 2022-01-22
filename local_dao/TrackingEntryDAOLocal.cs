using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using simple_payroll_desktop.entities;
using simple_payroll_desktop.dao;

namespace simple_payroll_desktop.local_dao
{
    public class TrackingEntryDAOLocal : TrackingEntryDAO
    {

        private DbExecuter executer;
        private DbCrudHelper crudHelper;

        private readonly string tableName = "tracking_entries";

        public TrackingEntryDAOLocal()
        {
            executer = new DbExecuter();
            crudHelper = new DbCrudHelper(executer);
        }
        public IList<TrackingEntry> getTrackingEntries(int workerId, DateTime from, DateTime to)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@from", from.Ticks },
                { "@to", to.Ticks },
                { "@workerId", workerId }
            };
            return  executer.selectFromTable(tableName, "date >= @from and date <= @to and worker_id = @workerId", parameters, (reader) => mapFromReader(reader));
        }

        public void saveTrackingEntry(TrackingEntry trackingEntry)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "period", trackingEntry.Period },
                { "tracking_unit", trackingEntry.TrackingUnit },
                { "tracking_value", trackingEntry.TrackingValue },
                { "date", trackingEntry.Date.Ticks },
                { "worker_id", trackingEntry.Worker.Id }
            };
            crudHelper.create(tableName, parameters);
        }

        public void updateTrackingEntry(TrackingEntry trackingEntry)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "period", trackingEntry.Period },
                { "tracking_unit", trackingEntry.TrackingUnit },
                { "tracking_value", trackingEntry.TrackingValue },
                { "date", trackingEntry.Date.Ticks },
                { "worker_id", trackingEntry.Worker.Id },
                { "payroll_id", trackingEntry.Payroll == null ? null : (object)trackingEntry.Payroll.Id }
            };
            crudHelper.update(tableName, parameters, trackingEntry.Id);
        }

        private TrackingEntry mapFromReader(SQLiteDataReader reader)
        {
            return new TrackingEntry
            {
                Id = Convert.ToInt32(reader["id"].ToString()),
                Period = (PayRateType)Convert.ToInt32(reader["period"].ToString()),
                TrackingUnit = (PayRateType)Convert.ToInt32(reader["tracking_unit"].ToString()),
                TrackingValue = Convert.ToDecimal(reader["tracking_value"].ToString()),
                Date = new DateTime(Convert.ToInt64(reader["date"]))
            };
        }

        public IList<TrackingEntry> getTrackingEntries(int workerId)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@workerId", workerId }
            };
            return executer.selectFromTable(tableName, "worker_id = @workerId", parameters, (reader) => mapFromReader(reader));
        }

        public void deleteTrackingEntry(TrackingEntry trackingEntry)
        {
            crudHelper.delete(tableName, trackingEntry.Id);
        }
    }
}
