using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace atkinSieve
{
    class User
    {
        private string username; // имя пользователя
        private string password; // пароль
        private Database db; // база данныех
        public User(string username, string password)
        {
            this.username = username;
            this.password = Hash(password);
            db = new Database();
        }

        /// <summary>
        /// Хэширует заданную строку
        /// </summary>
        /// <param name="line">строка для хеша</param>
        /// <returns></returns>
        private string Hash(string line)
        {
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                var hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(line));
                var sb = new StringBuilder(hash.Length * 2);
                foreach (byte b in hash)
                {
                    sb.Append(b.ToString("x2"));
                }
                return sb.ToString();
            }
        }

        /// <summary>
        /// Проверяет занятость имени пользователя
        /// </summary>
        /// <returns></returns>
        public bool exists()
        {
            return db.exists(username);
        }

        /// <summary>
        /// Проверяет существование пользователя
        /// </summary>
        /// <returns></returns>
        public bool valid()
        {
            return db.valid(username, password);
        }

        /// <summary>
        /// Добавляет нового пользователя
        /// </summary>
        /// <returns></returns>
        public bool add()
        {
            try
            {
                db.add(username, password);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Ошибка добавления нового пользователя", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
    }
}
