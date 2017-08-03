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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
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

        private void PriceInqListButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            PriceInquiryReport f2 = new PriceInquiryReport();
            this.Visible = false;
            f2.ShowDialog();
            this.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {   
            this.Hide();
            WithoutPriceProduct f2 = new WithoutPriceProduct();
            this.Visible = false;
            f2.ShowDialog();
            this.Visible = true;
        }

        
        private void InFeedbackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            InquiryFeedbackReport f2 = new InquiryFeedbackReport();
            this.Visible = false;
            f2.ShowDialog();
            this.Visible = true;
        }

        
    }
}
