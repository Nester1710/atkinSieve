
namespace atkinSieve
{
    partial class RegForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.introLabel = new System.Windows.Forms.Label();
            this.createButton = new System.Windows.Forms.Button();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.confirmPasswordLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.passwordMessageShow = new System.Windows.Forms.Label();
            this.usernameMessageLabel = new System.Windows.Forms.Label();
            this.confrimMessageLabel = new System.Windows.Forms.Label();
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
            this.introLabel.Size = new System.Drawing.Size(175, 37);
            this.introLabel.TabIndex = 0;
            this.introLabel.Text = "Регистрация";
            // 
            // createButton
            // 
            this.createButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.createButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createButton.Enabled = false;
            this.createButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createButton.Location = new System.Drawing.Point(258, 400);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(243, 38);
            this.createButton.TabIndex = 1;
            this.createButton.Text = "Создать нового пользователя";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordTextBox.Location = new System.Drawing.Point(258, 309);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(243, 25);
            this.passwordTextBox.TabIndex = 3;
            this.passwordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.passwordTextBox.UseSystemPasswordChar = true;
            this.passwordTextBox.TextChanged += new System.EventHandler(this.passwordTextBox_TextChanged);
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.usernameTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usernameTextBox.Location = new System.Drawing.Point(258, 258);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(243, 25);
            this.usernameTextBox.TabIndex = 2;
            this.usernameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.usernameTextBox.TextChanged += new System.EventHandler(this.usernameTextBox_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.confrimMessageLabel);
            this.groupBox1.Controls.Add(this.passwordMessageShow);
            this.groupBox1.Controls.Add(this.usernameMessageLabel);
            this.groupBox1.Controls.Add(this.confirmPasswordLabel);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.passwordLabel);
            this.groupBox1.Controls.Add(this.usernameLabel);
            this.groupBox1.Controls.Add(this.loginButton);
            this.groupBox1.Controls.Add(this.introLabel);
            this.groupBox1.Controls.Add(this.createButton);
            this.groupBox1.Controls.Add(this.passwordTextBox);
            this.groupBox1.Controls.Add(this.usernameTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(760, 537);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // passwordLabel
            // 
            this.passwordLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordLabel.Location = new System.Drawing.Point(9, 289);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(745, 17);
            this.passwordLabel.TabIndex = 7;
            this.passwordLabel.Text = "пароль";
            this.passwordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // usernameLabel
            // 
            this.usernameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usernameLabel.Location = new System.Drawing.Point(6, 238);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(748, 17);
            this.usernameLabel.TabIndex = 6;
            this.usernameLabel.Text = "имя пользователя";
            this.usernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loginButton
            // 
            this.loginButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginButton.Location = new System.Drawing.Point(258, 444);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(243, 34);
            this.loginButton.TabIndex = 5;
            this.loginButton.Text = "У меня есть аккаунт";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click_1);
            // 
            // confirmPasswordLabel
            // 
            this.confirmPasswordLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.confirmPasswordLabel.Location = new System.Drawing.Point(12, 337);
            this.confirmPasswordLabel.Name = "confirmPasswordLabel";
            this.confirmPasswordLabel.Size = new System.Drawing.Size(742, 17);
            this.confirmPasswordLabel.TabIndex = 9;
            this.confirmPasswordLabel.Text = "подтверждение пароля";
            this.confirmPasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(258, 357);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(243, 25);
            this.textBox1.TabIndex = 8;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.UseSystemPasswordChar = true;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // passwordMessageShow
            // 
            this.passwordMessageShow.AutoSize = true;
            this.passwordMessageShow.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordMessageShow.ForeColor = System.Drawing.Color.Red;
            this.passwordMessageShow.Location = new System.Drawing.Point(507, 312);
            this.passwordMessageShow.Name = "passwordMessageShow";
            this.passwordMessageShow.Size = new System.Drawing.Size(143, 17);
            this.passwordMessageShow.TabIndex = 11;
            this.passwordMessageShow.Text = "Минимум 8 символов!";
            this.passwordMessageShow.Visible = false;
            // 
            // usernameMessageLabel
            // 
            this.usernameMessageLabel.AutoSize = true;
            this.usernameMessageLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usernameMessageLabel.ForeColor = System.Drawing.Color.Red;
            this.usernameMessageLabel.Location = new System.Drawing.Point(507, 261);
            this.usernameMessageLabel.Name = "usernameMessageLabel";
            this.usernameMessageLabel.Size = new System.Drawing.Size(143, 17);
            this.usernameMessageLabel.TabIndex = 10;
            this.usernameMessageLabel.Text = "Минимум 8 символов!";
            this.usernameMessageLabel.Visible = false;
            // 
            // confrimMessageLabel
            // 
            this.confrimMessageLabel.AutoSize = true;
            this.confrimMessageLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.confrimMessageLabel.ForeColor = System.Drawing.Color.Red;
            this.confrimMessageLabel.Location = new System.Drawing.Point(507, 357);
            this.confrimMessageLabel.Name = "confrimMessageLabel";
            this.confrimMessageLabel.Size = new System.Drawing.Size(145, 17);
            this.confrimMessageLabel.TabIndex = 12;
            this.confrimMessageLabel.Text = "Пароли не совпадают!";
            this.confrimMessageLabel.Visible = false;
            // 
            // RegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "RegForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label introLabel;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label confirmPasswordLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label passwordMessageShow;
        private System.Windows.Forms.Label usernameMessageLabel;
        private System.Windows.Forms.Label confrimMessageLabel;
    }
}