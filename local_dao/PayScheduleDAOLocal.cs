using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using simple_payroll_desktop.dao;
using simple_payroll_desktop.entities;

namespace simple_payroll_desktop.local_dao
{
    public class PayScheduleDAOLocal : PayScheduleDAO
    {

        private DbExecuter executer = new DbExecuter();
        public IList<PaySchedule> allPaySchedules()
        {
            return executer.selectFromTable<PaySchedule>("pay_schedules", (reader) => mapFromReader(reader));
        }

        public void deletePaySchedule(PaySchedule paySchedule)
        {
            throw new NotImplementedException();
        }

        public PaySchedule getPaySchedule(int id)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@id", id);
            return executer.selectFromTable<PaySchedule>("pay_schedules", "id = @id", parameters, (reader) => mapFromReader(reader)).First();
        }

        public void savePaySchedule(PaySchedule paySchedule)
        {
            string query = "INSERT INTO pay_schedules(name, type, pay_rate_type, tracking_type, base_period_start, base_period_end, base_pay_day)" +
                " values (@name, @type, @pay_rate_type, @tracking_type, @base_period_start, @base_period_end, @base_pay_day)";
            Dictionary<string, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@name", paySchedule.Name);
            parameters.Add("@type", paySchedule.Type);
            parameters.Add("@pay_rate_type", paySchedule.PayRateType);
            parameters.Add("@tracking_type", paySchedule.TrackingType);
            parameters.Add("@base_period_start", paySchedule.BasePeriodStart.Ticks);
            parameters.Add("@base_period_end", paySchedule.BasePeriodStart.Ticks);
            parameters.Add("@base_pay_day", paySchedule.BasePayDay.Ticks);
            executer.executeQuery(query, parameters);
        }

        public void updatePaySchedule(PaySchedule paySchedule)
        {
            throw new NotImplementedException();
        }

        private PaySchedule mapFromReader(SQLiteDataReader reader)
        {
            return new PaySchedule
            {
                Id = Convert.ToInt32(reader["id"].ToString()),
                Name = reader["name"].ToString(),
                Type = (PayScheduleType)Convert.ToInt32(reader["type"].ToString()),
                PayRateType = (PayRateType)Convert.ToInt32(reader["pay_rate_type"].ToString()),
                TrackingType = (TrackingType)Convert.ToInt32(reader["tracking_type"].ToString()),
                BasePeriodStart = new DateTime(Convert.ToInt64(reader["base_period_start"].ToString())),
                BasePeriodEnd = new DateTime(Convert.ToInt64(reader["base_period_end"].ToString())),
                BasePayDay = new DateTime(Convert.ToInt64(reader["base_pay_day"].ToString()))
            };
        }
    }
}
