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
    public class PayrollDAOLocal : PayrollDAO
    {

        private PayScheduleDAOLocal payScheduleDAO = new PayScheduleDAOLocal();
        private WorkerDAOLocal workerDAOLocal = new WorkerDAOLocal();

        private DbExecuter executer;
        private DbCrudHelper crudHelper;

        private readonly string tableName = "payrolls";

        public PayrollDAOLocal()
        {
            executer = new DbExecuter();
            crudHelper = new DbCrudHelper(executer);
        }

        public Payroll getPayroll(int payrollId)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@id", payrollId }
            };
            IList<Payroll> list = executer.selectFromTable(tableName, "id = @id", parameters, (reader) => mapFromReader(reader));
            if (list.Count == 0)
                return null;
            else
                return list.First();
        }

        public Payroll getPayrollByPeriod(int workerId, PayPeriod period)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@period_start", period.PeriodStart.Ticks },
                { "@period_end", period.PeriodEnd.Ticks },
                { "@worker_id", workerId }
            };
            IList<Payroll> list = executer.selectFromTable(tableName, "period_start = @period_start and period_end = @period_end and worker_id = @worker_id", parameters, (reader) => mapFromReader(reader));
            if (list.Count == 0)
                return null;
            else
                return list.First();
        }

        public void savePayroll(Payroll payroll)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "period_start", payroll.PeriodStart.Ticks },
                { "period_end", payroll.PeriodEnd.Ticks },
                { "date", payroll.Date.Ticks },
                { "pay_rate", payroll.PayRate },
                { "pay_rate_type", payroll.PayRateType },
                { "tracked_time", payroll.TrackedTime },
                { "tracked_amount", payroll.TrackedAmount },
                { "additionals_amount", payroll.AdditionalsAmount },
                { "balance_due", payroll.BalanceDue },
                { "pay_schedule_id", payroll.PaySchedule.Id },
                { "worker_id", payroll.Worker.Id },
                { "pay_schedule_type", payroll.PayScheduleType },
                { "status", payroll.Status }
            };
            crudHelper.create(tableName, parameters);
        }

        public void updatePayroll(Payroll payroll)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "period_start", payroll.PeriodStart.Ticks },
                { "period_end", payroll.PeriodEnd.Ticks },
                { "date", payroll.Date.Ticks },
                { "pay_rate", payroll.PayRate },
                { "pay_rate_type", payroll.PayRateType },
                { "tracked_time", payroll.TrackedTime },
                { "tracked_amount", payroll.TrackedAmount },
                { "additionals_amount", payroll.AdditionalsAmount },
                { "balance_due", payroll.BalanceDue },
                { "pay_schedule_id", payroll.PaySchedule.Id },
                { "worker_id", payroll.Worker.Id },
                { "pay_schedule_type", payroll.PayScheduleType },
                { "status", payroll.Status }
            };
            crudHelper.update(tableName, parameters, payroll.Id);
        }

        private Payroll mapFromReader(SQLiteDataReader reader)
        {
            return new Payroll
            {
                Id = Convert.ToInt32(reader["id"].ToString()),
                PeriodStart = new DateTime(Convert.ToInt64(reader["period_start"].ToString())),
                PeriodEnd = new DateTime(Convert.ToInt64(reader["period_end"].ToString())),
                Date = new DateTime(Convert.ToInt64(reader["date"].ToString())),
                PayRate = Convert.ToDecimal(reader["pay_rate"].ToString()),
                PayRateType = (PayRateType)Convert.ToInt32(reader["pay_rate_type"].ToString()),
                TrackedTime = Convert.ToDecimal(reader["tracked_time"].ToString()),
                TrackedAmount = Convert.ToDecimal(reader["tracked_amount"].ToString()),
                AdditionalsAmount = Convert.ToDecimal(reader["additionals_amount"].ToString()),
                BalanceDue = Convert.ToDecimal(reader["balance_due"].ToString()),
                PaySchedule = payScheduleDAO.getPaySchedule(Convert.ToInt32(reader["pay_schedule_id"].ToString())),
                Worker = workerDAOLocal.getWorker(Convert.ToInt32(reader["worker_id"].ToString())),
                PayScheduleType = (PayScheduleType)Convert.ToInt32(reader["pay_schedule_type"].ToString()),
                Status = (PayrollStatus)Convert.ToInt32(reader["status"].ToString()),
                // TODO load these
                Additionals = new List<Additional>(),
                TrackingEntries = new List<TrackingEntry>()
            };
        }

        public int getPayrollCount(int workerId)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "worker_id", workerId }
            };
            return crudHelper.readCount(tableName, parameters);
        }

        public int getClosedPayrollCount(int workerId)
        {
            int count = 0;
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "worker_id", workerId },
                { "status", PayrollStatus.Closed }
            };
            count = crudHelper.readCount(tableName, parameters);
            parameters = new Dictionary<string, object>
            {
                { "worker_id", workerId },
                { "status", PayrollStatus.ClosedAndPaid }
            };
            count += crudHelper.readCount(tableName, parameters);
            return count;
        }

        public IList<Payroll> getPayrollsByWorker(int workerId)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@worker_id", workerId }
            };
            return executer.selectFromTable(tableName, "worker_id = @worker_id", parameters, (reader) => mapFromReader(reader));
        }

        public void deletePayroll(Payroll payroll)
        {
            crudHelper.delete(tableName, payroll.Id);
        }
    }
}
