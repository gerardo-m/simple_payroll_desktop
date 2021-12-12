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
    public class WorkerDAOLocal : WorkerDAO
    {

        private PayScheduleDAOLocal payScheduleDAO = new PayScheduleDAOLocal();
        private DenominationDAOLocal denominationDAO = new DenominationDAOLocal();
        private DbExecuter executer = new DbExecuter();
        public IList<Worker> allWorkers()
        {
            return executer.selectFromTable<Worker>("workers", (reader) => mapFromReader(reader));
        }

        public void deleteWorker(Worker worker)
        {
            throw new NotImplementedException();
        }

        public void saveWorker(Worker worker)
        {
            string query = "INSERT INTO workers(first_name, last_name_1, last_name_2, ci, pay_rate," +
                                       "pay_rate_type, pay_schedule_id, denomination_id) values (" +
                                       "@first_name, @last_name_1, @last_name_2, @ci, @pay_rate," +
                                       "@pay_rate_type, @pay_schedule_id, @denomination_id)";
            Dictionary<string, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@first_name", worker.FirstName);
            parameters.Add("@last_name_1", worker.LastName1);
            parameters.Add("@last_name_2", worker.LastName2);
            parameters.Add("@ci", worker.CI);
            parameters.Add("@pay_rate", worker.PayRate);
            parameters.Add("@pay_rate_type", worker.PayRateType);
            parameters.Add("@pay_schedule_id", worker.PaySchedule.Id);
            parameters.Add("@denomination_id", worker.Denomination.Id);
            executer.executeQuery(query, parameters);
        }

        public void updateWorker(Worker worker)
        {
            throw new NotImplementedException();
        }

        private Worker mapFromReader(SQLiteDataReader reader)
        {
            return new Worker
            {
                Id = Convert.ToInt32(reader["id"].ToString()),
                FirstName = reader["first_name"].ToString(),
                LastName1 = reader["last_name_1"].ToString(),
                LastName2 = reader["last_name_2"].ToString(),
                CI = reader["ci"].ToString(),
                PayRate = Convert.ToDecimal(reader["pay_rate"].ToString()),
                PayRateType = (PayRateType)Convert.ToInt32(reader["pay_rate_type"].ToString()),
                PaySchedule = payScheduleDAO.getPaySchedule(Convert.ToInt32(reader["pay_schedule_id"].ToString())),
                Denomination = denominationDAO.getDenomination(Convert.ToInt32(reader["denomination_id"].ToString()))
            };
        }
    }
}
