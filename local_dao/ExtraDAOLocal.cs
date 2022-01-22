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
    public class ExtraDAOLocal : ExtraDAO
    {

        private DbExecuter executer;
        private DbCrudHelper crudHelper;

        private readonly string tableName = "extras";

        public ExtraDAOLocal()
        {
            executer = new DbExecuter();
            crudHelper = new DbCrudHelper(executer);
        }

        public IList<Extra> getExtras(int payrollId)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@payroll_id", payrollId }
            };
            return executer.selectFromTable(tableName, "payroll_id = @payroll_id", parameters, (reader) => mapFromReader(reader));
        }

        public void saveExtra(Extra extra)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "concept", extra.Concept },
                { "amount", extra.Amount },
                { "type", extra.Type },
                { "payroll_id", extra.Payroll.Id }
            };
            crudHelper.create(tableName, parameters);
        }

        public void updateExtra(Extra extra)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "concept", extra.Concept },
                { "amount", extra.Amount },
                { "type", extra.Type },
                { "payroll_id", extra.Payroll.Id }
            };
            crudHelper.update(tableName, parameters, extra.Id);
        }

        private Extra mapFromReader(SQLiteDataReader reader)
        {
            return new Extra
            {
                Id = Convert.ToInt32(reader["id"].ToString()),
                Concept = reader["concept"].ToString(),
                Amount = Convert.ToDecimal(reader["amount"].ToString()),
                Type = (ExtraType)Convert.ToInt32(reader["type"].ToString()),
                Payroll = null
            };
        }
    }
}
