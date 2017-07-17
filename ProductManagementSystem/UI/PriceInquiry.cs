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
        public int countryid;
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
            ProCodeTextBox.Clear();
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
            if (ProCodeTextBox.Text == "")
            {
                MessageBox.Show("Please Enter Product Code", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ProCodeTextBox.Focus();
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
                string ct = "select Model from PriceInquiry where Model='" + ModelTextBox.Text + "'";

                cmd = new SqlCommand(ct);
                cmd.Connection = con;
                rdr = cmd.ExecuteReader();
                
                if (rdr.Read())
                {
                    MessageBox.Show("Product Model Already Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ModelTextBox.Text = "";
                    ModelTextBox.Focus();


                    if ((rdr != null))
                    {
                        rdr.Close();
                    }
                    return;
                }

                con = new SqlConnection(cs.DBConn);
                con.Open();
                string query = "insert into PriceInquiry(Model,ProductDescription,ProductCode,QTY,InquiryFrom,Remarks) values(@d1,@d2,@d3,@d4,@d5,@d6)";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@d1", ModelTextBox.Text);
                cmd.Parameters.AddWithValue("@d2", ProDesTextBox.Text);
                cmd.Parameters.AddWithValue("@d3", ProCodeTextBox.Text);
                cmd.Parameters.AddWithValue("@d4", QtyTextBox.Text);
                cmd.Parameters.AddWithValue("@d5", InqFromTextBox.Text);
                cmd.Parameters.AddWithValue("@d6", RemarksTextBox.Text);
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
                ProCodeTextBox.Focus();
                e.Handled = true;
            }
        }

        private void ProCodeTextBox_KeyDown(object sender, KeyEventArgs e)
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

        
        private void COOComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(cs.DBConn);
                con.Open();
                string ctk = "SELECT CountryId FROM Countries where CountryName='" + COOComboBox.Text + "'";
                cmd = new SqlCommand(ctk);
                cmd.Connection = con;
                rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    countryid = Convert.ToInt32(rdr["countryid"]);
                    //CountryCodetextBox.Text = (rdr.GetString(1));
                }
                if ((rdr != null))
                {
                    rdr.Close();
                }

                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GetCountry()
        {
            try
            {
                con = new SqlConnection(cs.DBConn);
                con.Open();
                string ctt = "SELECT CountryName FROM Countries";
                cmd = new SqlCommand(ctt);
                cmd.Connection = con;
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    COOComboBox.Items.Add(rdr.GetValue(0).ToString());
                }
                //cmbGender.Items.Add("Not In The List");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void PriceInquiry_Load(object sender, EventArgs e)
        {
            GetCountry();
        }

    }

}




