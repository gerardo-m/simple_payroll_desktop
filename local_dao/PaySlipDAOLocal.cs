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
    public class PaySlipDAOLocal : PaySlipDAO
    {

        private DbExecuter executer = new DbExecuter();
        private PayrollDAOLocal payrollDAOLocal = new PayrollDAOLocal();


        public IList<PaySlip> getPaySlips(int payrollId)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@payrollId", payrollId);
            IList<PaySlip> paySlips = executer.selectFromTable("pay_slips", mapFromReader);
            return paySlips;
        }

        public void savePaySlip(PaySlip paySlip)
        {
            string query = "INSERT INTO pay_slips(worker_ci, worker_full_name, tracked_work_concept, tracked_work_amount, " +
                           "payroll_total, previously_paid, amount, is_valid, payroll_id) VALUES(@worker_ci, @worker_full_name, @tracked_work_concept, " +
                           "@tracked_work_amount, @payroll_total, @previously_paid, @amount, @is_valid, @payroll_id)";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@worker_ci", paySlip.WorkerCI);
            parameters.Add("@worker_full_name", paySlip.WorkerFullName);
            parameters.Add("@tracked_work_concept", paySlip.TrackedWorkConcept);
            parameters.Add("@tracked_work_amount", paySlip.TrackedWorkAmount);
            parameters.Add("@payroll_total", paySlip.PayrollTotal);
            parameters.Add("@previously_paid", paySlip.PreviouslyPaid);
            parameters.Add("@amount", paySlip.Amount);
            parameters.Add("@is_valid", paySlip.IsValid ? 1:0);
            parameters.Add("@payroll_id", paySlip.Payroll.Id);
            executer.executeQuery(query, parameters);
        }

        public PaySlip mapFromReader(SQLiteDataReader reader)
        {
            return new PaySlip
            {
                Id = Convert.ToInt32(reader["id"].ToString()),
                WorkerCI = reader["worker_ci"].ToString(),
                WorkerFullName = reader["worker_full_name"].ToString(),
                TrackedWorkConcept = reader["tracked_work_concept"].ToString(),
                TrackedWorkAmount = Convert.ToDecimal(reader["tracked_work_amount"].ToString()),
                PayrollTotal = Convert.ToDecimal(reader["payroll_total"].ToString()),
                PreviouslyPaid = Convert.ToDecimal(reader["previously_paid"].ToString()),
                Amount = Convert.ToDecimal(reader["amount"].ToString()),
                IsValid = Convert.ToInt32(reader["is_valid"].ToString()) == 1,
                Payroll = payrollDAOLocal.getPayroll(Convert.ToInt32(reader["payroll_id"].ToString()))
            };
        }
    }
}
