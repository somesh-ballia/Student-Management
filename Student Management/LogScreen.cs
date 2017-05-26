using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Student_Management
{
    public partial class LogScreen : Form
    {
        public LogScreen()
        {
            InitializeComponent();
        }
        int LogInfo;

        private void button1_Click(object sender, EventArgs e)
        {
            switch (LogInfo)
            {
                case 1:
                          StudentLog obj = new StudentLog();
                          obj.Show();
                          break;
                case 2 :
                          EmployeeLog obj1 = new EmployeeLog();
                          obj1.Show();
                          break;
                case 3:
                          VisitorLog obj2 = new VisitorLog();
                          obj2.Show();
                          break;
                case 4:
                          LeaveLog obj3 = new LeaveLog();
                          obj3.Show();
                          break;
            }
             this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LogOut obj = new LogOut();
            obj.Show();
            this.Close();
        }

        private void Visitor_Load(object sender, EventArgs e)
        {
            LogInfo = Program.log;
        }
        
    }
}