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
    public partial class ProductGrid : Form
    {
        private SqlConnection con;
        private SqlCommand cmd;
        private SqlDataReader rdr;
        private SqlDataAdapter sda;
        ConnectionString cs=new ConnectionString();

        public ProductGrid()
        {
            InitializeComponent();
        }




        private void ProductDetailsGrid()
        {
            con = new SqlConnection(cs.DBConn);
            con.Open();
            sda = new SqlDataAdapter("Select  pp.Sl,pp.ProductGenericDescription,pp.ItemDescription,pp.ItemCode,pp.CountryOfOrigin,pp.Price,pp.Specification,pp.ProductImage,tt.BrandName from ProductListSummary as pp,Brand as tt  where pp.BrandId=tt.BrandId  order by pp.Sl desc", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].Width = 140;
            dataGridView1.Columns[2].Width = 140;
            dataGridView1.Columns[3].Width = 120;
            dataGridView1.Columns[4].Width = 120;
            dataGridView1.Columns[5].Width = 120;
            dataGridView1.Columns[6].Width = 120;
            dataGridView1.Columns[7].Width = 180;
               dataGridView1.Columns[7].DefaultCellStyle.NullValue = null;
               for (int i = 0; i < dataGridView1.Columns.Count; i++)
            if (dataGridView1.Columns[i] is DataGridViewImageColumn)
               {
                   ((DataGridViewImageColumn)dataGridView1.Columns[i]).ImageLayout = DataGridViewImageCellLayout.Stretch;
                   //break;
               }
            // or whatever width works well for abbrev
            //dataGridView1.Columns[2].Width = dataGridView1.Width - dataGridView1.Columns[0].Width - dataGridView1.Columns[1].Width - 72;  
            con.Close();
        }
        private void ProductGrid_Load(object sender, EventArgs e)
        {
            ProductDetailsGrid();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridViewRow dr = dataGridView1.SelectedRows[0];
                this.Hide();
                frmProductUpdate frm = new frmProductUpdate();
                frm.Show();
                frm.txtUProductId.Text = dr.Cells[0].Value.ToString();
                frm.txtUProductName.Text = dr.Cells[1].Value.ToString();
                frm.txtUItemDescription.Text = dr.Cells[2].Value.ToString();
                frm.txtUItemCode.Text = dr.Cells[3].Value.ToString();
                frm.cmbCountryOfOrigin.Text = dr.Cells[4].Value.ToString();
                frm.txtUPrice.Text = dr.Cells[5].Value.ToString();
                frm.richTextBox1.Text = dr.Cells[6].Value.ToString();
                 if(Convert.ToString(dr.Cells[7].Value) != string.Empty)
                //if (! DBNull.Value.Equals( dr.Cells[6]))
                {
                    byte[] data = (byte[]) dr.Cells[7].Value;
                    MemoryStream ms = new MemoryStream(data);
                    frm.txtUPictureBox.Image = Image.FromStream(ms);
                }

                //frm.txtUTaxToDuty.Text = dr.Cells[7].Value.ToString();
                else
                {
                
                       frm.txtUPictureBox.Image = null;
                }
   
                
                
                frm.cmbBrand.Text = dr.Cells[8].Value.ToString();
                frm.labelk.Text = labelg.Text;

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
