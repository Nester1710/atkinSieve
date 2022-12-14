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
    public partial class LoginForm : Form
    {
        User user;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void createUserButton_Click(object sender, EventArgs e)
        {
            showForm(new RegForm());
        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {
            usernameMessageLabel.Visible = (usernameTextBox.Text.Length < 8);
            loginButton.Enabled = (usernameTextBox.Text.Length >= 8) && (passwordTextBox.Text.Length >= 8);
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            passwordMessageShow.Visible = (passwordTextBox.Text.Length < 8);
            loginButton.Enabled = (usernameTextBox.Text.Length >= 8) && (passwordTextBox.Text.Length >= 8);
        }

        private void showForm(Form form)
        {
            this.Hide();
            form.FormClosed += (s, args) => this.Close(); // событие закрытия формы
            form.Show();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            login(username, password);
        }

        private void login(string username, string password)
        {
            user = new User(username, password);
            if (user.valid())
            {
                showForm(new MainForm());
            }
            else
            {
                MessageBox.Show("Неверное имя пользователя или пароль.\nПовторите попытку или создайте новый аккаунт", "Ошибка авторизации", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
