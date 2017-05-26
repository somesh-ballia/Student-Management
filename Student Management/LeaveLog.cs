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
    public partial class LeaveLog : Form
    {
        public LeaveLog()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=access;Integrated Security=true");
        SqlCommand cmd;
        string test = "";
        private void button1_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("insert into LeaveLog values('" + textBox1.Text.Trim() + "','" + textBox2.Text.Trim() + "','" + textBox3.Text.Trim() + "','" + richTextBox1.Text.Trim() + "','" + System.DateTime.Today + "','" + dateTimePicker1.Text + "','" + test + "')", conn);
            try
            {
                if (textBox1.Text.Length != 0 && richTextBox1.Text.Length != 0 && textBox3.Text.Length != 0)
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show(" Record inserted successfully");
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    richTextBox1.Clear();
                }
                else
                {
                    MessageBox.Show("Some Of The Importent Fields Are Empty");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}