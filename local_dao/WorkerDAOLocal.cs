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
        private DbExecuter executer;
        private DbCrudHelper crudHelper;

        private readonly string tableName = "workers";

        public WorkerDAOLocal()
        {
            executer = new DbExecuter();
            crudHelper = new DbCrudHelper(executer);
        }

        public IList<Worker> allWorkers()
        {
            return executer.selectFromTable(tableName, (reader) => mapFromReader(reader));
        }

        public int workersWithDenominationCount(int denominationId)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "denomination_id", denominationId }
            };
            return crudHelper.readCount(tableName, parameters);
        }

        public void deleteWorker(Worker worker)
        {
            crudHelper.delete(tableName, worker.Id);
        }

        public Worker getWorker(int id)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@id", id }
            };
            return executer.selectFromTable<Worker>("workers", "id = @id", parameters, (reader) => mapFromReader(reader)).First();
        }

        public void saveWorker(Worker worker)
        {
            Dictionary<string, Object> parameters = new Dictionary<string, object>
            {
                { "first_name", worker.FirstName },
                { "last_name_1", worker.LastName1 },
                { "last_name_2", worker.LastName2 },
                { "ci", worker.CI },
                { "pay_rate", worker.PayRate },
                { "pay_rate_type", worker.PayRateType },
                { "pay_schedule_id", worker.PaySchedule.Id },
                { "denomination_id", worker.Denomination.Id }
            };
            crudHelper.create(tableName, parameters);
        }

        public void updateWorker(Worker worker)
        {
            Dictionary<string, Object> valuesToUpdate = new Dictionary<string, object>
            {
                { "first_name", worker.FirstName },
                { "last_name_1", worker.LastName1 },
                { "last_name_2", worker.LastName2 },
                { "ci", worker.CI },
                { "pay_rate", worker.PayRate },
                { "pay_rate_type", worker.PayRateType },
                { "pay_schedule_id", worker.PaySchedule.Id },
                { "denomination_id", worker.Denomination.Id }
            };
            crudHelper.update(tableName, valuesToUpdate, worker.Id);
        }

        public IList<Worker> workersWithPaySchedule(int payScheduleId)
        {
            string where = "pay_schedule_id = @pay_schedule_id";
            Dictionary<string, object> whereArgs = new Dictionary<string, object>
            {
                { "@pay_schedule_id", payScheduleId }
            };
            return executer.selectFromTable<Worker>("workers", where, whereArgs, (reader) => mapFromReader(reader));
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
