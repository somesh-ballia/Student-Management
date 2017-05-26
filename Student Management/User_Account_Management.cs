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
    public partial class User_Account_Management : Form
    {
        public User_Account_Management()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=access;Integrated Security=true");
        SqlDataAdapter da;
        SqlCommandBuilder cmb;
        DataSet ds = new DataSet();
        private void User_Account_Management_Load(object sender, EventArgs e)
        {
            ds.Clear();
            da = new SqlDataAdapter("select * from guest", conn);
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];   
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmb = new SqlCommandBuilder(da);
            da.Update(ds);
            ds.AcceptChanges();
            MessageBox.Show("Record's Changed", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
           
        }
        int rindex = 0;
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            rindex = e.RowIndex;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cmb = new SqlCommandBuilder(da);
            ds.Tables[0].Rows[rindex].Delete();
            da.Update(ds);
            ds.AcceptChanges();
            MessageBox.Show("Row has been Deleted", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}