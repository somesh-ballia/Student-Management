using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Student_Management
{
    public partial class Password_Management : Form
    {
        public Password_Management()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Administrator_account_management obj = new Administrator_account_management();
            obj.Show();
            this.Close();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            User_Account_Management obj = new User_Account_Management();
            obj.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            login_adm obj = new login_adm();
            obj.Show();
            this.Close();
        }
    }
}