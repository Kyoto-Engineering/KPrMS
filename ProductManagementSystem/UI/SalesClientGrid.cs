using ProductManagementSystem.DbGateway;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProductManagementSystem.UI
{
    public partial class SalesClientGrid : Form
    {
        private SqlConnection con;
        private SqlCommand cmd;
        private SqlDataReader rdr;
        ConnectionString cs = new ConnectionString();
        public int ReturnValue1 { get; set; }
        public string ReturnValue2 { get; set; }
        public SalesClientGrid()
        {
            InitializeComponent();
        }

        public void GetData()
        {
            try
            {
                con = new SqlConnection(cs.DBConn);
                con.Open();
                cmd =
                    new SqlCommand(
                        "SELECT SalesClient.SClientId, SalesClient.ClientName, EmailBank.Email, ContactPersonDetails.ContactPersonName, ContactPersonDetails.Designation, ContactPersonDetails.CellNumber, SalesClient.EndUser FROM SalesClient Left JOIN ContactPersonDetails ON SalesClient.SClientId = ContactPersonDetails.SClientId Left JOIN EmailBank ON SalesClient.EmailBankId = EmailBank.EmailBankId   order by SalesClient.SClientId desc",
                        con);
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
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SalesClientGrid_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridViewRow dr = dataGridView1.SelectedRows[0];
                this.Dispose();
                this.ReturnValue1 = Convert.ToInt32(dr.Cells[0].Value.ToString());
                this.ReturnValue2 = dr.Cells[1].Value.ToString(); //example
                this.DialogResult = DialogResult.OK;
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        }
    }
