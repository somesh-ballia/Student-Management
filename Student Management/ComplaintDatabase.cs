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
    public partial class ComplaintDatabase : Form
    {
        public ComplaintDatabase()
        {
            InitializeComponent();
        } 
        SqlCommandBuilder cmb;
        int index;
        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=access;Integrated Security=true");
        SqlDataAdapter da;        
        DataSet ds = new DataSet();
        int index1;
        private void ComplaintDatabase_Load(object sender, EventArgs e)
        {
            try
            {
                ds.Clear();
                da = new SqlDataAdapter("select * from Complaint", conn);
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch
            {
                MessageBox.Show("A Problem Occoured With The Data Server Check Server Settings", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            index1 = e.RowIndex;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ds.Tables[0].Rows[index1][5] = " Checked";
            cmb = new SqlCommandBuilder(da);
            da.Update(ds);
            ds.AcceptChanges();
            MessageBox.Show("Complaint Checked");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index1 = e.RowIndex;
        }
    }
}