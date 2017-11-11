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
        public int rsnid;
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
                dataGridView1.Rows.Clear();
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
            resnld();
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

        private void resnld()
        {
            try
            {
                con = new SqlConnection(cs.DBConn);
                con.Open();
                string qr222 = "select ReasonName from ReasonForObsolete";
                cmd = new SqlCommand(qr222, con);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    reasonCombo.Items.Add(rdr.GetString(0));
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
                MessageBox.Show("You have not selected Product yet", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(txtItemDescription.Text))
            {
                MessageBox.Show("You have not selected Product yet", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (string.IsNullOrEmpty(txtItemCode.Text))
            {
                MessageBox.Show("You have not selected Product yet", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (string.IsNullOrEmpty(comboBox1.Text))
            {
                MessageBox.Show("You have not selected Obsolete", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (string.IsNullOrEmpty(notifictxt.Text))
            {
                MessageBox.Show("Please Give Notification Number", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (string.IsNullOrEmpty(reasonCombo.Text))
            {
                MessageBox.Show("Please Select Reason", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (string.IsNullOrEmpty(dateTimePicker1.Text))
            {
                MessageBox.Show("Please Select Effective Date", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }



            else
            {
                try
                {
                    con = new SqlConnection(cs.DBConn);
                    con.Open();
                    string qqer = "Select ObsoleteProduct.Sl from ObsoleteProduct where ObsoleteProduct.Sl=@dd1";
                    cmd = new SqlCommand(qqer, con);
                    cmd.Parameters.AddWithValue("@dd1", slno);
                    rdr = cmd.ExecuteReader();
                    if (rdr.Read() == true)
                    {
                        MessageBox.Show("This Product is Already Obsolete", "Stop", MessageBoxButtons.OK,
                            MessageBoxIcon.Stop);

                    }
                    else
                    {
                        try
                        {
                            con = new SqlConnection(cs.DBConn);
                            con.Open();
                            string qry3 = "update ProductListSummary set ObsoleteId = '" + obid + "' where  Sl = '" +
                                          slno + "'   ";
                            cmd = new SqlCommand(qry3, con);
                            cmd.ExecuteScalar();
                            con.Close();
                            MessageBox.Show("Successfully Done.", "Update", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
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

                        try
                        {
                            con = new SqlConnection(cs.DBConn);
                            con.Open();
                            string qry5 = "insert into ObsoleteProduct(Sl, NotificationNumber, ReasonId, EffectiveDate) values(@d1,@d2,@d3,@d4) " +
                                          "SELECT CONVERT(int, SCOPE_IDENTITY())";
                            cmd = new SqlCommand(qry5, con);
                            cmd.Parameters.AddWithValue("@d1", slno);
                            cmd.Parameters.AddWithValue("@d2",notifictxt.Text );
                            cmd.Parameters.AddWithValue("@d3",rsnid);
                            cmd.Parameters.AddWithValue("@d4", dateTimePicker1.Value.ToLocalTime());
                            cmd.ExecuteScalar();
                            con.Close();
                            
                            notifictxt.Clear();
                            reasonCombo.Items.Clear();
                            resnld();
                            dateTimePicker1.Value = DateTime.Now;

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

        private void reasonCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(cs.DBConn);
                con.Open();
                string qrrr4 = "select ReasonId from ReasonForObsolete where ReasonName = '" + reasonCombo.Text + "' ";
                cmd = new SqlCommand(qrrr4, con);
                rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    rsnid = rdr.GetInt32(0);
                }
                con.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void txtProductsrch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(cs.DBConn);
                con.Open();
                string qr1 = "select ProductListSummary.Sl, ProductListSummary.ProductGenericDescription, ProductListSummary.ItemDescription, ProductListSummary.ItemCode,ProductListSummary.CountryOfOrigin, ProductListSummary.Price, Obsolete.ObName from  ProductListSummary LEFT OUTER JOIN Obsolete ON ProductListSummary.ObsoleteId =  Obsolete.ObsoleteId where ProductListSummary.ItemCode like '" + txtProductsrch.Text + "%'";
                
                cmd = new SqlCommand(qr1, con);
                rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                dataGridView1.Rows.Clear();
                while (rdr.Read() == true)
                {
                    dataGridView1.Rows.Add(rdr[0], rdr[1], rdr[2], rdr[3], rdr[4], rdr[5], rdr[6]);

                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void itemDescriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(cs.DBConn);
                con.Open();
                string qr1 = "select ProductListSummary.Sl, ProductListSummary.ProductGenericDescription, ProductListSummary.ItemDescription, ProductListSummary.ItemCode,ProductListSummary.CountryOfOrigin, ProductListSummary.Price, Obsolete.ObName from  ProductListSummary LEFT OUTER JOIN Obsolete ON ProductListSummary.ObsoleteId =  Obsolete.ObsoleteId where ProductListSummary.ItemDescription like '" + itemDescriptionTextBox.Text + "%'";

                cmd = new SqlCommand(qr1, con);
                rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                dataGridView1.Rows.Clear();
                while (rdr.Read() == true)
                {
                    dataGridView1.Rows.Add(rdr[0], rdr[1], rdr[2], rdr[3], rdr[4], rdr[5], rdr[6]);

                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void productNameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(cs.DBConn);
                con.Open();
                string qr1 = "select ProductListSummary.Sl, ProductListSummary.ProductGenericDescription, ProductListSummary.ItemDescription, ProductListSummary.ItemCode,ProductListSummary.CountryOfOrigin, ProductListSummary.Price, Obsolete.ObName from  ProductListSummary LEFT OUTER JOIN Obsolete ON ProductListSummary.ObsoleteId =  Obsolete.ObsoleteId where ProductListSummary.ProductGenericDescription like '" + productNameTextBox.Text + "%'";

                cmd = new SqlCommand(qr1, con);
                rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                dataGridView1.Rows.Clear();
                while (rdr.Read() == true)
                {
                    dataGridView1.Rows.Add(rdr[0], rdr[1], rdr[2], rdr[3], rdr[4], rdr[5], rdr[6]);

                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

      




    }
}
