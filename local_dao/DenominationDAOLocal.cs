using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using simple_payroll_desktop.dao;
using simple_payroll_desktop.entities;
using System.Data.SQLite;

namespace simple_payroll_desktop.local_dao
{
    class DenominationDAOLocal : DenominationDAO
    {

        private DbExecuter executer;
        private DbCrudHelper crudHelper;

        private readonly string tableName = "denominations";

        public DenominationDAOLocal()
        {
            executer = new DbExecuter();
            crudHelper = new DbCrudHelper(executer);
        }

        public IList<Denomination> allDenominations()
        {
            return executer.selectFromTable<Denomination>(tableName, (reader) => mapFromReader(reader));
        }

        public void deleteDenomination(Denomination denomination)
        {
            crudHelper.delete(tableName, denomination.Id);
        }

        public Denomination getDenomination(int id)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@id", id }
            };
            return executer.selectFromTable(tableName, "id = @id", parameters, (reader) => mapFromReader(reader)).First();
        }

        public Denomination getDenominationByName(string name)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@name", name }
            };
            IList<Denomination> list = executer.selectFromTable(tableName, "name = @name", parameters, (reader) => mapFromReader(reader));
            if (list.Count == 0)
                return null;
            else
                return list.First();
        }

        public void saveDenomination(Denomination denomination)
        {
            Dictionary<string, Object> parameters = new Dictionary<string, object>
            {
                { "name", denomination.Name }
            };
            crudHelper.create(tableName, parameters);
        }

        public void updateDenomination(Denomination denomination)
        {
            Dictionary<string, object> setValues = new Dictionary<string, object>
            {
                { "name", denomination.Name }
            };
            crudHelper.update(tableName, setValues, denomination.Id);
        }

        private Denomination mapFromReader(SQLiteDataReader reader)
        {
            return new Denomination
            {
                Id = Convert.ToInt32(reader["id"].ToString()),
                Name = reader["name"].ToString(),
            };
        }
    }
}
