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
        private const string DBStartingFileName = "startDatabase.sql";
        private static bool IsDbRecentlyCreated = false;
        private static string DBFilePath;

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
                string.Format("Data Source={0};Version=3;", DBFilePath)
            );
            db.Open();
            return db;
        }

        private static void createDbFile()
        {
            string myDocumentsFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string dbPath = Path.Combine(myDocumentsFolder, "Simple Payroll Desktop");
            if (!Directory.Exists(dbPath))
                Directory.CreateDirectory(dbPath);
            DBFilePath = Path.Combine(dbPath, DBName);
            if (!File.Exists(DBFilePath))
            {
                SQLiteConnection.CreateFile(DBFilePath);
                IsDbRecentlyCreated = true;
            }
        }

        private static void createTables(SQLiteConnection context)
        {
            string query = "";
            using (var reader = new StreamReader(Path.GetFullPath(DBStartingFileName)))
            {
                string line = "";
                while ((line = reader.ReadLine()) != null)
                    query += line + "\n";
            }
            var command = new SQLiteCommand(query, context);
            command.ExecuteNonQuery();
        }
    }
}
