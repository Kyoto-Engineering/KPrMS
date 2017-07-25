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
    public partial class ReplyForInquiry : Form
    {
        private SqlCommand cmd;
        ConnectionString cs = new ConnectionString();
        private SqlConnection con;
        private SqlDataReader rdr;
        public string Countryid;
        private DataGridViewRow dr;
        private string PInquiryId;
        public ReplyForInquiry()
        {
            InitializeComponent();
        }

        private void CountryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
                con = new SqlConnection(cs.DBConn);
                string qry ="SELECT Model, ProductDescription, Qty FROM PriceInquiry";
                cmd = new SqlCommand(qry, con);
                con.Open();
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    dataGridView1.Rows.Add(rdr[0], rdr[1], rdr[2]);
                }
                con.Close();
        }

        private void ReplyForInquiry_Load(object sender, EventArgs e)
        {
            FillCountry();
            GetData();

        }

        public void FillCountry()
        {
            try
            {
                con = new SqlConnection(cs.DBConn);
                con.Open();
                string cr = "select RTRIM(Countries.CountryName) from Countries order by Countries.CountryId";
                cmd = new SqlCommand(cr);
                cmd.Connection = con;
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    CountryComboBox.Items.Add(rdr[0]);
                }
                con=new SqlConnection(cs.DBConn);
                con.Open();
                string ctt = "select RTRIM(CountryId) from Countries  where  Countries.CountryName='" + CountryComboBox.Text + "' ";
                cmd = new SqlCommand(ctt);
                cmd.Connection = con;
                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    Countryid = (rdr.GetString(0));

                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
       }

        //price inquiry info grid view data load
        public void GetData()
        {
            try
            {
                con = new SqlConnection(cs.DBConn);
                con.Open();
                cmd = new SqlCommand("SELECT Model, ProductDescription, Qty FROM PriceInquiry",con);
                rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                dataGridView1.Rows.Clear();
                while (rdr.Read() == true)
                {
                    dataGridView1.Rows.Add(rdr[0], rdr[1], rdr[2]);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ReplyForInquiry_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            MainUI1 frm = new MainUI1();
            frm.Show();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }
        
    }
}
