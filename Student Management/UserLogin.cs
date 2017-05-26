using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Student_Management
{
    public partial class UserLogin : Form
    {
        public UserLogin()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=access;Integrated Security=true");
        SqlCommand cmd;
        String user;
        String pass;
        private void button1_Click(object sender, EventArgs e)
        {
            String usercheck = "",paswordcheck ="";
            try
            {
                conn.Open();
                SqlParameter p1 = new SqlParameter("@user", SqlDbType.VarChar, 100);
                p1.Direction = ParameterDirection.Output;
                SqlParameter p2 = new SqlParameter("@pass", SqlDbType.VarChar, 100);
                p2.Direction = ParameterDirection.Output;
                SqlParameter p3 = new SqlParameter("@userc", SqlDbType.VarChar, 100);
                p3.Direction = ParameterDirection.Input;
                user = textBox1.Text.Trim();
                p3.Value = textBox1.Text.Trim();
                pass = textBox2.Text.Trim();
                if (user.Length == 0)
                {
                    MessageBox.Show("Please Input The User Name", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    MessageBox.Show("Program Will Exit Now", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Application.Exit();
                }
                else
                {
                    if (pass.Length == 0)
                    {
                        MessageBox.Show("Please Input The Password", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                }
                cmd = new SqlCommand("select @user=UserName,@pass=PasswordP from guest where UserName=@userc", conn);
                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);
                cmd.Parameters.Add(p3);
                cmd.ExecuteNonQuery();
                usercheck = p1.Value.ToString();
                paswordcheck = p2.Value.ToString();
                conn.Close();
            }
            catch (SqlException)
            {
                MessageBox.Show("Problem occoured with the Server , Please Check The Setings Of The Server", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
            if (user == usercheck && pass == paswordcheck)
            {
                MessageBox.Show("Welcome " + textBox1.Text.Trim(), "WELCOME", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Workpage obj = new Workpage();
                obj.Show();
                Program.UserName = user;
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid User Name or Password", "WARINING", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                textBox1.Clear();
                textBox2.Clear();

            }
            
        }
        private void UserLogin_Load(object sender, EventArgs e)
        {
            
        }
    }
}