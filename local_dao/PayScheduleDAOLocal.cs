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

        private DbExecuter executer;
        private DbCrudHelper crudHelper;

        private readonly string tableName = "pay_schedules";

        public PayScheduleDAOLocal()
        {
            executer = new DbExecuter();
            crudHelper = new DbCrudHelper(executer);
        }

        public IList<PaySchedule> allPaySchedules()
        {
            return executer.selectFromTable(tableName, (reader) => mapFromReader(reader));
        }

        public void deletePaySchedule(PaySchedule paySchedule)
        {
            crudHelper.delete(tableName, paySchedule.Id);
        }

        public PaySchedule getPaySchedule(int id)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@id", id }
            };
            return executer.selectFromTable(tableName, "id = @id", parameters, (reader) => mapFromReader(reader)).First();
        }

        public void savePaySchedule(PaySchedule paySchedule)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "name", paySchedule.Name },
                { "type", paySchedule.Type },
                { "pay_rate_type", paySchedule.PayRateType },
                { "tracking_type", paySchedule.TrackingType },
                { "base_period_start", paySchedule.BasePeriodStart.Ticks },
                { "base_period_end", paySchedule.BasePeriodEnd.Ticks },
                { "base_pay_day", paySchedule.BasePayDay.Ticks }
            };
            crudHelper.create(tableName, parameters);
        }

        public void updatePaySchedule(PaySchedule paySchedule)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "name", paySchedule.Name },
                { "type", paySchedule.Type },
                { "pay_rate_type", paySchedule.PayRateType },
                { "tracking_type", paySchedule.TrackingType },
                { "base_period_start", paySchedule.BasePeriodStart.Ticks },
                { "base_period_end", paySchedule.BasePeriodEnd.Ticks },
                { "base_pay_day", paySchedule.BasePayDay.Ticks }
            };
            crudHelper.update(tableName, parameters, paySchedule.Id);
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
