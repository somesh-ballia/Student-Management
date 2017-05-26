using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Student_Management
{
    public partial class login_adm : Form
    {
        public login_adm()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Password_Management obj = new Password_Management();
            obj.Show();
            this.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Workpage obj = new Workpage();
            obj.Show();
            this.Close();
        }
        
        
        private void login_adm_Load(object sender, EventArgs e)
        {

        }
    }
}