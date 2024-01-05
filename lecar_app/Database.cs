using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;

namespace lecar_app
{
    internal class Database
    {
        SqliteConnection connection;

        public Database()
        {
            connection = new SqliteConnection("Data Source=Y:\\LecarApp.db");
            connection.Open();
            //MessageBox.Show("Unable to save file, try again.");
        }

        ~Database()
        {
            connection.Close();
        }

        public void init()
        {
            SqliteCommand command = new SqliteCommand();
            command.Connection = connection;
            command.CommandText = """
                CREATE TABLE IF NOT EXISTS "illness" (
                  "id" integer PRIMARY KEY AUTOINCREMENT NOT NULL,
                  "name" text,
                  "symptoms" text,
                  "recommendations" text
                );
                CREATE TABLE IF NOT EXISTS "medicaments" (
                  "id" integer PRIMARY KEY AUTOINCREMENT NOT NULL,
                  "name" text,
                  "count" integer DEFAULT(0),
                  "active_substance" text
                );
                CREATE TABLE IF NOT EXISTS "con" (
                  "id_illnes" integer NOT NULL,
                  "id_medicament" integer NOT NULL
                );
                """;
            command.ExecuteNonQuery();
        }
        
        public void getIllnes(int id)
        {

        }
    }
}
