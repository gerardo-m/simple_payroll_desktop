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

        private DbExecuter executer = new DbExecuter();

        public IList<Denomination> allDenominations()
        {
            return executer.selectFromTable<Denomination>("Denominations", (reader) => mapFromReader(reader));
            /*List<Denomination> list = new List<Denomination>();
            using (var connection = DbContext.GetInstance())
            {
                String query = "SELECT * FROM Denominations";
                using (var command = new SQLiteCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new Denomination
                            {
                                Id = Convert.ToInt32(reader["id"].ToString()),
                                Name = reader["name"].ToString(),
                            });
                        }
                    }
                }
            }
            return list;*/
        }

        public void deleteDenomination(Denomination denomination)
        {
            string query = "DELETE FROM Denominations where id = @id";
            Dictionary<string, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@id", denomination.Id);
            executer.executeQuery(query, parameters);
        }

        public void saveDenomination(Denomination denomination)
        {
            string query = "INSERT INTO Denominations(name) values (@name)";
            Dictionary<string, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@name", denomination.Name);
            executer.executeQuery(query, parameters);
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
