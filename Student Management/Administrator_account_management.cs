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
    public partial class Administrator_account_management : Form
    {
        public Administrator_account_management()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=access;Integrated Security=true");
        SqlDataAdapter da;
        SqlCommandBuilder cmb;
        DataSet ds = new DataSet();
        private void Administrator_account_management_Load(object sender, EventArgs e)
        {
            ds.Clear();
            da = new SqlDataAdapter("select * from admin", conn);
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmb = new SqlCommandBuilder(da);
            da.Update(ds);
            ds.AcceptChanges();
            MessageBox.Show("Record Changed", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}