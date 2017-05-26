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
    public partial class Backup : Form
    {
        public Backup()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=access;Integrated Security=true");
            SqlDataAdapter da;
            SqlDataAdapter da1;
            DataSet ds = new DataSet();
            DataSet ds1 = new DataSet();
            da = new SqlDataAdapter("select * from admin", "Data Source=.;Initial Catalog=access;Integrated Security=true");
            da.Fill(ds);
            da1 = new SqlDataAdapter("select * from guest", "Data Source=.;Initial Catalog=access;Integrated Security=true");
            da1.Fill(ds1);
            label14.Dispose();
            label1.Text = "CONNECTING TO SERVER........................................";
            label2.Text = "CONNECTING TO DATABASE......................................";
            label3.Text = "READING PASSWORD FILES......................................";
            label4.Text = "WRITING ADMINISTRATOR FILES TO C:\\.........................";
            ds.WriteXml("C:\\ADMINISTRATOR.xml");
            label5.Text = "CLOSING CONNECTION..........................................";
            label6.Text = "CONNECTING TO SERVER........................................";
            label7.Text = "CONNECTING TO DATABASE......................................";
            label8.Text = "READING PASSWORD FILES......................................";
            label9.Text = "WRITING USER ACCESS FILES TO C:\\...........................";
            ds1.WriteXml("C:\\USER.xml");
            label10.Text = "CLOSING CONNECTION.........................................";
            label11.Text = "ALL TRANSECTION COMPLETE...................................";
            label12.Text = "YOU CAN CLOSE THE WINDOW NOW...............................";

        }
    }
}