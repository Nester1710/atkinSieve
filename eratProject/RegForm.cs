using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace atkinSieve
{
    public partial class RegForm : Form
    {
        User user;

        public RegForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            createUser(username, password);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            confrimMessageLabel.Visible = (passwordTextBox.Text != textBox1.Text);
            createButton.Enabled = (usernameTextBox.Text.Length >= 8) && (passwordTextBox.Text.Length >= 8) && (passwordTextBox.Text == textBox1.Text);
        }

        private void loginButton_Click_1(object sender, EventArgs e)
        {
            showForm(new LoginForm());
        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {
            usernameMessageLabel.Visible = (usernameTextBox.Text.Length < 8);
            createButton.Enabled = (usernameTextBox.Text.Length >= 8) && (passwordTextBox.Text.Length >= 8) && (passwordTextBox.Text == textBox1.Text);
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            passwordMessageShow.Visible = (passwordTextBox.Text.Length < 8);
            confrimMessageLabel.Visible = (passwordTextBox.Text != textBox1.Text);
            createButton.Enabled = (usernameTextBox.Text.Length >= 8) && (passwordTextBox.Text.Length >= 8) && (passwordTextBox.Text == textBox1.Text);
        }

        /// <summary>
        /// Показывает заданную форму
        /// </summary>
        /// <param name="form"></param>
        private void showForm(Form form)
        {
            this.Hide();
            form.FormClosed += (s, args) => this.Close();
            form.Show();
        }

        private void createUser(string username, string password)
        {
            foreach (var symb in password)
            {
                if (!((symb >= '0' && symb <= '9') || (symb >= 'a' && symb <= 'z') || (symb >= 'A' && symb <= 'Z') || (symb == '!' || symb == '_' || symb == '\\' || symb == '*')))
                {
                    MessageBox.Show("Пользователь может содержать только цифры, латинские буквы и специальные символы (! _ \\ *)", "Неверное заполнение пароля", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

            }
            user = new User(username, password);

            if (user.exists())
            {
                MessageBox.Show("Пользователь с таким именем уже существует!", "Ошибка регистрации", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (user.add())
                {
                    MessageBox.Show("Регистрация прошла успешно!", "Добро пожаловать", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    showForm(new MainForm());
                }
            }
        }
    }
}
