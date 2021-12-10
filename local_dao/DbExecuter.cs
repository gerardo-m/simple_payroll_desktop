using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace simple_payroll_desktop.local_dao
{
    class DbExecuter
    {

        public void executeQuery(string query, Dictionary<string, Object> parameters)
        {
            using (var connection = DbContext.GetInstance())
            {
                using (var command = new SQLiteCommand(query, connection))
                {
                    parameters.ForEach<KeyValuePair<string, Object>>((pair) => command.Parameters.AddWithValue(pair.Key, pair.Value));
                    command.ExecuteNonQuery();
                }
            }
        }

        public IList<T> selectFromTable<T>(string tableName, Func<SQLiteDataReader, T> mapFunction)
        {
            List<T> list = new List<T>();
            using (var connection = DbContext.GetInstance())
            {
                String query = $"SELECT * FROM {tableName}";
                using (var command = new SQLiteCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(mapFunction(reader));
                        }
                    }
                }
            }
            return list;
        }
    }
}
