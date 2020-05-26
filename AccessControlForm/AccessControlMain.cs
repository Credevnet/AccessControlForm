using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccessControlForm
{
    public partial class AccessControlMain : Form
    {
        SqlConnection con = new SqlConnection(" Data Source=CALEB;Initial Catalog=AccessControlDB;Integrated Security=True ");
        
       

        public AccessControlMain()
        {
            InitializeComponent();
        }

        private void AccessControlMain_Load(object sender, EventArgs e)
        {
            
        }

        private void bunifuMetroTextbox2_OnValueChanged(object sender, EventArgs e)
        {

        }


        public void CheckIn()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into CompanyLog(CardNumber,Name,Status,TimeIn) Values(@CardNumber, @Name, @Status, @TimeIn) ", con);
            cmd.Parameters.AddWithValue("@CardNumber", txtBarcode.Text);
            cmd.Parameters.AddWithValue("@Name", txtName.Text);
            cmd.Parameters.AddWithValue("@Status", txtStatus.Text);
            cmd.Parameters.AddWithValue("@TimeIn", DateTime.Now.ToShortTimeString());

            MessageBox.Show("Login Successful");
            cmd.ExecuteNonQuery();
            con.Close();
            
        }


        /* public void CheckIn()
         {
             con.Open();
             SqlCommand cmd = new SqlCommand("Select * from CompanyLog where CardNumber =@txtBarcode", con);
             cmd.Parameters.AddWithValue("@CardNumber", txtBarcode.Text);
             cmd.Parameters.AddWithValue("@Name", txtName.Text);
             cmd.Parameters.AddWithValue("@Status", txtStatus.Text);
             cmd.Parameters.AddWithValue("@TimeIn", DateTime.Now);

             //SqlCommand cmd = new SqlCommand(" select * from CompanyLog where txtBarcode =@CardNumber", con);
             //SqlCommand cmd = new SqlCommand("Select * from CompanyLog where CardNumber =@barCode", con);
         }
         */
        public void CheckOut()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into CompanyLog(CardNumber,Name,Status,TimeOut) Values(@CardNumber, @Name, @Status, @TimeOut) ", con);
            cmd.Parameters.AddWithValue("@CardNumber", txtBarcode.Text);
            cmd.Parameters.AddWithValue("@Name", txtName.Text);
            cmd.Parameters.AddWithValue("@Status", txtStatus.Text);
            cmd.Parameters.AddWithValue("@TimeOut", DateTime.Now.ToLocalTime());


            MessageBox.Show("Logged out!"); 

            cmd.ExecuteNonQuery();
            con.Close();

            //SqlCommand cmd = new SqlCommand("Update CompanyLog set Status = CheckOut ", con);
            //cmd.Parameters.AddWithValue("@Status", txtStatus.Text);


        }
         
        
        /*public void StatusCheck()
        {
            string BarCode = txtBarcode.Text;
            con.Open();
            SqlCommand cmd = new SqlCommand("Update CompanyLog set Status = 'Absent' where BarCode =@CardNumber ");
                cmd.Parameters.AddWithValue("@CardNumber", txtBarcode.Text);
            con.Close();
            

        }
        */


        private void bunifuMetroTextbox3_OnValueChanged(object sender, EventArgs e)
        {

        }
        private void txtBarcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                CheckIn();
            }
            
        }

        private void bunifuMetroTextbox5_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
