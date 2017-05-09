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
    public partial class newProductEntry : Form
    {
        private SqlConnection con;
        private SqlDataReader rdr;
        private SqlCommand cmd;
        ConnectionString cs = new ConnectionString();
        public string brandId;
        public string spec;
        public Nullable<Decimal> price;
        public newProductEntry()
        {
            InitializeComponent();
        }

        private void Reset()
        {
            txtProductName.Text = "";
            txtItemDescription.Text = "";
            txtItemCode.Text = "";
            cmbCountryOfOrigin.SelectedIndex = -1;
            txtPrice.Text = "";
            cmbBrand.SelectedIndex = -1;
           richTextBox1.Clear();
            txtPictureBox.Image = null;
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            if (txtProductName.Text == "")
            {
                MessageBox.Show("Please  enter Product Name", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtProductName.Focus();
                return;
            }
            if (txtItemDescription.Text == "")
            {
                MessageBox.Show("Please  enter Item Description", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtItemDescription.Focus();
                return;
            }
            if (txtItemCode.Text == "")
            {
                MessageBox.Show("Please  enter item Code", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtItemCode.Focus();
                return;
            }
            if (cmbCountryOfOrigin.Text == "")
            {
                MessageBox.Show("Please  enter Country Of Origin", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbCountryOfOrigin.Focus();
                return;
            }

            if (richTextBox1.Text == "")
            {
                spec = null;
            }
            else
            {
                spec = richTextBox1.Text;
            }
            if (txtPrice.Text == "")
            {
                price = null;
            }
            else
            {
                decimal b = Convert.ToDecimal(txtPrice.Text);
                if (b > 0)
                {
                    price = b;
                }
                else
                {
                    price = null;
                }
            }
            try
            {
                con = new SqlConnection(cs.DBConn);
                con.Open();
                string ct = "select ItemCode from ProductListSummary where ItemCode='" +txtItemCode.Text +"'";

                cmd = new SqlCommand(ct);
                cmd.Connection = con;
                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    MessageBox.Show("This Product Item Already Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtItemCode.Clear();
                    txtItemCode.Focus();


                    if ((rdr != null))
                    {
                        rdr.Close();
                    }
                    return;
                }

                con = new SqlConnection(cs.DBConn);
                con.Open();
                string query = "insert into ProductListSummary(ProductGenericDescription,ItemDescription,ItemCode,CountryOfOrigin,Price,ProductImage,Specification,BrandId) values(@d1,@d2,@d3,@d4,@d5,@d6,@d7,@d8)";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@d1", txtProductName.Text);
                cmd.Parameters.AddWithValue("@d2", txtItemDescription.Text);
                cmd.Parameters.AddWithValue("@d3", txtItemCode.Text);
                cmd.Parameters.AddWithValue("@d4", cmbCountryOfOrigin.Text);
                cmd.Parameters.AddWithValue("@d5",(object)price??DBNull.Value);

                if (txtPictureBox.Image != null)
                {

                    MemoryStream ms = new MemoryStream();
                    Bitmap bmpImage = new Bitmap(txtPictureBox.Image);
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
                cmd.Parameters.AddWithValue("@d7", (object)spec??DBNull.Value);
                cmd.Parameters.AddWithValue("@d8", brandId);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successfully Saved", "Report", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Reset();
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
                    txtPictureBox.Image = Image.FromFile(openFileDialog1.FileName);
                    saveButton.Focus();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void getDataButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProductGrid frm= new ProductGrid();
            frm.Show();
        }

        private void txtStockAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtTaxToDuty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
                 this.Hide();
            MainUI1 frm=new MainUI1();
                   frm.Show();
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
        private void newProductEntry_Load(object sender, EventArgs e)
        {
            FillBrandCombo();
        }

        private void cmbBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(cs.DBConn);

                con.Open();
                cmd = con.CreateCommand();
                cmd.CommandText = "SELECT  Brand.BrandId from Brand WHERE Brand.BrandName = '" + cmbBrand.Text + "'";
                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    brandId = (rdr.GetString(0));
                   
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

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtProductName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtItemDescription.Focus();
                e.Handled = true;
            }
        }

        private void txtItemDescription_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtItemCode.Focus();
                e.Handled = true;
            }
        }

        private void txtItemCode_KeyDown(object sender, KeyEventArgs e)
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
                cmbBrand.Focus();
                e.Handled = true;
            }
        }

        private void cmbBrand_KeyDown(object sender, KeyEventArgs e)
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
                txtPrice.Focus();
                e.Handled = true;
            }
        }

        private void txtPrice_KeyDown(object sender, KeyEventArgs e)
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

       
    }
}
