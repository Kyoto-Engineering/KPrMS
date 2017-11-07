using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ProductManagementSystem.LogInUI;
using ProductManagementSystem.Reports;

namespace ProductManagementSystem.UI
{
    public partial class MainUI1 : Form
    {
        public MainUI1()
        {
            InitializeComponent();
        }

        private void createProductButton_Click(object sender, EventArgs e)
        {
                          this.Hide();
            newProductEntry frm=new newProductEntry();
                         frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                    this.Hide();
            ProductGrid frm=new ProductGrid();
                    frm.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
                  this.Hide();
            frmLogin frm=new frmLogin();
                  frm.Show();
        }

        private void brandButton_Click(object sender, EventArgs e)
        {
               this.Hide();
            frmProductUpdate frm =new frmProductUpdate();
             frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
                     this.Hide();
        BrandCreation frm=new BrandCreation();
                     frm.Show();
        }

        private void brandGridButton_Click(object sender, EventArgs e)
        {
            this.Hide();
             GridForBrand frm= new GridForBrand();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpDateBrand frm=new UpDateBrand();
            frm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            PriceInquiry frm=new PriceInquiry();
            frm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReportsUI frm=new ReportsUI();
            frm.Show();
        }

        private void ReplyInqCreationButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReplyForInquiry frm = new ReplyForInquiry();
            frm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ObsoleteMakingUII obui = new ObsoleteMakingUII();
            this.Visible = false;
            obui.ShowDialog();
            this.Visible = true;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Replacetheobsolete rto = new Replacetheobsolete();
            this.Visible = false;
            rto.ShowDialog();
            this.Visible = true;
        }
    }
}
