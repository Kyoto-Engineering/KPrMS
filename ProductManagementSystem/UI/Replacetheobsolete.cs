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
    public partial class Replacetheobsolete : Form
    {
        private SqlConnection con;
        private SqlDataReader rdr;
        private SqlCommand cmd;
        ConnectionString cs = new ConnectionString();
        public int obid;
        public int slllno;

        public Replacetheobsolete()
        {
            InitializeComponent();
        }


        private void Replacetheobsolete_Load(object sender, EventArgs e)
        {
            obsolgridld();
            gridload();
        }

        private void gridload()
        {
            try
            {
                con = new SqlConnection(cs.DBConn);
                con.Open();
                string q1 = "select ProductListSummary.Sl, ProductListSummary.ProductGenericDescription, ProductListSummary.ItemDescription, ProductListSummary.ItemCode,ProductListSummary.CountryOfOrigin, ProductListSummary.Price, Obsolete.ObName from  ProductListSummary LEFT OUTER JOIN Obsolete ON ProductListSummary.ObsoleteId =  Obsolete.ObsoleteId where ProductListSummary.ObsoleteId IS NULL ";
                cmd = new SqlCommand(q1, con);
                rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (rdr.Read() == true)
                {
                    dataGridView2.Rows.Add(rdr[0], rdr[1], rdr[2], rdr[3], rdr[4], rdr[5], rdr[6]);

                }

                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void obsolgridld()
        {
            try
            {
                con = new SqlConnection(cs.DBConn);
                con.Open();
                string qr = "select ObsoleteProduct.ObproductId, ProductListSummary.Sl,ProductListSummary.ProductGenericDescription,ProductListSummary.ItemDescription,ProductListSummary.ItemCode, Obsolete.ObName from ProductListSummary INNER JOIN ObsoleteProduct ON ProductListSummary.Sl = ObsoleteProduct.Sl INNER JOIN Obsolete ON Obsolete.ObsoleteId = ProductListSummary.ObsoleteId where ObsoleteProduct.Replaced IS NULL";
                cmd = new SqlCommand(qr, con);
                rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (rdr.Read())
                {
                    dataGridView1.Rows.Add(rdr[0],rdr[1], rdr[2], rdr[3], rdr[4], rdr[5]);
                }
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridViewRow dr = dataGridView1.CurrentRow;
                obid = Convert.ToInt32(dr.Cells[0].Value.ToString());

                txtProductName.Text = dr.Cells[2].Value.ToString();
                txtItemDescription.Text = dr.Cells[3].Value.ToString();
                txtItemCode.Text = dr.Cells[4].Value.ToString();


            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView2_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridViewRow dr1 = dataGridView2.CurrentRow;
                slllno = Convert.ToInt32(dr1.Cells[0].Value.ToString());

                textBox3.Text = dr1.Cells[1].Value.ToString();
                textBox2.Text = dr1.Cells[2].Value.ToString();
                textBox1.Text = dr1.Cells[3].Value.ToString();


            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtProductName.Text))
            {
                MessageBox.Show("You have not select Product yet", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(txtItemDescription.Text))
            {
                MessageBox.Show("You have not select Product yet", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (string.IsNullOrEmpty(txtItemCode.Text))
            {
                MessageBox.Show("You have not select Product yet", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else if (string.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("You have not select Product yet", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else if (string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("You have not select Product yet", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("You have not select Product yet", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                try
                {
                    con = new SqlConnection(cs.DBConn);
                    con.Open();
                    string qq = "select ReplacementofObsoleteProduct.Sl from ReplacementofObsoleteProduct where ReplacementofObsoleteProduct.Sl = @d33 ";
                    cmd = new SqlCommand(qq, con);
                    cmd.Parameters.AddWithValue("@d33",slllno);
                    rdr = cmd.ExecuteReader();
                    if (rdr.Read())
                    {
                        MessageBox.Show("This product is used for replacement of an obsolete product before", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        try
                        {
                            con = new SqlConnection(cs.DBConn);
                            con.Open();
                            string q10 = "insert into ReplacementofObsoleteProduct (ObproductId, Sl, NoteOnGuidance) values(@d1, @d2, @d3)" + "SELECT CONVERT(int, SCOPE_IDENTITY())";
                            cmd = new SqlCommand(q10, con);
                            cmd.Parameters.AddWithValue("@d1",obid);
                            cmd.Parameters.AddWithValue("@d2",slllno);
                            cmd.Parameters.AddWithValue("@d3", noteline.Text);
                            cmd.ExecuteScalar();
                            con.Close();

                            con.Open();
                            string q11 = "update ObsoleteProduct set ObsoleteProduct.Replaced = 'Replaced' where ObsoleteProduct.ObproductId = '" + obid +"'  ";
                            cmd = new SqlCommand(q11, con);
                            cmd.ExecuteScalar();
                            con.Close();

                            MessageBox.Show("Replacement Successfull", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            txtItemDescription.Clear();
                            txtProductName.Clear();
                            txtItemCode.Clear();
                            textBox1.Clear();
                            textBox2.Clear();
                            textBox3.Clear();
                            dataGridView1.Rows.Clear();
                            dataGridView2.Rows.Clear();
                            obsolgridld();
                            gridload();
                            noteline.Clear();
                        }
                        catch (Exception exception)
                        {
                            MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }

    }
}
