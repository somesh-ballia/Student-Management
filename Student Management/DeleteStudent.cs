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
    public partial class DeleteStudent : Form
    {
        public DeleteStudent()
        {
            InitializeComponent();
        }
        int index;
        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=access;Integrated Security=true");
        SqlDataAdapter da;
        SqlCommandBuilder cmb;
        DataSet ds = new DataSet();
        private void DeleteStudent_Load(object sender, EventArgs e)
        {
            try
            {
                ds.Clear();
                da = new SqlDataAdapter("select * from StudentList", conn);
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch
            {
                MessageBox.Show("A Problem Occoured With The Data Server Check Server Settings","MESSAGE",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                this.Close();

            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cmb = new SqlCommandBuilder(da);
            da.Update(ds);
            ds.AcceptChanges();
            MessageBox.Show("Record Updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            index = e.RowIndex;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you Sure You Want To Delete The Items","MESSAGE", MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            
            {

            }
            cmb = new SqlCommandBuilder(da);
            try
            {
                ds.Tables[0].Rows[index].Delete();
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Nothing To Delete", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
                da.Update(ds);
            ds.AcceptChanges();
            MessageBox.Show("Row has been Deleted", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}