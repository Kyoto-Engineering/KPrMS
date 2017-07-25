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
        public ReplyForInquiry()
        {
            InitializeComponent();
        }

        private void CountryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ReplyForInquiry_Load(object sender, EventArgs e)
        {
            FillCountry();

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
        
    }
}
