using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Student_Management
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Program.check = 2;
            Administrator_Login obj = new Administrator_Login();
            obj.Show();
            Program.check = 1;
            button1.Enabled = false;
            button2.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
         {
           
             Program.check = 1;
             Administrator_Login obj = new Administrator_Login();
             obj.Show();
             Program.check = 2;
             button1.Enabled = false;
             button2.Enabled = false;
         }
       private void MainScreen_Load(object sender, EventArgs e)
        {
            
        }
      private void MainScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
        }
    }
}