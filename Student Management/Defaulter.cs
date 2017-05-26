using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Student_Management
{
    public partial class Defaulter : Form
    {
        public Defaulter()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DefaulterDatabase obj = new DefaulterDatabase();
            obj.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddDefaulter obj = new AddDefaulter();
            obj.Show();
            this.Close();
        }   
    }
}