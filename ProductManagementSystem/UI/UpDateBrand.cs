using System;
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

namespace ProductManagementSystem.UI
{
    public partial class UpDateBrand : Form
    {
        private SqlConnection con;
        private SqlCommand cmd;
        private SqlDataAdapter sda;
        private SqlDataReader rdr;
        ConnectionString cs = new ConnectionString();
        public UpDateBrand()
        {
            InitializeComponent();
        }
        public void Reset()
        {
            txtId.Clear();
            txtBrandName.Clear();
            txtBrandCode.Clear();
            txtUBrandFooterImage.Image = null;
            txtUBrandLogoImage.Image = null;
        }
        private void updateButton_Click(object sender, EventArgs e)
        {
            if (txtBrandName.Text == "")
            {
                MessageBox.Show("Please enter Brand Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBrandName.Focus();
                return;
            }
            if (txtBrandCode.Text == "")
            {
                MessageBox.Show("Please enter Brand Code", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBrandCode.Focus();
                return;
            }

            try
            {

                con = new SqlConnection(cs.DBConn);
                con.Open();
                string cb = "Update Brand set BrandName=@d1,BrandCode=@d2,BrandFooterImage=@d3,BrandLogoImage=@d4 where BrandId='" + txtId.Text + "'";
                cmd = new SqlCommand(cb);
                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@d1", txtBrandName.Text);
                cmd.Parameters.AddWithValue("@d2", txtBrandCode.Text);

                if (txtUBrandFooterImage != null)
                {

                    MemoryStream ms = new MemoryStream();
                    Bitmap bmpImage = new Bitmap(txtUBrandFooterImage.Image);
                    bmpImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    byte[] data = ms.GetBuffer();
                    SqlParameter p = new SqlParameter("@d3", SqlDbType.Image);
                    p.Value = data;
                    cmd.Parameters.Add(p);
                }
                else
                {
                    cmd.Parameters.Add("@d3", SqlDbType.VarBinary, -1);
                    cmd.Parameters["@d3"].Value = DBNull.Value;
                }
                if (txtUBrandLogoImage.Image != null)
                {
                    MemoryStream ms1 = new MemoryStream();
                    Bitmap bmpImage1 = new Bitmap(txtUBrandLogoImage.Image);
                    bmpImage1.Save(ms1, System.Drawing.Imaging.ImageFormat.Jpeg);
                    byte[] data1 = ms1.GetBuffer();
                    SqlParameter p1 = new SqlParameter("@d4", SqlDbType.Image);
                    p1.Value = data1;
                    cmd.Parameters.Add(p1);
                }
                else
                {
                    cmd.Parameters.Add("@d4", SqlDbType.VarBinary, -1);
                    cmd.Parameters["@d4"].Value = DBNull.Value;
                }
                rdr = cmd.ExecuteReader();
                con.Close();
                MessageBox.Show("Successfully updated", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                updateButton.Enabled = false;
                Reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bfIBrowseButton_Click(object sender, EventArgs e)
        {
            try
            {
                var _with1 = openFileDialog1;

                _with1.Filter = ("Image Files |*.png;");
                _with1.FilterIndex = 4;

                openFileDialog1.FileName = "";

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                     if (Image.FromFile(openFileDialog1.FileName).Height != 300)
                    {
                        MessageBox.Show("Height Must Be 300 Pixel", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else if (Image.FromFile(openFileDialog1.FileName).Width != 2176)
                    {
                        MessageBox.Show("Width Must Be 2176 Pixel", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        txtUBrandFooterImage.Image = Image.FromFile(openFileDialog1.FileName);
                        blIBrowseButton.Focus();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void blIBrowseButton_Click(object sender, EventArgs e)
        {
            try
            {
                var _with1 = openFileDialog1;

                _with1.Filter = ("Image Files |*.png; *.bmp; *.jpg;*.jpeg; *.gif;");
                _with1.FilterIndex = 4;

                openFileDialog1.FileName = "";

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    txtUBrandLogoImage.Image = Image.FromFile(openFileDialog1.FileName);
                    updateButton.Focus();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            GridForBrand frm =new GridForBrand();
               frm.Show();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainUI1 frm=new MainUI1();
            frm.Show();

        }

        private void txtId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtBrandName.Focus();
                e.Handled = true;
            }
        }

        private void txtBrandName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtBrandCode.Focus();
                e.Handled = true;
            }
        }

        private void txtBrandCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bfIBrowseButton.Focus();
                e.Handled = true;
            }
        }
    }
}
