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

        private DbExecuter executer = new DbExecuter();
        public IList<TrackingEntry> getTrackingEntries(int workerId, DateTime from, DateTime to)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@from", from.Ticks);
            parameters.Add("@to", to.Ticks);
            parameters.Add("@workerId", workerId);
            return  executer.selectFromTable<TrackingEntry>("tracking_entries", "date >= @from and date <= @to and worker_id = @workerId", parameters, (reader) => mapFromReader(reader));
        }

        public void saveTrackingEntry(TrackingEntry trackingEntry)
        {
            string query = "INSERT INTO tracking_entries(period, tracking_unit, tracking_value, date, worker_id)" +
                " values (@period, @tracking_unit, @tracking_value, @date, @worker_id)";
            Dictionary<string, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@period", trackingEntry.Period);
            parameters.Add("@tracking_unit", trackingEntry.TrackingUnit);
            parameters.Add("@tracking_value", trackingEntry.TrackingValue);
            parameters.Add("@date", trackingEntry.Date.Ticks);
            parameters.Add("@worker_id", trackingEntry.Worker.Id);
            executer.executeQuery(query, parameters);
        }

        public void updateTrackingEntry(TrackingEntry trackingEntry)
        {
            string query = "UPDATE tracking_entries set period = @period, tracking_unit = @tracking_unit, tracking_value = @tracking_value," +
                " date = @date, worker_id = @worker_id where id = @id";
            Dictionary<string, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@period", trackingEntry.Period);
            parameters.Add("@tracking_unit", trackingEntry.TrackingUnit);
            parameters.Add("@tracking_value", trackingEntry.TrackingValue);
            parameters.Add("@date", trackingEntry.Date.Ticks);
            parameters.Add("@worker_id", trackingEntry.Worker.Id);
            parameters.Add("@id", trackingEntry.Id);
            executer.executeQuery(query, parameters);
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
    }
}
