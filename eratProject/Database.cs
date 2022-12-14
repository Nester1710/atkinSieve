using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.IO;
using System.Data.Common;

namespace atkinSieve
{
    class Database
    {
        private string path = @"users.db";
        private string gridName = @"usrs";
        private string dbConnection;
        public Database()
        {
            dbConnection = string.Format("Data Source={0};", path);
            if (!File.Exists(path)){
                File.Create(path).Close();
                Initialize();
            }
        }

        private void Initialize()
        {
            using(var connection = new SQLiteConnection(dbConnection))
            {
                connection.Open();

                SQLiteCommand cmd = new SQLiteCommand($"DROP TABLE IF EXISTS {gridName};" +
                    $"CREATE TABLE {gridName}(" + // создали таблицу users
                    $"id INTEGER PRIMARY KEY AUTOINCREMENT, " + // id пользователя
                    $"username TEXT, " + // имя пользователя
                    $"password TEXT); ", // пароль
                    connection);

                cmd.ExecuteNonQuery();
            }
        }

        public void add(string username, string password)
        {
            try
            {
                using (var connection = new SQLiteConnection(dbConnection))
                {
                    connection.Open();

                    SQLiteCommand cmd = new SQLiteCommand($"INSERT INTO '{gridName}' ('username', 'password') VALUES ('{username}', '{password}');", connection);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }

        public bool valid(string username, string password)
        {
            bool valid = false;

            using (var connection = new SQLiteConnection(dbConnection))
            {
                connection.Open();

                SQLiteCommand cmd = new SQLiteCommand($"SELECT * FROM '{gridName}'; ", connection);
                SQLiteDataReader reader = cmd.ExecuteReader();

                foreach (DbDataRecord rcrd in reader)
                {
                    if (username == rcrd["username"].ToString() && password == rcrd["password"].ToString())
                    {
                        valid = true;
                        break;
                    }
                }
                reader.Close();
            }

            return valid;
        }

        public bool exists(string username)
        {
            bool exists = false;

            using (var connection = new SQLiteConnection(dbConnection))
            {
                connection.Open();

                SQLiteCommand cmd = new SQLiteCommand($"SELECT * FROM '{gridName}'; ", connection);
                SQLiteDataReader reader = cmd.ExecuteReader();

                foreach (DbDataRecord rcrd in reader)
                {
                    if (username == rcrd["username"].ToString())
                    {
                        exists = true;
                        break;
                    }
                }
                reader.Close();
            }

            return exists;
        }
    }
}
