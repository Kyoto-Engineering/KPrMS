using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ProductManagementSystem.DbGateway;

namespace ProductManagementSystem.UI
{
    public partial class ObsoleteMakingUII : Form
    {
        private SqlConnection con;
        private SqlDataReader rdr;
        private SqlCommand cmd;
        ConnectionString cs = new ConnectionString();
        public int slno;
        public int obid;
        public ObsoleteMakingUII()
        {
            InitializeComponent();
        }

        private void gridload()
        {
            try
            {
                con = new SqlConnection(cs.DBConn);
                con.Open();
                string q1 = "select ProductListSummary.Sl, ProductListSummary.ProductGenericDescription, ProductListSummary.ItemDescription, ProductListSummary.ItemCode,ProductListSummary.CountryOfOrigin, ProductListSummary.Price, Obsolete.ObName from  ProductListSummary LEFT OUTER JOIN Obsolete ON ProductListSummary.ObsoleteId =  Obsolete.ObsoleteId  ";
                cmd = new SqlCommand(q1, con);
                rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (rdr.Read() == true)
                {
                    dataGridView1.Rows.Add(rdr[0], rdr[1], rdr[2], rdr[3], rdr[4], rdr[5], rdr[6]);

                }

                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void ObsoleteMakingUII_Load(object sender, EventArgs e)
        {
            gridload();
            obsloleteload();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridViewRow dr = dataGridView1.CurrentRow;
                slno = Convert.ToInt32(dr.Cells[0].Value.ToString());
                txtProductName.Text = dr.Cells[1].Value.ToString();
                txtItemDescription.Text = dr.Cells[2].Value.ToString();
                txtItemCode.Text = dr.Cells[3].Value.ToString();


            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           

        }

        private void obsloleteload()
        {
            try
            {
                con = new SqlConnection(cs.DBConn);
                con.Open();
                string qr2 = "select ObName from Obsolete";
                cmd = new SqlCommand(qr2 , con);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    comboBox1.Items.Add(rdr.GetString(0));
                }

                con.Close();


            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtProductName.Text))
            {
                MessageBox.Show("You have not select Product yet", "Input Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(txtItemDescription.Text))
            {
                MessageBox.Show("You have not select Product yet", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (string.IsNullOrEmpty(txtItemCode.Text))
            {
                MessageBox.Show("You have not select Product yet", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else
            {
                try
                {
                    con = new SqlConnection(cs.DBConn);
                    con.Open();
                    string qry3 = "update ProductListSummary set ObsoleteId = '" + obid + "' where  Sl = '" + slno + "'   ";
                    cmd = new SqlCommand(qry3, con);
                    cmd.ExecuteScalar();
                    con.Close();
                    MessageBox.Show("Successfully Done.", "Update",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    txtProductName.Clear();
                    txtItemDescription.Clear();
                    txtItemCode.Clear();
                    comboBox1.Items.Clear();
                    dataGridView1.Rows.Clear();
                    gridload();
                    obsloleteload();

                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            try
            {
                con = new SqlConnection(cs.DBConn);
                con.Open();
                string qry3 = "update ProductListSummary set ObsoleteId = '" + obid + "' where  Sl = '"+ slno +"'   ";
                cmd = new SqlCommand(qry3 , con);
                cmd.ExecuteScalar();
                con.Close();

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(cs.DBConn);
                con.Open();
                string qrrr4 = "select ObsoleteId from Obsolete where ObName = '"+ comboBox1.Text +"' ";
                cmd = new SqlCommand(qrrr4 , con);
                rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    obid = rdr.GetInt32(0);
                }
                con.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }




    }
}
