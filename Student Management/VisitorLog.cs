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
    public partial class VisitorLog : Form
    {
        public VisitorLog()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=access;Integrated Security=true");
        SqlCommand cmd;
        string test = "";
        string ID1="";
        string NAME="";
        private void button1_Click(object sender, EventArgs e)
        {
            ID1 = "";
                // Inserting
            MessageBox.Show(ID1);
                cmd = new SqlCommand("insert into VisitorLog values('" + textBox1.Text.Trim() + "','" + textBox2.Text.Trim() + "','" + textBox3.Text.Trim() + "','" + textBox4.Text.Trim() + "','" + textBox5.Text.Trim() + "','" + textBox6.Text.Trim() + "','" + dateTimePicker1.Text + "','" + test + "','" + System.DateTime.Today.ToString() + "','" + ID1.ToString() + "')", conn);
                try
                {
                    if (textBox1.Text.Length != 0 && textBox2.Text.Length != 0 && textBox4.Text.Length != 0)
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show(" Record inserted successfully");
                        textBox1.Clear();
                        textBox2.Clear();
                        textBox3.Clear();
                        textBox4.Clear();
                        textBox5.Clear();
                        textBox6.Clear();
                        this.Close();
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