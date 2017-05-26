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
    public partial class EmployeeLog : Form
    {
        public EmployeeLog()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=access;Integrated Security=true");
        SqlCommand cmd;
        
        private void button1_Click(object sender, EventArgs e)
        {
            string test = "";
            String Name = "";
            String Designation="";
            // Finding details of The employee from database
            if (textBox1.Text.Length != 0)
            {
                try
                {
                    conn.Open();
                    SqlParameter p2 = new SqlParameter("@cname", SqlDbType.VarChar, 100);
                    p2.Value = textBox1.Text.Trim();
                    SqlParameter p1 = new SqlParameter("@Name", SqlDbType.VarChar, 100);
                    p1.Direction = ParameterDirection.Output;
                    SqlParameter p3 = new SqlParameter("@Designation", SqlDbType.VarChar, 100);
                    p3.Direction = ParameterDirection.Output;
                    cmd = new SqlCommand("select @Name=EmployeeName,@Designation=Post from EmployeeList where EmployeeID=@cname", conn);
                    cmd.Parameters.Add(p2);
                    cmd.Parameters.Add(p1);
                    cmd.Parameters.Add(p3);
                    cmd.ExecuteNonQuery();
                    Name = p1.Value.ToString();                    
                    Designation = p3.Value.ToString();                    
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            // insetring details
                if (Name.Length != 0 && Designation.Length != 0)
                {

                    cmd = new SqlCommand("insert into EmployeeLog values('" + textBox1.Text.Trim() + "','" + Name + "','" + Designation + "','" + System.DateTime.Today + "','" + dateTimePicker1.Text + "','" + test + "')", conn);
                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show(" Record inserted successfully");
                        textBox1.Clear();
                        this.Close();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Code Name Not Valid");
                }
        }
        else
        {
            MessageBox.Show("Employee Code Not Inserted");
        }
           
        }

       
    }
}