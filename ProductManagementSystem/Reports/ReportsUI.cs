using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using ProductManagementSystem.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProductManagementSystem.Reports
{
    public partial class ReportsUI : Form
    {
        public int x;
        public ReportsUI()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainUI1 frm = new MainUI1();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReportByBrand f2 = new ReportByBrand();
            this.Visible = false;
            f2.ShowDialog();
            this.Visible = true;
        }

        private void ReportsUI_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            MainUI1 frm = new MainUI1();
            frm.Show();
        }
              
     }
}
