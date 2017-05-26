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
    public partial class EmergencyDatabase : Form
    {
        public EmergencyDatabase()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=access;Integrated Security=true");
        SqlDataAdapter da;  
        DataSet ds = new DataSet();       

        private void EmergencyDatabase_Load(object sender, EventArgs e)
        {
            try
            {
                ds.Clear();
                da = new SqlDataAdapter("select * from Emergency", conn);
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch
            {
                MessageBox.Show("A Problem Occoured With The Data Server Check Server Settings", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}