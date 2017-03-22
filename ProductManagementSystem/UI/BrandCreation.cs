using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ProductManagementSystem.DbGateway;

namespace ProductManagementSystem.UI
{
    public partial class BrandCreation : Form
    {
        private SqlCommand cmd;
        private SqlConnection con;
        private SqlDataReader rdr;
        ConnectionString cs=new ConnectionString();
        public int userId;
        public BrandCreation()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainUI1 frm=new MainUI1();
             frm.Show();
        }

        public void Reset()
        {
            txtBrandName.Clear();
            txtBrandCode.Clear();
            txtBrandFooterImage.Image = null;
            txtBrandLogoImage.Image = null;
        }
        private void submitButton_Click(object sender, EventArgs e)
        {
            
            if (txtBrandName.Text == "")
            {
                MessageBox.Show("Please  enter Brand Name", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBrandName.Focus();
                return;
            }
            if (txtBrandCode.Text == "")
            {
                MessageBox.Show("Please  enter Brand Code", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBrandCode.Focus();
                return;
            }

            try
            {
                SqlParameter p, p1;
                con = new SqlConnection(cs.DBConn);
                con.Open();
                string ct = "select BrandName from Brand where BrandName='" + txtBrandName.Text + "'";

                cmd = new SqlCommand(ct);
                cmd.Connection = con;
                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    MessageBox.Show("This Brand Already Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtBrandName.Text = "";
                    txtBrandName.Focus();


                    if ((rdr != null))
                    {
                        rdr.Close();
                    }
                    return;
                }

                con = new SqlConnection(cs.DBConn);
                con.Open();
                string query = "insert into Brand(BrandName,BrandCode,UserId,Dates,BrandFooterImage,BrandLogoImage) values(@d1,@d2,@d3,@d4,@d5,@d6)";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@d1", txtBrandName.Text);
                cmd.Parameters.AddWithValue("@d2", txtBrandCode.Text);
                cmd.Parameters.AddWithValue("@d3", userId);
                cmd.Parameters.AddWithValue("@d4", DateTime.UtcNow.ToLocalTime());
                if (txtBrandFooterImage.Image != null)
                {
                    MemoryStream ms = new MemoryStream();
                    Bitmap bmpImage = new Bitmap(txtBrandFooterImage.Image);
                    bmpImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    byte[] data = ms.GetBuffer();
                    p = new SqlParameter("@d5", SqlDbType.VarBinary);
                    p.Value = data;
                    cmd.Parameters.Add(p);
                }
                else
                {
                    cmd.Parameters.Add("@d5", SqlDbType.VarBinary, -1);
                    cmd.Parameters["@d5"].Value = DBNull.Value;
                    //cmd.Parameters.AddWithValue("@d5", new byte[0]);
                    //cmd.Parameters.Add(DBNull.Value);
                }
    //            (member.Image==null)
    //? (object)DBNull.Value
    //: member.Image)
    //            (member.Image==null)
    //? (object)DBNull.Value
    //: member.Image).SqlDbType = SqlDbType.Image
               
                //cmd.Parameters.Add(p);
                //cmd.Parameters.Add((txtBrandFooterImage.Image == null)? (object)DBNull.Value:p);
                if (txtBrandLogoImage.Image != null)
                {
                    MemoryStream ms1 = new MemoryStream();
                    Bitmap bmpImage1 = new Bitmap(txtBrandLogoImage.Image);
                    bmpImage1.Save(ms1, System.Drawing.Imaging.ImageFormat.Jpeg);
                    byte[] data1 = ms1.GetBuffer();
                    p1 = new SqlParameter("@d6", SqlDbType.VarBinary);
                    p1.Value = data1;
                    cmd.Parameters.Add(p1);
                }
                else
                {
                    cmd.Parameters.Add("@d6", SqlDbType.VarBinary, -1);
                    cmd.Parameters["@d6"].Value = DBNull.Value;
                }
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

        private void bfIBrowseButton_Click(object sender, EventArgs e)
        {
            try
            {
                var _with1 = openFileDialog1;

                _with1.Filter = ("PNG Image Files |*.png;");
                _with1.FilterIndex = 4;

                openFileDialog1.FileName = "";
                //if (Image.FromFile(openFileDialog1.FileName).Height != 300)
                //{
                //    MessageBox.Show("Height Must Be 300 Pixel", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    return;
                //}
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
                    //if (ValidFile(openFileDialog1.FileName, 300, 2176))
                    //{

                        txtBrandFooterImage.Image = Image.FromFile(openFileDialog1.FileName);
                        blIBrowseButton.Focus();
                    }
                    //else
                    //{
                    //    MessageBox.Show("Image Size is invalid");
                    //}
                    
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool ValidFile(string filename, int limitWidth, int limitHeight)
        {
            //var fileSizeInBytes = new FileInfo(filename).Length;
            //if (fileSizeInBytes > limitInBytes) return false;

            using (var img = new Bitmap(filename))
            {
                if (img.Width != limitWidth || img.Height != limitHeight) return false;
            }

            return true;
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
                    txtBrandLogoImage.Image = Image.FromFile(openFileDialog1.FileName);
                    submitButton.Focus();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void BrandCreation_Load(object sender, EventArgs e)
        {
            label3.Parent = txtBrandFooterImage;
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

        private void txtBrandName_TextChanged(object sender, EventArgs e)
        {

        }

       

       

       

        

       
    }
}
