using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using ProductManagementSystem.DbGateway;
using ProductManagementSystem.UI;

namespace ProductManagementSystem.LogInUI
{
    public partial class frmLogin : Form
    {
        private SqlConnection con;
        private SqlCommand cmd;
        private SqlDataAdapter sda;
        private SqlDataReader rdr;
        ConnectionString cs=new ConnectionString();
         public static string userType, userName, readyPassword, dbUserName, dbPassword;
        public  static int uId2;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "")
            {
                MessageBox.Show("Please enter user name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUserName.Focus();
                return;
            }
            if (txtPassword.Text == "")
            {
                MessageBox.Show("Please enter password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Focus();
                return;
            }
            //try
            //{
                //
                string clearText = txtPassword.Text.Trim();
                string password = clearText;
                byte[] bytes = Encoding.Unicode.GetBytes(password);
                byte[] inArray = HashAlgorithm.Create("SHA1").ComputeHash(bytes);
                string readyPassword1 = Convert.ToBase64String(inArray);
                readyPassword = readyPassword1;


                con = new SqlConnection(cs.DBConn);
                con.Open();
                string qry = "SELECT UserName,Password FROM Registration WHERE UserName = '" + txtUserName.Text +
                             "' AND Password = '" + readyPassword + "'";
                cmd = new SqlCommand(qry, con);
                rdr = cmd.ExecuteReader();
                if (rdr.Read() == true)
                {
                    dbUserName = (rdr.GetString(0));
                    dbPassword = (rdr.GetString(1));


                    con = new SqlConnection(cs.DBConn);
                    con.Open();
                    string ct = "select UserType,UserId from Registration where UserName='" + txtUserName.Text +
                                "' and Password='" + readyPassword + "'";
                    cmd = new SqlCommand(ct);
                    cmd.Connection = con;
                    rdr = cmd.ExecuteReader();
                    if (rdr.Read())
                    {
                        userType = (rdr.GetString(0));
                        uId2 = (rdr.GetInt32(1));
                    }
                    if ((rdr != null))
                    {
                        rdr.Close();
                    }

                    if (dbUserName == txtUserName.Text && dbPassword == readyPassword && userType.Trim() == "Admin")
                    {
                        this.Hide();
                        MainUI1 frm = new MainUI1();
                        frm.Show();
                        //this.Visible = false;
                        //frm.ShowDialog();
                        frm.lblUser.Text = txtUserName.Text;
                        //this.Visible = true;
                        txtPassword.Clear();
                        txtUserName.Clear();

                    }
                }


                else
                {
                    MessageBox.Show("Login is Failed...Try again !", "Login Denied", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    txtUserName.Clear();
                    txtPassword.Clear();
                    txtUserName.Focus();

                }
                if (con.State == ConnectionState.Open)
                {
                    con.Dispose();
                }
                //
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPassword.Focus();
                e.Handled = true;
            }
        }

        //private void txtPassword_TextChanged(object sender, EventArgs e)
        //{

        //}

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loginButton_Click(this, new EventArgs());
            }
        }
    }
}
