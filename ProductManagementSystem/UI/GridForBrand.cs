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
    public partial class GridForBrand : Form
    {
        private SqlConnection con;
        private SqlCommand cmd;
        private SqlDataAdapter sda;
         ConnectionString cs=new ConnectionString();
        public GridForBrand()
        {
            InitializeComponent();
        }


        private void BrendGrid()
        {
            con = new SqlConnection(cs.DBConn);
            con.Open();
            sda = new SqlDataAdapter("Select  pp.BrandId,pp.BrandName,pp.BrandCode,pp.BrandFooterImage,pp.BrandLogoImage from Brand as pp order by pp.BrandId desc", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Width = 70;
            dataGridView1.Columns[1].Width = 140;
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[3].Width = 200;
            dataGridView1.Columns[3].DefaultCellStyle.NullValue = null;
            dataGridView1.Columns[4].Width = 100;
            dataGridView1.Columns[4].DefaultCellStyle.NullValue = null;
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
                if (dataGridView1.Columns[i] is DataGridViewImageColumn)
                {
                    ((DataGridViewImageColumn)dataGridView1.Columns[i]).ImageLayout = DataGridViewImageCellLayout.Stretch;
                    //break;
                }
            //dataGridView1.Columns[4].ImageLayout = DataGridViewImageCellLayout.Stretch;
            //dataGridView1.Columns[7].DefaultCellStyle.NullValue = null;
             // or whatever width works well for abbrev
            //dataGridView1.Columns[2].Width = dataGridView1.Width - dataGridView1.Columns[0].Width - dataGridView1.Columns[1].Width - 72;  
            con.Close();
        }
        private void GridForBrand_Load(object sender, EventArgs e)
        {
            BrendGrid();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridViewRow dr = dataGridView1.SelectedRows[0];
                this.Hide();
                UpDateBrand frm=new UpDateBrand();
                frm.Show();
                frm.txtId.Text = dr.Cells[0].Value.ToString();
                frm.txtBrandName.Text = dr.Cells[1].Value.ToString();
                frm.txtBrandCode.Text = dr.Cells[2].Value.ToString();

                if (Convert.ToString(dr.Cells[3].Value) != string.Empty)
                //if (! DBNull.Value.Equals( dr.Cells[6]))
                {
                    byte[] data = (byte[])dr.Cells[3].Value;
                    MemoryStream ms = new MemoryStream(data);
                    frm.txtUBrandFooterImage.Image = Image.FromStream(ms);
                }

             //frm.txtUTaxToDuty.Text = dr.Cells[7].Value.ToString();
                else
                {

                    frm.txtUBrandFooterImage.Image = null;
                }

                if (Convert.ToString(dr.Cells[4].Value) != string.Empty)
                //if (! DBNull.Value.Equals( dr.Cells[6]))
                {
                    byte[] data1 = (byte[])dr.Cells[4].Value;
                    MemoryStream ms1 = new MemoryStream(data1);
                    frm.txtUBrandLogoImage.Image = Image.FromStream(ms1);
                }

             //frm.txtUTaxToDuty.Text = dr.Cells[7].Value.ToString();
                else
                {

                    frm.txtUBrandLogoImage.Image = null;
                }

              
                frm.labelk.Text = labelp.Text;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide();
            MainUI1 frm = new MainUI1();
            frm.Show();
        }
    }
}
