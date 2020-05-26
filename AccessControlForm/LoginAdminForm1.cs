using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace AccessControlForm
{
    public partial class LoginAdminForm1 : DevComponents.DotNetBar.RibbonForm
    {
        SqlConnection con = new SqlConnection();
        public LoginAdminForm1()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = " Data Source=CALEB;Initial Catalog=AccessControlDB;Integrated Security=True ";
            InitializeComponent();
        }

        private void LoginAdminForm1_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=CALEB;Initial Catalog=AccessControlDB;Integrated Security=True ");
            con.Open();
            {
            }

        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {
            
        }
        public void login()
        {
            SqlConnection con = new SqlConnection("Data Source=CALEB;Initial Catalog=AccessControlDB;Integrated Security=True");
            //con.ConnectionString = " Data Source=CALEB;Initial Catalog=AccessControlDB;Integrated Security=True";
            con.Open();
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            //SqlCommand cmd = new SqlCommand("Select * from AdminLogin where Username ='" + txtUserName.Text + "'and password ='" + txtPassword.Text + "'", con);
            SqlCommand cmd = new SqlCommand("Select * from AdminLogin where Username =@Username and password =@password", con);
            cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
            cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmd.ExecuteNonQuery();
            if (dt.Rows.Count > 0)
            {
                AccessControlMain Mainform = new AccessControlMain();
                Mainform.ShowDialog();
                // this.Hide();
                this.Close();
                //  MessageBox.Show("Login Successful");
                // System.Diagnostics.Process.Start("AccessControlForm");
            }
            else
            {

                MessageBox.Show("Invalid Username or password");
            }
            con.Close();

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            login();
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                login();
            }
        }

        private void bunifuCheckbox1_OnChange(object sender, EventArgs e)
        {

        }

        private void bunifuCheckbox1_MouseDown(object sender, MouseEventArgs e)
       {

        }
    }
}