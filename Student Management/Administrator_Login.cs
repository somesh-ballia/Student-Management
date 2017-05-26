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
    public partial class Administrator_Login : Form
    {
        public Administrator_Login()
        {
            InitializeComponent();
        }
        private void Administrator_Login_Load(object sender, EventArgs e)
        {
            if (Program.check == 1)
            {
                label1.Text = "          USER LOGIN";
                
            }
        }
       private void button1_Click(object sender, EventArgs e)
        {
            login_adm obj = new login_adm();
            obj.Show(); 

           /*
           String user="" ;
            String pass="";
            String usercheck="", paswordcheck="";
            
            try
            {
                user = textBox1.Text.Trim();
            }
            catch
            {
                MessageBox.Show("Please Input The User Name");
            }
            try
            {
                pass = textBox2.Text.Trim();
            }
            catch
            {
                MessageBox.Show("Please Input The Password");
            }
            if (Program.check == 1)
            {
                SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=access;Integrated Security=true");
                SqlCommand cmd;
                try
                {
                    conn.Open();
                    SqlParameter p1 = new SqlParameter("@user", SqlDbType.VarChar, 100);
                    p1.Direction = ParameterDirection.Output;
                    SqlParameter p2 = new SqlParameter("@pass", SqlDbType.VarChar, 100);
                    p2.Direction = ParameterDirection.Output;
                    cmd = new SqlCommand("select @user =UserName,@pass =Password from admin", conn);
                    cmd.Parameters.Add(p1);
                    cmd.Parameters.Add(p2);
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
                    login_adm obj = new login_adm();
                    obj.Show();
                    MessageBox.Show("Welcome " + textBox1.Text.Trim(), "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Program.UserName = user;
                    textBox2.Clear();
                    textBox1.Clear();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid User Name or Password", "WARINING", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                    textBox2.Clear();
                    textBox1.Clear();
                }
            }
            else
            {
                SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=access;Integrated Security=true");
                SqlCommand cmd;
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
                    Program.UserName = user;
                    obj.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid User Name or Password", "WARINING", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                    textBox1.Clear();
                    textBox2.Clear();

                }
            }
           */
        }

    }
}