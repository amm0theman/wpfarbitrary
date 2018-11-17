using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Text;

namespace ClassLibrary1
{
    public class databaseSQLite
    {
        private SQLiteConnection connection;

        public databaseSQLite()
        {
            string cs = "URI=file:test.db";

            connection = new SQLiteConnection(cs);
            connection.Open();

            WriteData();
        }

        public void WriteData()
        {
            SQLiteCommand insertSQL = new SQLiteCommand("INSERT INTO test_table (test_column) VALUES ('test');", connection);
            insertSQL.ExecuteNonQuery();
        }

        public string SelectData()
        {
            SQLiteCommand selectSQL = new SQLiteCommand("SELECT * FROM test_table;", connection);
            var a = selectSQL.ExecuteReader();
            while (a.Read())
            {
                var b = a.GetString(0);
                return b;
            }
            return "";
        }
    }
}
