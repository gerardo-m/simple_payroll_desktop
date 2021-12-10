using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;

namespace simple_payroll_desktop.local_dao
{
    class DbContext
    {

        private const string DBName = "database.sqlite";
        private static bool IsDbRecentlyCreated = false;

        public static void up()
        {
            createDbFile();
            using (var context = GetInstance())
            {
                if (IsDbRecentlyCreated)
                {
                    createTables(context);
                }
                    
            }
        }

        public static SQLiteConnection GetInstance()
        {
            var db = new SQLiteConnection(
                string.Format("Data Source={0};Version=3;", DBName)
            );
            db.Open();
            return db;
        }

        private static void createDbFile()
        {
            if (!File.Exists(Path.GetFullPath(DBName)))
            {
                SQLiteConnection.CreateFile(DBName);
                IsDbRecentlyCreated = true;
            }
        }

        private static void createTables(SQLiteConnection context)
        {
            String query = "CREATE TABLE Denominations(id INTEGER PRIMARY KEY, name TEXT);";
            var command = new SQLiteCommand(query, context);
            command.ExecuteNonQuery();
        }
    }
}
