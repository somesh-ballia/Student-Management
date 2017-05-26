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
    public partial class LoGBook : Form
    {
        public LoGBook()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=access;Integrated Security=true");       
        SqlDataAdapter da;
        SqlCommandBuilder cmb;
        DataSet ds = new DataSet();
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoGBook obj = new LoGBook();
            obj.Show();
            this.Close();
            
        }

        private void LoGBook_Load(object sender, EventArgs e)
        {
            switch (Program.log)
            {
                case 1:
                    try
                    {
                        label3.Text = "STUDENT LOG";
                        ds.Clear();
                        da = new SqlDataAdapter("select * from StudentLog", conn);
                        da.Fill(ds);
                        dataGridView1.DataSource = ds.Tables[0];
                    }
                    catch( Exception ex)
                    {
                        MessageBox.Show(ex.Message, "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.Close();

                    }

                    break;

                case 2:

                    try
                    {
                        label3.Text = "EMPLOYEE LOG";
                        ds.Clear();
                        da = new SqlDataAdapter("select * from EmployeeLog", conn);
                        da.Fill(ds);
                        dataGridView1.DataSource = ds.Tables[0];
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message, "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.Close();
                    }
                    break;

                case 3:

                    try
                    {
                        label3.Text = "VISITOR LOG";
                        ds.Clear();
                        da = new SqlDataAdapter("select * from VisitorLog", conn);
                        da.Fill(ds);
                        dataGridView1.DataSource = ds.Tables[0];
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message, "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.Close();
                    }
                    break;

                case 4:

                    try
                    {
                        label3.Text = "LEAVE LOG";
                        ds.Clear();
                        da = new SqlDataAdapter("select * from LeaveLog", conn);
                        da.Fill(ds);
                        dataGridView1.DataSource = ds.Tables[0];
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message, "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.Close();
                    }
                    break;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            try
            {
                cmb = new SqlCommandBuilder(da);
                da.Update(ds);
                ds.AcceptChanges();
                MessageBox.Show("Record Updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}