﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ProductManagementSystem.DbGateway;
using ProductManagementSystem.LogInUI;

namespace ProductManagementSystem.UI
{
    public partial class frmProductUpdate : Form
    {
        private SqlConnection con;
        private SqlCommand cmd;
        private SqlDataAdapter sda;
        private SqlDataReader rdr;
        ConnectionString cs=new ConnectionString();
        public string brandIdu,branId33,specup;
        public int brandIdU2,brandId44,rev;
        public Nullable<Decimal> priceup;
        public frmProductUpdate()
        {
            InitializeComponent();
        }


        private void Reset()
        {
            txtUProductId.Text = "";
            txtUProductName.Text = "";
            txtUItemDescription.Text = "";
            txtUItemCode.Text = "";
            cmbCountryOfOrigin.SelectedIndex = -1;
            txtUPrice.Text = "";
            cmbBrand.SelectedIndex = -1;
            richTextBox1.Clear();
           // txtUTaxToDuty.Text = "";
            txtUPictureBox.Image = null;
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (txtUProductName.Text == "")
            {
                MessageBox.Show("Please enter  product Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUProductName.Focus();
                return;
            }
            if (txtUItemCode.Text == "")
            {
                MessageBox.Show("Please Type Item Code", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUItemCode.Focus();
                return;
            }
            if (richTextBox1.Text == "")
            {
                specup = null;
            }
            else
            {
                specup = richTextBox1.Text;
            }
            if (txtUPrice.Text == "")
            {
                priceup = null;
            }
            else
            {
                decimal b = Convert.ToDecimal(txtUPrice.Text);
                if (b > 0)
                {
                    priceup = b;
                }
                else
                {
                    priceup = null;
                }
            }
            try
            {

                if (brandId44 == 0)
                {
                    try
                    {
                        con = new SqlConnection(cs.DBConn);

                        con.Open();
                        cmd = con.CreateCommand();
                        cmd.CommandText = "SELECT  RTRIM(Brand.BrandId) from Brand WHERE Brand.BrandName = '" + cmbBrand.Text.Trim() + "'";
                        rdr = cmd.ExecuteReader();

                        if (rdr.Read())
                        {
                            branId33 = (rdr.GetString(0));
                            brandId44 = Convert.ToInt32(branId33);

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
               
                
                    con = new SqlConnection(cs.DBConn);
                    con.Open();
                    string cb = "Update ProductListSummary set ProductGenericDescription=@d1,ItemDescription=@d2,ItemCode=@d3,CountryOfOrigin=@d4,Price=@d5,ProductImage=@d6,Specification=@d7,BrandId=@d8,Url=@d9,CurrentRevision=@d10,DLT = @d11 where Sl='" + txtUProductId.Text + "'";
                    cmd = new SqlCommand(cb);
                    cmd.Connection = con;
                    cmd.Parameters.AddWithValue("@d1", txtUProductName.Text);
                    cmd.Parameters.AddWithValue("@d2", txtUItemDescription.Text);
                    cmd.Parameters.AddWithValue("@d3", txtUItemCode.Text);
                    cmd.Parameters.AddWithValue("@d4", cmbCountryOfOrigin.Text);
                    //cmd.Parameters.AddWithValue("@d8", cmbBrand.Text);
                    cmd.Parameters.AddWithValue("@d5", (object)priceup??DBNull.Value);
 if(txtUPictureBox.Image!=null)
                   {
                    MemoryStream ms = new MemoryStream();
                    Bitmap bmpImage = new Bitmap(txtUPictureBox.Image);
                    bmpImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    byte[] data = ms.GetBuffer();
                    SqlParameter p = new SqlParameter("@d6", SqlDbType.Image);
                    p.Value = data;
                    cmd.Parameters.Add(p);
                   }
 else
 {
     cmd.Parameters.Add("@d6", SqlDbType.VarBinary, -1);
     cmd.Parameters["@d6"].Value = DBNull.Value;
 }
                    cmd.Parameters.AddWithValue("@d7", richTextBox1.Text);
                    cmd.Parameters.AddWithValue("@d8", brandId44);
                cmd.Parameters.AddWithValue("@d9",
                    string.IsNullOrWhiteSpace(textBox1.Text) ? (object) DBNull.Value : textBox1.Text);
                cmd.Parameters.AddWithValue("@d10", rev+1);
                cmd.Parameters.AddWithValue("@d11", string.IsNullOrEmpty(textBox2.Text) ? (object) DBNull.Value : textBox2.Text);
                    rdr = cmd.ExecuteReader();
                    con.Close();
               string cd= "INSERT INTO ProductUpdateLog (UserId, UpdateTime, Revision, Sl) VALUES (@d1,@d2,@d3,@d4)";
                cmd = new SqlCommand(cd);
                cmd.Connection = con;
                
                cmd.Parameters.AddWithValue("@d1", frmLogin.uId2);
                cmd.Parameters.AddWithValue("@d2", DateTime.UtcNow.ToLocalTime());
                cmd.Parameters.AddWithValue("@d3",rev+1);
                cmd.Parameters.AddWithValue("@d4", txtUProductId.Text);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successfully updated", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Reset();
                ProductGrid frm = new ProductGrid();
                this.Close();
                frm.Show();
                

               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            try
            {
                var _with1 = openFileDialog1;

                _with1.Filter = ("Image Files |*.png; *.bmp; *.jpg;*.jpeg; *.gif;");
                _with1.FilterIndex = 4;

                openFileDialog1.FileName = "";

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    txtUPictureBox.Image = Image.FromFile(openFileDialog1.FileName);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainUI1 frm = new MainUI1();
            this.Close();
                  frm.Show();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
                         this.Hide();
            ProductGrid frm=new ProductGrid();
                          frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                  Reset();
        }

        public void FillBrandCombo()
        {
            try
            {

                con = new SqlConnection(cs.DBConn);
                con.Open();
                string ct = "select RTRIM(BrandName) from Brand order by BrandName";
                cmd = new SqlCommand(ct);
                cmd.Connection = con;
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    cmbBrand.Items.Add(rdr[0]);
                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmProductUpdate_Load(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            updateButton.Enabled = false;
            FillBrandCombo();
        }

        private void txtUKBrandName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(cs.DBConn);

                con.Open();
                cmd = con.CreateCommand();
                cmd.CommandText = "SELECT  RTRIM(Brand.BrandId) from Brand WHERE Brand.BrandName = '" + txtUKBrandName.Text + "'";
                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    brandIdu = (rdr.GetString(0));
                    brandIdU2 = Convert.ToInt32(brandIdu);

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

        private void cmbBrand_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void cmbBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
           try
            {
                con = new SqlConnection(cs.DBConn);

                con.Open();
                cmd = con.CreateCommand();
                cmd.CommandText = "SELECT  RTRIM(Brand.BrandId) from Brand WHERE Brand.BrandName = '" + cmbBrand.Text + "'";
                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    branId33 = (rdr.GetString(0));
                    brandId44 = Convert.ToInt32(branId33);

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

        private void txtUPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtUProductId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtUProductName.Focus();
                e.Handled = true;

            }
        }

        private void txtUProductName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtUItemDescription.Focus();
                e.Handled = true;
            }
        }

        private void txtUItemDescription_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtUItemCode.Focus();
                e.Handled = true;
            }
        }

        private void txtUItemCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbCountryOfOrigin.Focus();
                e.Handled = true;
            }
        }

        private void cmbCountryOfOrigin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                richTextBox1.Focus();
                e.Handled = true;
            }
        }

        private void richTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbBrand.Focus();
                e.Handled = true;
            }
        }

        private void cmbBrand_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtUPrice.Focus();
                e.Handled = true;
            }
        }

        private void txtUPrice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                browseButton.Focus();
                e.Handled = true;
            }
        }

        private void cmbCountryOfOrigin_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmProductUpdate_KeyDown(object sender, KeyEventArgs e)
        {

        }

      

        
        
    }
}
