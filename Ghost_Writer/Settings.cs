using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Ghost_Writer
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            screenshot_interval.SelectedIndex = 0;
            email_interval.SelectedIndex = 0;
        }

        private void Settings_Load(object sender, EventArgs e)
        {

        }

        private void close_settings_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
