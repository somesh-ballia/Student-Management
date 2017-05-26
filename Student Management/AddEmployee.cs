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
    public partial class AddEmployee : Form
    {
        public AddEmployee()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=access;Integrated Security=true");
        SqlCommand cmd;
        DateTime date = new DateTime();
        private void button2_Click(object sender, EventArgs e)
        {
                date = dateTimePicker1.Value.Date;
                textBox1.Text = textBox1.Text.Trim().ToUpper();
                textBox2.Text = textBox2.Text.Trim().ToUpper();
                textBox3.Text = textBox3.Text.Trim();
                textBox4.Text = textBox4.Text.Trim().ToUpper();
                richTextBox1.Text = richTextBox1.Text.Trim().ToUpper();
                if (textBox1.Text.Length == 0)
                {
                    MessageBox.Show("No Employee ID Found", "Warning", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                }
                else
                {
                    if (textBox2.Text.Length == 0)
                    {
                        MessageBox.Show("No Employee Name Found", "Warning", MessageBoxButtons.RetryCancel);
                    }
                    else
                    {
                        if (textBox3.Text.Length == 0)
                        {
                            MessageBox.Show("No Phone Number Found", "Warning", MessageBoxButtons.RetryCancel);
                        }
                        else
                        {
                            if (textBox4.Text.Length == 0)
                            {
                                MessageBox.Show("No Post Found", "Warning", MessageBoxButtons.RetryCancel);
                            }
                            else
                            {
                                if (richTextBox1.Text.Length == 0)
                                {
                                    MessageBox.Show("No Address Found", "Warning", MessageBoxButtons.RetryCancel);
                                }
                                else
                                {

                                    cmd = new SqlCommand("insert into EmployeeList values('" + date + "','" + textBox1.Text.Trim() + "','" + textBox2.Text.Trim() + "','" + textBox3.Text.Trim() + "','" + textBox4.Text.Trim() + "','" + richTextBox1.Text.Trim() + "')", conn);
                                    try
                                    {
                                        conn.Open();
                                        cmd.ExecuteNonQuery();
                                        conn.Close();
                                        MessageBox.Show(" Record inserted successfully");
                                        textBox1.Clear();
                                        textBox2.Clear();
                                        textBox3.Clear();
                                        textBox4.Clear();
                                        richTextBox1.Clear();

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

                        }
                    }
                }
                             
                                
                          

        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {

        }
    }
}