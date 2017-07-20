using ProductManagementSystem.DbGateway;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProductManagementSystem.UI
{
    public partial class PriceInquiry : Form
    {
        private SqlCommand cmd;
        private SqlConnection con;
        private SqlDataReader rdr;
        ConnectionString cs = new ConnectionString();
       
        public PriceInquiry()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainUI1 frm = new MainUI1();
            frm.Show();
        }

        private void Reset()
        {
            ModelTextBox.Clear();
            ProDesTextBox.Clear();
            InqFromTextBox.Clear();
            RemarksTextBox.Clear();
            QtyTextBox.Clear();
            SaveButton.Enabled = true;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (ModelTextBox.Text == "")
            {
                MessageBox.Show("Please Enter Product Model", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ModelTextBox.Focus();
                return;
            }
            if (ProDesTextBox.Text == "")
            {
                MessageBox.Show("Please Enter Product Description", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ProDesTextBox.Focus();
                return;
            }
            
            if (InqFromTextBox.Text == "")
            {
                MessageBox.Show("Please Enter Inquiry From", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                InqFromTextBox.Focus();
                return;
            }
            if (RemarksTextBox.Text == "")
            {
                MessageBox.Show("Please Enter Remarks", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                RemarksTextBox.Focus();
                return;
            }
            if (QtyTextBox.Text == "")
            {
                MessageBox.Show("Please Enter Product Qty", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                QtyTextBox.Focus();
                return;
            }
                                   
            try
            {
                con = new SqlConnection(cs.DBConn);
                con.Open();
                string query = "insert into PriceInquiry(Model,ProductDescription,InquiryFrom,Remarks,Qty) values(@d1,@d2,@d3,@d4,@d5)";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@d1", ModelTextBox.Text);
                cmd.Parameters.AddWithValue("@d2", ProDesTextBox.Text);
                cmd.Parameters.AddWithValue("@d3", InqFromTextBox.Text);
                cmd.Parameters.AddWithValue("@d4", RemarksTextBox.Text);
                cmd.Parameters.AddWithValue("@d5", QtyTextBox.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successfully Saved", "Report", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Reset();
                SaveButton.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ModelTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ProDesTextBox.Focus();
                e.Handled = true;
            }
        }

        private void ProDesTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                InqFromTextBox.Focus();
                e.Handled = true;
            }
        }

        
        private void InqFromTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                RemarksTextBox.Focus();
                e.Handled = true;
            }
        }

        private void RemarksTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                QtyTextBox.Focus();
                e.Handled = true;
            }
        }

        private void QtyTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SaveButton_Click(this, new EventArgs());
            }
        }

        
        private void QtyTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }
                     
        private void PriceInquiry_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            MainUI1 frm = new MainUI1();
            frm.Show();
        }

    }

}




