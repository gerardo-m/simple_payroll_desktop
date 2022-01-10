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

        private DbExecuter executer = new DbExecuter();
        private PayScheduleDAOLocal payScheduleDAO = new PayScheduleDAOLocal();
        private WorkerDAOLocal workerDAOLocal = new WorkerDAOLocal();

        public Payroll getPayroll(int payrollId)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@id", payrollId);
            IList<Payroll> list = executer.selectFromTable("payrolls", "id = @id", parameters, (reader) => mapFromReader(reader));
            if (list.Count == 0)
                return null;
            else
                return list.First();
        }

        public Payroll getPayrollByPeriod(int workerId, PayPeriod period)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@period_start", period.PeriodStart.Ticks);
            parameters.Add("@period_end", period.PeriodEnd.Ticks);
            parameters.Add("@worker_id", workerId);
            IList<Payroll> list = executer.selectFromTable<Payroll>("payrolls", "period_start = @period_start and period_end = @period_end and worker_id = @worker_id", parameters, (reader) => mapFromReader(reader));
            if (list.Count == 0)
                return null;
            else
                return list.First();
        }

        public void savePayroll(Payroll payroll)
        {
            string query = "INSERT INTO payrolls(period_start, period_end, date, pay_rate, pay_rate_type," +
                " tracked_time, tracked_amount, additionals_amount, balance_due, pay_schedule_id, worker_id, " +
                " pay_schedule_type, status) values (@period_start, @period_end, @date, @pay_rate, @pay_rate_type," +
                " @tracked_time, @tracked_amount, @additionals_amount, @balance_due, @pay_schedule_id, @worker_id, " +
                " @pay_schedule_type, @status)";
            Dictionary<string, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@period_start", payroll.PeriodStart.Ticks);
            parameters.Add("@period_end", payroll.PeriodEnd.Ticks);
            parameters.Add("@date", payroll.Date.Ticks);
            parameters.Add("@pay_rate", payroll.PayRate);
            parameters.Add("@pay_rate_type", payroll.PayRateType);
            parameters.Add("@tracked_time", payroll.TrackedTime);
            parameters.Add("@tracked_amount", payroll.TrackedAmount);
            parameters.Add("@additionals_amount", payroll.AdditionalsAmount);
            parameters.Add("@balance_due", payroll.BalanceDue);
            parameters.Add("@pay_schedule_id", payroll.PaySchedule.Id);
            parameters.Add("@worker_id", payroll.Worker.Id);
            parameters.Add("@pay_schedule_type", payroll.PayScheduleType);
            parameters.Add("@status", payroll.Status);
            executer.executeQuery(query, parameters);
        }

        public void updatePayroll(Payroll payroll)
        {
            string query = "UPDATE payrolls set period_start = @period_start, period_end = @period_end, date = @date," +
                " pay_rate = @pay_rate, pay_rate_type = @pay_rate_type, tracked_time = @tracked_time, tracked_amount = @tracked_amount," +
                " additionals_amount = @additionals_amount, balance_due = @balance_due, pay_schedule_id = @pay_schedule_id," +
                " worker_id = @worker_id, pay_schedule_type = @pay_schedule_type, status = @status where id = @id" +
                "";
            Dictionary<string, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@id", payroll.Id);
            parameters.Add("@period_start", payroll.PeriodStart.Ticks);
            parameters.Add("@period_end", payroll.PeriodEnd.Ticks);
            parameters.Add("@date", payroll.Date.Ticks);
            parameters.Add("@pay_rate", payroll.PayRate);
            parameters.Add("@pay_rate_type", payroll.PayRateType);
            parameters.Add("@tracked_time", payroll.TrackedTime);
            parameters.Add("@tracked_amount", payroll.TrackedAmount);
            parameters.Add("@additionals_amount", payroll.AdditionalsAmount);
            parameters.Add("@balance_due", payroll.BalanceDue);
            parameters.Add("@pay_schedule_id", payroll.PaySchedule.Id);
            parameters.Add("@worker_id", payroll.Worker.Id);
            parameters.Add("@pay_schedule_type", payroll.PayScheduleType);
            parameters.Add("@status", payroll.Status);
            executer.executeQuery(query, parameters);
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
    }
}
