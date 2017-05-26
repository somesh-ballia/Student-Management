using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Student_Management
{
    public partial class LogOut : Form
    {
        public LogOut()
        {
            InitializeComponent();
        }
        int LogInfo;
        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=access;Integrated Security=true");
        SqlCommand cmd;
        DateTime time = new DateTime();
        private void button1_Click(object sender, EventArgs e)
        {
            time = System.DateTime.Now;
            textBox1.Text = textBox1.Text.Trim().ToUpper();
            if (textBox1.Text.Length == 0)
            {
                MessageBox.Show("No Code Name Found", "Warning", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
            else
            {

                switch (LogInfo)
                {
                    case 1:
                        try
                        {
                            conn.Open();
                            SqlParameter p1 = new SqlParameter("@time", SqlDbType.DateTime, 100);
                            SqlParameter p2 = new SqlParameter("@cname", SqlDbType.VarChar, 100);
                            p1.Direction = ParameterDirection.Input;
                            p2.Direction = ParameterDirection.Input;    
                            try
                            {
                                p2.Value = textBox1.Text.Trim();
                                p1.Value = time;
                            }
                            catch
                            {
                                MessageBox.Show("Please Input The Code Name");
                            }
                            cmd = new SqlCommand("insert into StudentLog values @time=In_Time where Student_code=@cname", conn);
                            cmd.Parameters.Add(p1);
                            cmd.Parameters.Add(p2);
                            MessageBox.Show("Student");
                            conn.Close();
                        }
                        catch (Exception Ex)
                        {
                            MessageBox.Show(Ex.Message);
                        }                        
                        break;
                    case 2:
                        























                        MessageBox.Show("Employee");
                        break;
                    case 3:
                        
                        MessageBox.Show("Visitor");
                        break;
                    case 4:
                       
                        MessageBox.Show("Leave");
                        break;
                }
                this.Close();
            }
        }

        private void LogOut_Load(object sender, EventArgs e)
        {
            LogInfo = Program.log;

           
        }
    }
}