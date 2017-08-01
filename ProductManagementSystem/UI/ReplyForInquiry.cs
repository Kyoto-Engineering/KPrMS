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
using ProductManagementSystem.LogInUI;

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
        private string _output;
        private SqlTransaction trans;
        public ReplyForInquiry()
        {
            InitializeComponent();
        }

        private void ReplyForInquiry_Load(object sender, EventArgs e)
        {
            FillInquiry();
            FillCountry();
            GetData();

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
        public void FillInquiry()
        {
            try
            {
                con = new SqlConnection(cs.DBConn);
                con.Open();
                string cr = "SELECT PrInId FROM PriceInquiry where PrInId not in (Select PrInId from InquiryFeedback)";
                cmd = new SqlCommand(cr);
                cmd.Connection = con;
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    int x = rdr.GetInt32(0);
                    comboBox1.Items.Add(Ordinal(x)+" Price Inquiry");
                }
                con.Close();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
          
        }

        private void ReplyForInquiry_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            MainUI1 frm = new MainUI1();
            frm.Show();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                dr = dataGridView1.SelectedRows[0];
                PInquiryId = dr.Cells[0].Value.ToString();
                ModelNumberTextBox.Text = dr.Cells[1].Value.ToString();
                ProDesTextBox.Text = dr.Cells[2].Value.ToString();
                QtyTextBox.Text = dr.Cells[3].Value.ToString();
            }
            else
            {
                MessageBox.Show(@"Select Something first");
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (ValidateMustControls()) 
            {
                if (listView1.Items.Count < 1)
            {
                if (StockStatusComboBox.Text == "Invalid Model" || StockStatusComboBox.Text == "Out of Production")
                {
                    
                    
                        if (checkBox1.Checked)
                        {
                            MessageBox.Show("You Can not Add Invalid product When The Checkbox Is Checked");
                        }
                        else
                        {
                            ListViewItem l1 = new ListViewItem(PInquiryId);
                            l1.SubItems.Add("FeedBack");
                            l1.SubItems.Add(ModelNumberTextBox.Text);
                            l1.SubItems.Add(ProDesTextBox.Text);
                            l1.SubItems.Add(QtyTextBox.Text);
                            l1.SubItems.Add(StockStatusComboBox.Text);
                            listView1.Items.Add(l1);
                            ClearselectedProduct();
                            comboBox1.Enabled = false;
                            ExchangeRateTextBox.Enabled = false;
                        }

                    
                }
                else
                {
                    if (ValidateSecondControls())
                    {
                        ListViewItem l1;


                        if (checkBox1.Checked)
                        {

                            l1 = new ListViewItem("0");
                            l1.SubItems.Add("FeedBack");
                        }
                        else
                        {
                            l1 = new ListViewItem(PInquiryId);
                            l1.SubItems.Add("FeedBack");
                        }
                        l1.SubItems.Add(ModelNumberTextBox.Text);
                        l1.SubItems.Add(ProDesTextBox.Text);
                        l1.SubItems.Add(QtyTextBox.Text);
                        l1.SubItems.Add(StockStatusComboBox.Text + " " + textBox2.Text + comboBox3.Text);
                        l1.SubItems.Add(UnitCogsUsdTextBox.Text);
                        l1.SubItems.Add(UnitCogsBdtTextBox.Text);
                        l1.SubItems.Add(MopBdtTextBox.Text);
                        l1.SubItems.Add(CountryComboBox.Text);
                        l1.SubItems.Add(productNameTextBox.Text);
                        l1.SubItems.Add(productCodeTextBox.Text);
                        l1.SubItems.Add(eXWTextBox.Text);
                        listView1.Items.Add(l1);
                        ClearselectedProduct();
                        comboBox1.Enabled = false;
                        ExchangeRateTextBox.Enabled = false;
                    }

                }
            }
            else
            {
                if (StockStatusComboBox.Text == "Invalid Model" || StockStatusComboBox.Text == "Out of Production")
                {
                   
                        if (checkBox1.Checked)
                        {
                            MessageBox.Show("You Can not Add Invalid product When The Checkbox Is Checked");
                        }
                        else
                        {
                            ListViewItem l2 = new ListViewItem(PInquiryId);
                            l2.SubItems.Add("FeedBack");
                            l2.SubItems.Add(ModelNumberTextBox.Text);
                            l2.SubItems.Add(ProDesTextBox.Text);
                            l2.SubItems.Add(QtyTextBox.Text);
                            l2.SubItems.Add(StockStatusComboBox.Text);
                            listView1.Items.Add(l2);
                            ClearselectedProduct();
                        }

                  
                }
                else
                {
                    if ( ValidateSecondControls())
                    {
                        ListViewItem l2;


                        if (checkBox1.Checked)
                        {

                            l2= new ListViewItem("0");
                            l2.SubItems.Add("FeedBack");
                        }
                        else
                        {
                            l2 = new ListViewItem(PInquiryId);
                            l2.SubItems.Add("FeedBack");
                        }
                        l2.SubItems.Add(ModelNumberTextBox.Text);
                        l2.SubItems.Add(ProDesTextBox.Text);
                        l2.SubItems.Add(QtyTextBox.Text);
                        l2.SubItems.Add(CountryComboBox.Text);
                        l2.SubItems.Add(UnitCogsUsdTextBox.Text);
                        l2.SubItems.Add(UnitCogsBdtTextBox.Text);
                        l2.SubItems.Add(MopBdtTextBox.Text);
                        l2.SubItems.Add(StockStatusComboBox.Text + " " + textBox2.Text + comboBox3.Text);
                        l2.SubItems.Add(productNameTextBox.Text);
                        l2.SubItems.Add(productCodeTextBox.Text);
                        l2.SubItems.Add(eXWTextBox.Text);
                        listView1.Items.Add(l2);
                        ClearselectedProduct();
                    }

                }
            }
            }
        
        }
        private bool ValidateSecondControls()
        {
            bool validate = true;
            if (string.IsNullOrWhiteSpace(CountryComboBox.Text))
            {
                validate = false;

                ModelNumberTextBox.Focus();
            }
            else if (string.IsNullOrWhiteSpace(UnitCogsUsdTextBox.Text))
            {
                validate = false;
            }
            else if (string.IsNullOrWhiteSpace(MopBdtTextBox.Text))
            {
                validate = false;
            }
            else if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                validate = false;
            }
            else if (string.IsNullOrWhiteSpace(comboBox3.Text))
            {
                validate = false;
            }
            else if (string.IsNullOrWhiteSpace(productNameTextBox.Text))
            {
                validate = false;
            }
            else if (string.IsNullOrWhiteSpace(productCodeTextBox.Text))
            {
                validate = false;
            }
            else if (string.IsNullOrWhiteSpace(eXWTextBox.Text))
            {
                validate = false;
            }
            return validate;
        }
        private bool ValidateMustControls()
        {
            bool validate = true;
            if (string.IsNullOrWhiteSpace(comboBox1.Text))
            {
                validate = false;
            }
            else if (string.IsNullOrWhiteSpace(ExchangeRateTextBox.Text))
            {
                validate = false;
               UnitCogsUsdTextBox.Clear();
            }
            else if (string.IsNullOrWhiteSpace(ModelNumberTextBox.Text) && !checkBox1.Checked)
            {
                validate = false;

                ModelNumberTextBox.Focus();
            }
            else if (string.IsNullOrWhiteSpace(ProDesTextBox.Text))
            {
                validate = false;
            }
            else if (string.IsNullOrWhiteSpace(QtyTextBox.Text) && !checkBox1.Checked)
            {
                validate = false;
            }
            else if (string.IsNullOrWhiteSpace(StockStatusComboBox.Text))
            {
                validate = false;
            }
            return validate;
        }

        private void ClearselectedProduct()
        {
            if (!checkBox1.Checked)
            {
                foreach (DataGridViewRow dr in dataGridView1.Rows)
                {
                    if (dr.Cells[0].Value.ToString() == PInquiryId)
                    {
                        dataGridView1.Rows.Remove(dr);
                        break;
                    }

                }
            }
            PInquiryId = null;
            ModelNumberTextBox.Clear();
            ProDesTextBox.Clear();
            QtyTextBox.Clear();
            //CountryComboBox.SelectedIndexChanged -= CountryComboBox_SelectedIndexChanged;
            CountryComboBox.SelectedIndex = -1;
            //CountryComboBox.SelectedIndexChanged += CountryComboBox_SelectedIndexChanged;
            UnitCogsUsdTextBox.Clear();
            //ExchangeRateTextBox.Clear();
            UnitCogsBdtTextBox.Clear();
            MopBdtTextBox.Clear();
            StockStatusComboBox.SelectedIndexChanged -= StockStatusComboBox_SelectedIndexChanged;
            StockStatusComboBox.SelectedIndex = -1;
            StockStatusComboBox.SelectedIndexChanged += StockStatusComboBox_SelectedIndexChanged;
            productNameTextBox.Clear();
            productCodeTextBox.Clear();
            eXWTextBox.Clear();
            textBox2.Clear();
            comboBox3.SelectedIndex = -1;
           

        }

        //private void StockStatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    throw new NotImplementedException();
        //}

        private void ExchangeRateTextBox_TextChanged(object sender, EventArgs e)
        {
            //string as = UnitCogsUsdTextBox.Text; v1 = new UnitCogsUsdTextBox();
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            _output = new string(comboBox1.Text.ToCharArray().Where(c => char.IsDigit(c)).ToArray());
            try
            {
                con = new SqlConnection(cs.DBConn);
                con.Open();
                cmd = new SqlCommand("SELECT PInquiryId, Model, ProductDescription, Qty FROM PriceInquiryDetail where PrInId="+_output, con);
                rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                dataGridView1.Rows.Clear();
                while (rdr.Read() == true)
                {
                    dataGridView1.Rows.Add(rdr[0], rdr[1], rdr[2], rdr[3]);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void StockStatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {if(!string.IsNullOrWhiteSpace(StockStatusComboBox.Text))
        {
            if (StockStatusComboBox.Text == @"Indent" || StockStatusComboBox.Text == @"Stock")
        {

            comboBox3.Visible = true;
            textBox2.Visible = true;
            label12.Visible = true;
            label13.Visible = true;
            label14.Visible = true;
            label4.Visible = true;
            //label8.Visible = true;
            label7.Visible = true;
            label6.Visible = true;
            label5.Visible = true;
            label5.Visible = true;
            label11.Visible = true;
            label13.Visible = true;
            label14.Visible = true;
            eXWTextBox.Visible = true;
            MopBdtTextBox.Visible = true;
            UnitCogsBdtTextBox.Visible = true;
            UnitCogsUsdTextBox.Visible = true;
            //ExchangeRateTextBox.Visible = true;
            productNameTextBox.Visible = true;
            productCodeTextBox.Visible = true;
            CountryComboBox.Visible = true;
            
            if (StockStatusComboBox.Text == @"Stock")
            {
                comboBox3.Items.Clear();
                comboBox3.Items.Add("Pcs");
                comboBox3.Items.Add("Kgs");
                label12.Text = @"Available Quantity";
            }
            else
            {
                comboBox3.Items.Clear();
                comboBox3.Items.Add("Days");
                comboBox3.Items.Add("Weeks");
                comboBox3.Items.Add("Months");
                label12.Text = @"Available Within";
            }
          
        }
            else
            {
                comboBox3.Visible = false;
                textBox2.Visible = false;
                label12.Visible = false;
                label4.Visible = false;
                label13.Visible = false;
                label14.Visible = false;
                //label8.Visible = false;
                label7.Visible = false;
                label6.Visible = false;
                label5.Visible = false;
                label5.Visible = false;
                label11.Visible = false;
                eXWTextBox.Visible = false;
                MopBdtTextBox.Visible = false;
                UnitCogsBdtTextBox.Visible = false;
                UnitCogsUsdTextBox.Visible = false;
                //ExchangeRateTextBox.Visible = false;
                productNameTextBox.Visible = false;
                productCodeTextBox.Visible = false;
                CountryComboBox.Visible = false;
                textBox2.Clear();
                eXWTextBox.Clear();
                UnitCogsUsdTextBox.Clear();
                //ExchangeRateTextBox.Clear();
                UnitCogsBdtTextBox.Clear();
                MopBdtTextBox.Clear();
            }
        }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                ClearselectedProduct();
                ProDesTextBox.ReadOnly = true;
            }
            else
            {
                ProDesTextBox.Clear();
                ProDesTextBox.ReadOnly = false;
            }
        }

        private void UnitCogsUsdTextBox_TextChanged(object sender, EventArgs e)
        {
            //UnitCogsBdtTextBox.Text = (UnitCogsUsdTextBox.Text * ExchangeRateTextBox.Text);
            //UnitCogsBdtTextBox.Text = UnitCogsBdtTextBox.ToString();
            decimal val7 = 0;
            decimal val8 = 0;
            decimal val9 = 0;
            decimal.TryParse(UnitCogsUsdTextBox.Text, out val7);
            decimal.TryParse(ExchangeRateTextBox.Text, out val8);
            decimal.TryParse(UnitCogsBdtTextBox.Text, out val9);
            //UnitCogsBdtTextBox.Text = (Convert.ToDecimal(UnitCogsUsdTextBox.Text) * Convert.ToDecimal(ExchangeRateTextBox.Text)).ToString();
            UnitCogsBdtTextBox.Text = (Convert.ToDecimal(val7) * Convert.ToDecimal(val8)).ToString();
        }

        private void DoneButton_Click(object sender, EventArgs e)
        {
            if (ValidateSubmit())
            {
                try
                {

                    con = new SqlConnection(cs.DBConn);
                    con.Open();
                     trans = con.BeginTransaction();
                    string qry =
                        "INSERT INTO InquiryFeedback (ExchangeRate, PrInId, UserId, EntryDate)VALUES  (@d1,@d2,@d3,@d4)" +
                        "SELECT CONVERT(int, SCOPE_IDENTITY())";
                    cmd = new SqlCommand(qry, con, trans);
                    cmd.Parameters.AddWithValue("@d1", ExchangeRateTextBox.Text);
                    cmd.Parameters.AddWithValue("@d2", _output);
                    cmd.Parameters.AddWithValue("@d3", frmLogin.uId2);
                    cmd.Parameters.AddWithValue("@d4", DateTime.UtcNow.ToLocalTime());
                    int FbId = (int) cmd.ExecuteScalar();
                    for (int i = 0; i < listView1.Items.Count; i++)
                    {
                        if (listView1.Items[i].SubItems[5].Text == "Invalid Model" ||
                            listView1.Items[i].SubItems[5].Text == "Out of Production")
                        {
                            string query =
                                "INSERT INTO InquiryFeedbackDetail (PInquiryId, ProductDescription, StockStatus,IFId) VALUES        (@d1,@d2,@d3," +
                                FbId + ")";
                            cmd = new SqlCommand(query, con, trans);
                            cmd.Parameters.AddWithValue("@d1", listView1.Items[i].Text);
                            cmd.Parameters.AddWithValue("@d2", listView1.Items[i].SubItems[2].Text);
                            cmd.Parameters.AddWithValue("@d3", listView1.Items[i].SubItems[5].Text);
                            cmd.ExecuteNonQuery();
                        }
                        else
                        {
                            string pquery =
                                "INSERT INTO ProductListSummary(ProductGenericDescription, ItemDescription, ItemCode, CountryOfOrigin, Price, BrandId, UserId, Entrytime, CurrentRevision)VALUES (@d1,@d2,@d3,@d4,@d5,@d6,@d7,@d8,@d9)" +
                                "SELECT CONVERT(int, SCOPE_IDENTITY())";
                            cmd = new SqlCommand(pquery, con, trans);
                            cmd.Parameters.AddWithValue("@d1", listView1.Items[i].SubItems[10].Text);
                            cmd.Parameters.AddWithValue("@d2", listView1.Items[i].SubItems[3].Text);
                            cmd.Parameters.AddWithValue("@d3", listView1.Items[i].SubItems[11].Text);
                            cmd.Parameters.AddWithValue("@d4", listView1.Items[i].SubItems[9].Text);
                            cmd.Parameters.AddWithValue("@d5", listView1.Items[i].SubItems[8].Text);
                            cmd.Parameters.AddWithValue("@d6", 1);
                            cmd.Parameters.AddWithValue("@d7", frmLogin.uId2);
                            cmd.Parameters.AddWithValue("@d8", DateTime.UtcNow.ToLocalTime());
                            cmd.Parameters.AddWithValue("@d9", 1);
                            int sl = (int) cmd.ExecuteScalar();
                            string cd = "INSERT INTO EXWPrice (Price,Sl) VALUES (@d1,@d2)";
                            cmd = new SqlCommand(cd, con, trans);
                            cmd.Parameters.AddWithValue("@d1", listView1.Items[i].SubItems[12].Text);
                            cmd.Parameters.AddWithValue("@d2", sl);
                            //con.Open();
                            cmd.ExecuteNonQuery();
                            string query =
                                "INSERT INTO InquiryFeedbackDetail  (PInquiryId, ProductDescription,StockStatus, IFId, UnitCogsUsd,  Sl )VALUES        (@d1,@d2,@d3," +
                                FbId + ",@d4,@d5)";
                            cmd = new SqlCommand(query, con, trans);
                            cmd.Parameters.AddWithValue("@d1", (listView1.Items[i].Text == "0") ? (object)DBNull.Value : listView1.Items[i].Text);
                            cmd.Parameters.AddWithValue("@d2", listView1.Items[i].SubItems[2].Text);
                            cmd.Parameters.AddWithValue("@d3", listView1.Items[i].SubItems[6].Text);
                            cmd.Parameters.AddWithValue("@d4", listView1.Items[i].SubItems[5].Text);
                            cmd.Parameters.AddWithValue("@d5",sl);
                            cmd.ExecuteNonQuery();

                        }
                    }
                  trans.Commit();
                    MessageBox.Show("Saved SuccessFully");
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message,"RolleBack");
                    trans.Rollback();
                }
            }
        }

        private bool ValidateSubmit()
        {
            bool validate = true;
            if (listView1.Items.Count < 1)
            {
                validate = false;
            }
            else if (dataGridView1.RowCount != 0)
            {
                validate = false;
            }
            else if (!String.IsNullOrWhiteSpace(ModelNumberTextBox.Text) || !String.IsNullOrWhiteSpace(QtyTextBox.Text) ||
                     !String.IsNullOrWhiteSpace(StockStatusComboBox.Text) || !String.IsNullOrWhiteSpace(textBox2.Text) ||
                     !String.IsNullOrWhiteSpace(comboBox3.Text) || !String.IsNullOrWhiteSpace(CountryComboBox.Text) ||
                     !String.IsNullOrWhiteSpace(eXWTextBox.Text) || !String.IsNullOrWhiteSpace(UnitCogsUsdTextBox.Text) ||
                     !String.IsNullOrWhiteSpace(UnitCogsBdtTextBox.Text) || !String.IsNullOrWhiteSpace(MopBdtTextBox.Text) ||
                     !String.IsNullOrWhiteSpace(productNameTextBox.Text) || !String.IsNullOrWhiteSpace(productCodeTextBox.Text))
            {
                MessageBox.Show(@"You Forgot to add " + "\r \n" + @" Add first or clear these");
                validate = false;
            }
            return validate;
        }
    }
}
