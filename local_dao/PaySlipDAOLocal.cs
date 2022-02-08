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

        private PayrollDAOLocal payrollDAOLocal = new PayrollDAOLocal();

        private DbExecuter executer;
        private DbCrudHelper crudHelper;

        private readonly string tableName = "pay_slips";

        public PaySlipDAOLocal()
        {
            executer = new DbExecuter();
            crudHelper = new DbCrudHelper(executer);
        }

        public IList<PaySlip> getPaySlips(int payrollId)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@payrollId", payrollId }
            };
            IList<PaySlip> paySlips = executer.selectFromTable(tableName, "payroll_id = ?", parameters, mapFromReader);
            return paySlips;
        }

        public void savePaySlip(PaySlip paySlip)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "worker_ci", paySlip.WorkerCI },
                { "worker_full_name", paySlip.WorkerFullName },
                { "tracked_work_concept", paySlip.TrackedWorkConcept },
                { "tracked_work_amount", paySlip.TrackedWorkAmount },
                { "payroll_total", paySlip.PayrollTotal },
                { "previously_paid", paySlip.PreviouslyPaid },
                { "amount", paySlip.Amount },
                { "is_valid", paySlip.IsValid ? 1 : 0 },
                { "payroll_id", paySlip.Payroll.Id }
            };
            crudHelper.create(tableName, parameters);
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
