
namespace atkinSieve
{
    partial class LoginForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.introLabel = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.createUserButton = new System.Windows.Forms.Button();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameMessageLabel = new System.Windows.Forms.Label();
            this.passwordMessageShow = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // introLabel
            // 
            this.introLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.introLabel.AutoSize = true;
            this.introLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.introLabel.Location = new System.Drawing.Point(285, 181);
            this.introLabel.Name = "introLabel";
            this.introLabel.Size = new System.Drawing.Size(183, 37);
            this.introLabel.TabIndex = 0;
            this.introLabel.Text = "Авторизация";
            // 
            // loginButton
            // 
            this.loginButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginButton.Enabled = false;
            this.loginButton.Location = new System.Drawing.Point(258, 349);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(243, 38);
            this.loginButton.TabIndex = 1;
            this.loginButton.Text = "Войти";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.usernameTextBox.Location = new System.Drawing.Point(258, 258);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(243, 25);
            this.usernameTextBox.TabIndex = 2;
            this.usernameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.usernameTextBox.TextChanged += new System.EventHandler(this.usernameTextBox_TextChanged);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordTextBox.Location = new System.Drawing.Point(258, 306);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(243, 25);
            this.passwordTextBox.TabIndex = 3;
            this.passwordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.passwordTextBox.UseSystemPasswordChar = true;
            this.passwordTextBox.TextChanged += new System.EventHandler(this.passwordTextBox_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.passwordMessageShow);
            this.groupBox1.Controls.Add(this.usernameMessageLabel);
            this.groupBox1.Controls.Add(this.passwordLabel);
            this.groupBox1.Controls.Add(this.usernameLabel);
            this.groupBox1.Controls.Add(this.createUserButton);
            this.groupBox1.Controls.Add(this.introLabel);
            this.groupBox1.Controls.Add(this.loginButton);
            this.groupBox1.Controls.Add(this.passwordTextBox);
            this.groupBox1.Controls.Add(this.usernameTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(760, 537);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // createUserButton
            // 
            this.createUserButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.createUserButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createUserButton.Location = new System.Drawing.Point(258, 393);
            this.createUserButton.Name = "createUserButton";
            this.createUserButton.Size = new System.Drawing.Size(243, 34);
            this.createUserButton.TabIndex = 5;
            this.createUserButton.Text = "Новый пользователь";
            this.createUserButton.UseVisualStyleBackColor = true;
            this.createUserButton.Click += new System.EventHandler(this.createUserButton_Click);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usernameLabel.Location = new System.Drawing.Point(316, 238);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(125, 17);
            this.usernameLabel.TabIndex = 6;
            this.usernameLabel.Text = "имя пользователя";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordLabel.Location = new System.Drawing.Point(352, 286);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(51, 17);
            this.passwordLabel.TabIndex = 7;
            this.passwordLabel.Text = "пароль";
            // 
            // usernameMessageLabel
            // 
            this.usernameMessageLabel.AutoSize = true;
            this.usernameMessageLabel.ForeColor = System.Drawing.Color.Red;
            this.usernameMessageLabel.Location = new System.Drawing.Point(507, 261);
            this.usernameMessageLabel.Name = "usernameMessageLabel";
            this.usernameMessageLabel.Size = new System.Drawing.Size(143, 17);
            this.usernameMessageLabel.TabIndex = 8;
            this.usernameMessageLabel.Text = "Минимум 8 символов!";
            this.usernameMessageLabel.Visible = false;
            // 
            // passwordMessageShow
            // 
            this.passwordMessageShow.AutoSize = true;
            this.passwordMessageShow.ForeColor = System.Drawing.Color.Red;
            this.passwordMessageShow.Location = new System.Drawing.Point(507, 309);
            this.passwordMessageShow.Name = "passwordMessageShow";
            this.passwordMessageShow.Size = new System.Drawing.Size(143, 17);
            this.passwordMessageShow.TabIndex = 9;
            this.passwordMessageShow.Text = "Минимум 8 символов!";
            this.passwordMessageShow.Visible = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "LoginForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вход в приложение";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label introLabel;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button createUserButton;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordMessageShow;
        private System.Windows.Forms.Label usernameMessageLabel;
    }
}

