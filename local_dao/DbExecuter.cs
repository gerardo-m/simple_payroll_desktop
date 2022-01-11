using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace simple_payroll_desktop.local_dao
{
    public class DbExecuter
    {

        public void executeQuery(string query, Dictionary<string, Object> parameters)
        {
            using (var connection = DbContext.GetInstance())
            {
                using (var command = new SQLiteCommand(query, connection))
                {
                    foreach (KeyValuePair<string, Object> entry in parameters)
                    {
                        command.Parameters.AddWithValue(entry.Key, entry.Value);
                    }
                    command.ExecuteNonQuery();
                }
            }
        }

        public IList<T> selectFromTable<T>(string tableName, Func<SQLiteDataReader, T> mapFunction)
        {
            List<T> list = new List<T>();
            using (var connection = DbContext.GetInstance())
            {
                string query = buildSelectQuery(tableName, null);
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

        public IList<T> selectFromTable<T>(string tableName, string where, Dictionary<string, object> whereArgs, Func<SQLiteDataReader, T> mapFunction)
        {
            List<T> list = new List<T>();
            using (var connection = DbContext.GetInstance())
            {
                string query = buildSelectQuery(tableName, where);
                using (var command = new SQLiteCommand(query, connection))
                {
                    foreach (KeyValuePair<string, object> entry in whereArgs)
                    {
                        command.Parameters.AddWithValue(entry.Key, entry.Value);
                    }
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

        public int selectCount(string tableName, string where, Dictionary<string, object> whereArgs)
        {
            int count;
            using (var connection = DbContext.GetInstance())
            {
                string query = buildSelectQuery(tableName, where, "COUNT(*)");
                using (var command = new SQLiteCommand(query, connection))
                {
                    foreach (KeyValuePair<string, object> entry in whereArgs)
                    {
                        command.Parameters.AddWithValue(entry.Key, entry.Value);
                    }
                    using (var reader = command.ExecuteReader())
                    {
                        reader.Read();
                        count = reader.GetInt32(0);
                    }
                }
            }
            return count;
        }

        private string buildSelectQuery(string tableName, string where, string columns = "*")
        {
            string query = $"SELECT {columns} FROM {tableName}";
            if (!string.IsNullOrWhiteSpace(where))
            {
                query = $"{query} where {where}";
            }
            return query;
        }
    }
}
