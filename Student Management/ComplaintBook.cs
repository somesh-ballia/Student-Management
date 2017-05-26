using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Student_Management
{
    public partial class ComplaintBook : Form
    {
        public ComplaintBook()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ComplaintCreate obj = new ComplaintCreate();
            obj.Show();
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ComplaintDatabase obj = new ComplaintDatabase();
            obj.Show();
            this.Close();
        }
    }
}