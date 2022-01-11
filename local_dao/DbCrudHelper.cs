using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_payroll_desktop.local_dao
{
    public class DbCrudHelper
    {

        private DbExecuter executer;

        public DbCrudHelper(DbExecuter executer)
        {
            this.executer = executer;
        }

        public void create(string table, Dictionary<string, object> parameters)
        {
            string columns = String.Join(", ", parameters.Keys);
            string values = "@" + String.Join(", @", parameters.Keys);
            string query = $"INSERT INTO {table}({columns}) values ({values})";
            executer.executeQuery(query, parameters);
        }

        public int readCount(string tableName)
        {
            return executer.selectCount(tableName, "", null);
        }

        public int readCount(string tableName, Dictionary<string, object> whereValues)
        {
            string[] whereValuesString = getColumnEqualValueArray(whereValues.Keys);
            string where = String.Join(" AND ", whereValuesString);

            return executer.selectCount(tableName, where, whereValues);
        }

        /// <summary>
        /// Updates the columns in the table provided in the setValues dictionary using the 
        /// whereValues in the where statements join by an AND operator.
        /// </summary>
        /// <param name="table"></param>
        /// <param name="setValues"></param>
        /// <param name="whereValues"></param>
        public void update(string table, Dictionary<string, object> setValues, Dictionary<string, object> whereValues)
        {
            string[] setValuesString = getColumnEqualValueArray(setValues.Keys); 
            string set = String.Join(", ", setValuesString);

            string[] whereValuesString = getColumnEqualValueArray(whereValues.Keys);
            string where = String.Join(" AND ", whereValuesString);

            string query = $"UPDATE {table} set {set} where {where}";
            Dictionary<string, object> parameters = (Dictionary<string, object>)setValues.Concat(whereValues);
            executer.executeQuery(query, parameters);
        }

        /// <summary>
        /// Updates the columns in the table provided in the setValues dictionary using the id also provided
        /// as a parameter
        /// </summary>
        /// <param name="table"></param>
        /// <param name="setValues"></param>
        /// <param name="id"></param>
        public void update(string table, Dictionary<string, object> setValues, int id)
        {
            string[] setValuesString = getColumnEqualValueArray(setValues.Keys);
            string set = String.Join(", ", setValuesString);

            string query = $"UPDATE {table} set {set} where id = @id";
            setValues.Add("id", id);
            executer.executeQuery(query, setValues);
        }

        /// <summary>
        /// Deletes the record from the table with the id provided
        /// </summary>
        /// <param name="table"></param>
        /// <param name="id"></param>
        public void delete(string table, int id)
        {
            string query = $"DELETE FROM {table} where id = @id";
            Dictionary<string, Object> parameters = new Dictionary<string, object>
            {
                { "@id", id }
            };
            executer.executeQuery(query, parameters);
        }

        /// <summary>
        /// Deletes the record from the table using the whereValues in the where statement
        /// joined by an AND operator
        /// </summary>
        /// <param name="table"></param>
        /// <param name="whereValues"></param>
        public void delete(string table, Dictionary<string, object> whereValues)
        {
            string[] whereValuesString = getColumnEqualValueArray(whereValues.Keys);
            string where = String.Join(" AND ", whereValuesString);

            string query = $"DELETE FROM {table} where {where}";
            executer.executeQuery(query, whereValues);
        }

        private string[] getColumnEqualValueArray(IEnumerable<string> columns)
        {
            string[] columnsString = new string[columns.Count()];
            string column;
            for (int i = 0; i < columns.Count(); i++)
            {
                column = columns.ElementAt(i);
                columnsString[i] = $"{column} = @{column}";
            }
            return columnsString;
        }
    }
}
