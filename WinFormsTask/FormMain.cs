using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsTask
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnTask1_Click(object sender, EventArgs e)
        {
            new FormTask1().Show();
        }

        private void btnTask2_Click(object sender, EventArgs e)
        {
            new FormTask2().Show();
        }

        private void btnTask3_Click(object sender, EventArgs e)
        {
            new FormTask3().Show();
        }
    }
}
