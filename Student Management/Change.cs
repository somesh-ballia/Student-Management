using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Student_Management
{
    public partial class Change : Form
    {
        public Change()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Program.Change = 1;
            DataEditor obj = new DataEditor();
            obj.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.Change = 2;
            DataEditor obj = new DataEditor();
            obj.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddPhoneNumber obj = new AddPhoneNumber();
            obj.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddEmergencyData obj = new AddEmergencyData();
            obj.Show();
            this.Close();
        }
    }
}