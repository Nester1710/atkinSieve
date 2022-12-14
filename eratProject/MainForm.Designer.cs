
namespace atkinSieve
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buildButton = new System.Windows.Forms.Button();
            this.sieveGroupBox = new System.Windows.Forms.GroupBox();
            this.sieveGridView = new System.Windows.Forms.DataGridView();
            this.introLabel = new System.Windows.Forms.Label();
            this.valueNumeric = new System.Windows.Forms.NumericUpDown();
            this.saveButton = new System.Windows.Forms.Button();
            this.infoButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.sieveGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sieveGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valueNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buildButton);
            this.groupBox1.Controls.Add(this.sieveGroupBox);
            this.groupBox1.Controls.Add(this.introLabel);
            this.groupBox1.Controls.Add(this.valueNumeric);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1013, 764);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // buildButton
            // 
            this.buildButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buildButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buildButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buildButton.Location = new System.Drawing.Point(640, 31);
            this.buildButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buildButton.Name = "buildButton";
            this.buildButton.Size = new System.Drawing.Size(155, 31);
            this.buildButton.TabIndex = 3;
            this.buildButton.Text = "Найти";
            this.buildButton.UseVisualStyleBackColor = true;
            this.buildButton.Click += new System.EventHandler(this.buildButton_Click);
            // 
            // sieveGroupBox
            // 
            this.sieveGroupBox.Controls.Add(this.sieveGridView);
            this.sieveGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.sieveGroupBox.Location = new System.Drawing.Point(8, 91);
            this.sieveGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sieveGroupBox.Name = "sieveGroupBox";
            this.sieveGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sieveGroupBox.Size = new System.Drawing.Size(997, 666);
            this.sieveGroupBox.TabIndex = 2;
            this.sieveGroupBox.TabStop = false;
            // 
            // sieveGridView
            // 
            this.sieveGridView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sieveGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.sieveGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sieveGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.sieveGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.sieveGridView.EnableHeadersVisualStyles = false;
            this.sieveGridView.Location = new System.Drawing.Point(69, 15);
            this.sieveGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sieveGridView.Name = "sieveGridView";
            this.sieveGridView.RowHeadersWidth = 51;
            this.sieveGridView.Size = new System.Drawing.Size(920, 644);
            this.sieveGridView.TabIndex = 0;
            this.sieveGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.sieveGridView_CellContentClick);
            // 
            // introLabel
            // 
            this.introLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.introLabel.AutoSize = true;
            this.introLabel.Location = new System.Drawing.Point(260, 33);
            this.introLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.introLabel.Name = "introLabel";
            this.introLabel.Size = new System.Drawing.Size(290, 23);
            this.introLabel.TabIndex = 1;
            this.introLabel.Text = "Количество первых простых чисел:";
            // 
            // valueNumeric
            // 
            this.valueNumeric.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.valueNumeric.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.valueNumeric.Location = new System.Drawing.Point(563, 31);
            this.valueNumeric.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.valueNumeric.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.valueNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.valueNumeric.Name = "valueNumeric";
            this.valueNumeric.Size = new System.Drawing.Size(69, 29);
            this.valueNumeric.TabIndex = 0;
            this.valueNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.valueNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.valueNumeric.ValueChanged += new System.EventHandler(this.valueNumeric_ValueChanged);
            // 
            // saveButton
            // 
            this.saveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveButton.Enabled = false;
            this.saveButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveButton.Location = new System.Drawing.Point(808, 786);
            this.saveButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(221, 46);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // infoButton
            // 
            this.infoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.infoButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoButton.Location = new System.Drawing.Point(579, 786);
            this.infoButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.infoButton.Name = "infoButton";
            this.infoButton.Size = new System.Drawing.Size(221, 46);
            this.infoButton.TabIndex = 2;
            this.infoButton.Text = "О программе";
            this.infoButton.UseVisualStyleBackColor = true;
            this.infoButton.Click += new System.EventHandler(this.infoButton_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logoutButton.Location = new System.Drawing.Point(348, 786);
            this.logoutButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(221, 46);
            this.logoutButton.TabIndex = 3;
            this.logoutButton.Text = "Выход";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 832);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.infoButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1061, 879);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1061, 879);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Решето Аткина";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.sieveGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sieveGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valueNumeric)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown valueNumeric;
        private System.Windows.Forms.GroupBox sieveGroupBox;
        private System.Windows.Forms.DataGridView sieveGridView;
        private System.Windows.Forms.Label introLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button infoButton;
        private System.Windows.Forms.Button buildButton;
        private System.Windows.Forms.Button logoutButton;
    }
}