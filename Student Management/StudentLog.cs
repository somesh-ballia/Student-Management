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
    public partial class StudentLog : Form
    {
        public StudentLog()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=access;Integrated Security=true");
        SqlCommand cmd;
        DateTime date = new DateTime();
        DateTime time = new DateTime();
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            date = dateTimePicker1.Value.Date;
            time = System.DateTime.Now;
            textBox1.Text = textBox1.Text.Trim().ToUpper();
            textBox2.Text = textBox2.Text.Trim().ToUpper();
            string code = " Out";
            if (textBox1.Text.Length == 0)
            {
                MessageBox.Show("No Code Name Found", "Warning", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
            else
            {
                if (textBox2.Text.Length == 0)
                {
                    MessageBox.Show("No Place Found", "Warning", MessageBoxButtons.RetryCancel);
                }
                else
                {
                    cmd = new SqlCommand("insert into StudentLog values('" + textBox1.Text.Trim() + "','" + textBox2.Text.Trim() + "','" + System.DateTime.Today + "','" + dateTimePicker1.Text + "','" + code + "')", conn);
                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show(" Record inserted successfully");
                        textBox1.Clear();
                        textBox2.Clear();                      

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        conn.Close();
                        this.Close();
                    }

                }

            }

            this.Close();
        }
    }
}