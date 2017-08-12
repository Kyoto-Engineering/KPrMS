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
using ProductManagementSystem.LogInUI;

namespace ProductManagementSystem.UI
{
    public partial class PriceInquiry : Form
    {
        private SqlCommand cmd;
        private SqlConnection con;
        private SqlDataReader rdr;
        ConnectionString cs = new ConnectionString();
        private int pno;
        private SqlTransaction trans;
       
        public PriceInquiry()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainUI1 frm = new MainUI1();
            frm.Show();
        }

        private void Reset()
        {
            ModelTextBox.Clear();
            ProDesTextBox.Clear();
            InqFromTextBox.Clear();
            RemarksTextBox.Clear();
            QtyTextBox.Clear();
            ProGenDesTextBox.Clear();
            SaveButton.Enabled = true;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ModelTextBox.Text))
            {
                MessageBox.Show("Please Enter Product Model", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ModelTextBox.Focus();
               
            }
            else  if (string.IsNullOrWhiteSpace(ProDesTextBox.Text))
            {
                //MessageBox.Show("Please Enter Product Description", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //ProDesTextBox.Focus();
              
            }
            
            else if (string.IsNullOrWhiteSpace(InqFromTextBox.Text ))
            {
                MessageBox.Show("Please Enter Inquiry From", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                InqFromTextBox.Focus();
            
            }
            else if (string.IsNullOrWhiteSpace(RemarksTextBox.Text ))
            {
                //MessageBox.Show("Please Enter Remarks", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //RemarksTextBox.Focus();
             
            }
            else if (string.IsNullOrWhiteSpace(QtyTextBox.Text))
            {
                MessageBox.Show("Please Enter Product Qty", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                QtyTextBox.Focus();

            }
            else if (string.IsNullOrWhiteSpace(ProGenDesTextBox.Text))
            {
                MessageBox.Show("Please Enter Product Generic Description", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ProGenDesTextBox.Focus();
            }

            else
            {
                if (listView1.Items.Count < 1)
                {
                    ListViewItem l1=new ListViewItem(ModelTextBox.Text);
                 
                    l1.SubItems.Add(ProDesTextBox.Text);
                    l1.SubItems.Add(InqFromTextBox.Text);
                    l1.SubItems.Add(RemarksTextBox.Text);
                    l1.SubItems.Add(QtyTextBox.Text);
                    l1.SubItems.Add(ProGenDesTextBox.Text);
                    listView1.Items.Add(l1);
                    Reset();
                }
                else
                {
                    ListViewItem l2 = new ListViewItem(ModelTextBox.Text);

                    l2.SubItems.Add(ProDesTextBox.Text);
                    l2.SubItems.Add(InqFromTextBox.Text);
                    l2.SubItems.Add(RemarksTextBox.Text);
                    l2.SubItems.Add(QtyTextBox.Text);
                    l2.SubItems.Add(ProGenDesTextBox.Text);
                    listView1.Items.Add(l2);
                    Reset();
                }
            }
                
            
        }

        private void ModelTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ProDesTextBox.Focus();
                e.Handled = true;
            }
        }

        private void ProDesTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                InqFromTextBox.Focus();
                e.Handled = true;
            }
        }

        
        private void InqFromTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                RemarksTextBox.Focus();
                e.Handled = true;
            }
        }

        private void RemarksTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                QtyTextBox.Focus();
                e.Handled = true;
            }
        }

        private void QtyTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SaveButton_Click(this, new EventArgs());
            }
        }

        
        private void QtyTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }
                     
        private void PriceInquiry_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            MainUI1 frm = new MainUI1();
            frm.Show();
        }

        private void PriceInquiry_Load(object sender, EventArgs e)
        {
            LoadPNo();
            if (pno!= 0)
            {
                int p = Convert.ToInt32(pno);
                textBox1.Text = Ordinal(p) + @" Price Inquiry";
            }
            else
            {
                textBox1.Text = "First Inquiry using this Software";
            }
          
        }

        private void LoadPNo()
        {
            try

            {
                int cnt=0;
                con = new SqlConnection(cs.DBConn);
                con.Open();
                string qry = "SELECT  COUNT(PrInId) AS Expr1 FROM PriceInquiry";
                cmd = new SqlCommand(qry, con);
                rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                     cnt= rdr.GetInt32(0);
                }
                con.Close();
                con = new SqlConnection(cs.DBConn);
                con.Open();

                string inquiry = "SELECT CONVERT(int, IDENT_CURRENT('PriceInquiry')) as pno";
                cmd = new SqlCommand(inquiry, con);
                rdr = cmd.ExecuteReader();
                if (rdr.Read()&&!rdr.IsDBNull(0))
                {
                    //string pno = rdr[0].ToString();
                    pno = rdr.GetInt32(0);
                    if (cnt != 0)
                    {
                        pno = pno + 1;
                    }
                }
                else
                {
                    pno = 0;
                }
                con.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                con.Close();
                this.Close();
            }
        }

        public static string Ordinal(int number)
        {
            string suffix = String.Empty;
            if (number == 11 || number == 12 || number == 13 || number % 100 == 11 || number % 100 == 12 || number % 100 == 13)
            {
                suffix = "th";
            }
            else if (number == 1 || number % 10 == 1)
            {
                suffix = "st";
            }
            else if (number == 2 || number % 10 == 2)
            {
                suffix = "nd";
            }
            else if (number == 3 || number % 10 == 3)
            {
                suffix = "rd";
            }
            else
            {
                suffix = "th";
            }
            return String.Format("{0}{1}", number, suffix);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(ModelTextBox.Text) || !String.IsNullOrWhiteSpace(ProDesTextBox.Text) ||
                !String.IsNullOrWhiteSpace(InqFromTextBox.Text) || !String.IsNullOrWhiteSpace(RemarksTextBox.Text) ||
                !String.IsNullOrWhiteSpace(QtyTextBox.Text) || !String.IsNullOrWhiteSpace(ProGenDesTextBox.Text))
            {
                MessageBox.Show(@"You Forgot to add "+"\r \n Add first or clear these");
            }
            else if(listView1.Items.Count<1)
            {
                MessageBox.Show(@"Nothing to Submit");
            }
            else
            {
                try
                {
                    con = new SqlConnection(cs.DBConn);
                    con.Open();
                   trans = con.BeginTransaction();
                    string query1 = "insert into PriceInquiry(EntryDate,UserId) values(@d1,@d2)" + "SELECT CONVERT(int, SCOPE_IDENTITY())";
                    cmd = new SqlCommand(query1, con, trans);
                    cmd.Parameters.AddWithValue("@d1", DateTime.UtcNow.ToLocalTime());
                    cmd.Parameters.AddWithValue("@d2", frmLogin.uId2);
                    int id = (int) cmd.ExecuteScalar();
                    string query2 = "insert into PriceInquiryDetail(Model,ProductDescription,InquiryFrom,Remarks,Qty,PrInId,ProductGenericDescription) values(@d1,@d2,@d3,@d4,@d5,@d6,@d7)";
                    cmd = new SqlCommand(query2, con,trans);
                    for (int i = 0; i < listView1.Items.Count; i++)
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@d1", listView1.Items[i].Text);
                        cmd.Parameters.AddWithValue("@d2", listView1.Items[i].SubItems[1].Text);
                        cmd.Parameters.AddWithValue("@d3", listView1.Items[i].SubItems[2].Text);
                        cmd.Parameters.AddWithValue("@d4", listView1.Items[i].SubItems[3].Text);
                        cmd.Parameters.AddWithValue("@d5", listView1.Items[i].SubItems[4].Text);
                        cmd.Parameters.AddWithValue("@d6", id);
                        cmd.Parameters.AddWithValue("@d7", listView1.Items[i].SubItems[5].Text);
                        cmd.ExecuteNonQuery();
                    }
                  
                  trans.Commit();
                    MessageBox.Show("Successfully Saved", "Report", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox1.Clear();
                    listView1.Items.Clear();
                    SaveButton.Enabled = false;
                    con.Close();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   trans.Rollback();
                    con.Close();
                }
            }
        }
    }

}




