using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.IO;
using System.Data.SqlClient;

namespace Student_Management
{
    public partial class Workpage : Form
    {
        public Workpage()
        {
            InitializeComponent();
        }
        int check;
        string user;
        int index;
        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=access;Integrated Security=true");
        SqlDataAdapter da;        
        SqlCommandBuilder cmb;
        DataSet ds = new DataSet();
        DataSet ds1 = new DataSet();
        private void Workpage_Load(object sender, EventArgs e)
        {
            check = Program.check;
            user = Program.UserName;
            if (check == 2)
            {
               // User login is used
                textBox1.Text = user;
                textBox1.Show();
                button1.Enabled = false;
            }
            else
            {
                // Administrator was used
                textBox1.Text = user;
                textBox1.Show();
                
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
           
            try
            {
                pictureBox1.Hide();
                richTextBox1.Show();         
                richTextBox1.Text = "CONNECTING TO SERVER........................................\n";
                richTextBox1.AppendText( "CONNECTING TO DATABASE...................................... \n");
                richTextBox1.AppendText( "READING PASSWORD FILES......................................\n");
                richTextBox1.AppendText("WRITING ADMINISTRATOR FILES TO C:\\ADMINISTRATOR.xml..........\n");
                da = new SqlDataAdapter("select * from admin", "Data Source=.;Initial Catalog=access;Integrated Security=true");
                da.Fill(ds);
                ds.WriteXml("C:\\ADMINISTRATOR.xml");
                richTextBox1.AppendText( "CLOSING CONNECTION..........................................\n");
                richTextBox1.AppendText("\n \n \n");

                richTextBox1.AppendText( "CONNECTING TO SERVER........................................\n");
                richTextBox1.AppendText( "CONNECTING TO DATABASE......................................\n");
                richTextBox1.AppendText( "READING PASSWORD FILES......................................\n");
                richTextBox1.AppendText("WRITING USER ACCESS FILES TO C:\\USER.xml....................\n");
                ds.Clear();
                da = new SqlDataAdapter("select * from guest", "Data Source=.;Initial Catalog=access;Integrated Security=true");
                da.Fill(ds);
                ds.WriteXml("C:\\USER.xml");
                richTextBox1.AppendText( "CLOSING CONNECTION.........................................\n");
                richTextBox1.AppendText("\n \n \n");


                richTextBox1.AppendText("CONNECTING TO SERVER........................................\n");
                richTextBox1.AppendText("CONNECTING TO DATABASE......................................\n");
                richTextBox1.AppendText("READING COMPLAINT FILES......................................\n");
                richTextBox1.AppendText("WRITING USER ACCESS FILES TO C:\\Complaint.xml.................\n");
                ds.Clear();
                da = new SqlDataAdapter("select * from Complaint", "Data Source=.;Initial Catalog=access;Integrated Security=true");
                da.Fill(ds);
                ds.WriteXml("C:\\Complaint.xml");
                richTextBox1.AppendText("CLOSING CONNECTION.........................................\n");
                richTextBox1.AppendText("\n \n \n");


                richTextBox1.AppendText("CONNECTING TO SERVER........................................\n");
                richTextBox1.AppendText("CONNECTING TO DATABASE......................................\n");
                richTextBox1.AppendText("READING DATA FILES......................................\n");
                richTextBox1.AppendText("WRITING USER ACCESS FILES TO C:\\Countries.xml.................\n");
                ds.Clear();
                da = new SqlDataAdapter("select * from Countries", "Data Source=.;Initial Catalog=access;Integrated Security=true");
                da.Fill(ds);
                ds.WriteXml("C:\\Countries.xml");
                richTextBox1.AppendText("CLOSING CONNECTION.........................................\n");
                richTextBox1.AppendText("\n \n \n");

                richTextBox1.AppendText("CONNECTING TO SERVER........................................\n");
                richTextBox1.AppendText("CONNECTING TO DATABASE......................................\n");
                richTextBox1.AppendText("READING DATA FILES......................................\n");
                richTextBox1.AppendText("WRITING USER ACCESS FILES TO C:\\DefaulterList.xml.................\n");
                ds.Clear();
                da = new SqlDataAdapter("select * from DefaulterList", "Data Source=.;Initial Catalog=access;Integrated Security=true");
                da.Fill(ds);
                ds.WriteXml("C:\\DefaulterList.xml");
                richTextBox1.AppendText("CLOSING CONNECTION.........................................\n");
                richTextBox1.AppendText("\n \n \n");


                richTextBox1.AppendText("CONNECTING TO SERVER........................................\n");
                richTextBox1.AppendText("CONNECTING TO DATABASE......................................\n");
                richTextBox1.AppendText("READING DATA FILES......................................\n");
                richTextBox1.AppendText("WRITING USER ACCESS FILES TO C:\\EmployeeList.xml.................\n");
                ds.Clear();
                da = new SqlDataAdapter("select * from EmployeeList", "Data Source=.;Initial Catalog=access;Integrated Security=true");
                da.Fill(ds);
                ds.WriteXml("C:\\EmployeeList.xml");
                richTextBox1.AppendText("CLOSING CONNECTION.........................................\n");
                richTextBox1.AppendText("\n \n \n");


                richTextBox1.AppendText("CONNECTING TO SERVER........................................\n");
                richTextBox1.AppendText("CONNECTING TO DATABASE......................................\n");
                richTextBox1.AppendText("READING DATA FILES......................................\n");
                richTextBox1.AppendText("WRITING USER ACCESS FILES TO C:\\Emergency.xml.................\n");
                ds.Clear();
                da = new SqlDataAdapter("select * from Emergency", "Data Source=.;Initial Catalog=access;Integrated Security=true");
                da.Fill(ds);
                ds.WriteXml("C:\\Emergency.xml");
                richTextBox1.AppendText("CLOSING CONNECTION.........................................\n");
                richTextBox1.AppendText("\n \n \n");


                richTextBox1.AppendText("CONNECTING TO SERVER........................................\n");
                richTextBox1.AppendText("CONNECTING TO DATABASE......................................\n");
                richTextBox1.AppendText("READING DATA FILES......................................\n");
                richTextBox1.AppendText("WRITING USER ACCESS FILES TO C:\\EmployeeLog.xml.................\n");
                ds.Clear();
                da = new SqlDataAdapter("select * from EmployeeLog", "Data Source=.;Initial Catalog=access;Integrated Security=true");
                da.Fill(ds);
                ds.WriteXml("C:\\EmployeeLog.xml");
                richTextBox1.AppendText("CLOSING CONNECTION.........................................\n");
                richTextBox1.AppendText("\n \n \n");

                richTextBox1.AppendText("CONNECTING TO SERVER........................................\n");
                richTextBox1.AppendText("CONNECTING TO DATABASE......................................\n");
                richTextBox1.AppendText("READING DATA FILES......................................\n");
                richTextBox1.AppendText("WRITING USER ACCESS FILES TO C:\\LeaveLog.xml.................\n");
                ds.Clear();
                da = new SqlDataAdapter("select * from LeaveLog", "Data Source=.;Initial Catalog=access;Integrated Security=true");
                da.Fill(ds);
                ds.WriteXml("C:\\LeaveLog.xml");
                richTextBox1.AppendText("CLOSING CONNECTION.........................................\n");
                richTextBox1.AppendText("\n \n \n");


                richTextBox1.AppendText("CONNECTING TO SERVER........................................\n");
                richTextBox1.AppendText("CONNECTING TO DATABASE......................................\n");
                richTextBox1.AppendText("READING DATA FILES......................................\n");
                richTextBox1.AppendText("WRITING USER ACCESS FILES TO C:\\PhoneNumbers.xml.................\n");
                ds.Clear();
                da = new SqlDataAdapter("select * from PhoneNumbers", "Data Source=.;Initial Catalog=access;Integrated Security=true");
                da.Fill(ds);
                ds.WriteXml("C:\\PhoneNumbers.xml");
                richTextBox1.AppendText("CLOSING CONNECTION.........................................\n");
                richTextBox1.AppendText("\n \n \n");

                richTextBox1.AppendText("CONNECTING TO SERVER........................................\n");
                richTextBox1.AppendText("CONNECTING TO DATABASE......................................\n");
                richTextBox1.AppendText("READING DATA FILES......................................\n");
                richTextBox1.AppendText("WRITING USER ACCESS FILES TO C:\\Places.xml.................\n");
                ds.Clear();
                da = new SqlDataAdapter("select * from Places", "Data Source=.;Initial Catalog=access;Integrated Security=true");
                da.Fill(ds);
                ds.WriteXml("C:\\Places.xml");
                richTextBox1.AppendText("CLOSING CONNECTION.........................................\n");
                richTextBox1.AppendText("\n \n \n");

                richTextBox1.AppendText("CONNECTING TO SERVER........................................\n");
                richTextBox1.AppendText("CONNECTING TO DATABASE......................................\n");
                richTextBox1.AppendText("READING DATA FILES......................................\n");
                richTextBox1.AppendText("WRITING USER ACCESS FILES TO C:\\States.xml.................\n");
                ds.Clear();
                da = new SqlDataAdapter("select * from States", "Data Source=.;Initial Catalog=access;Integrated Security=true");
                da.Fill(ds);
                ds.WriteXml("C:\\States.xml");
                richTextBox1.AppendText("CLOSING CONNECTION.........................................\n");
                richTextBox1.AppendText("\n \n \n");

                richTextBox1.AppendText("CONNECTING TO SERVER........................................\n");
                richTextBox1.AppendText("CONNECTING TO DATABASE......................................\n");
                richTextBox1.AppendText("READING DATA FILES......................................\n");
                richTextBox1.AppendText("WRITING USER ACCESS FILES TO C:\\StudentList.xml.................\n");
                ds.Clear();
                da = new SqlDataAdapter("select * from StudentList", "Data Source=.;Initial Catalog=access;Integrated Security=true");
                da.Fill(ds);
                ds.WriteXml("C:\\StudentList.xml");
                richTextBox1.AppendText("CLOSING CONNECTION.........................................\n");
                richTextBox1.AppendText("\n \n \n");

                richTextBox1.AppendText("CONNECTING TO SERVER........................................\n");
                richTextBox1.AppendText("CONNECTING TO DATABASE......................................\n");
                richTextBox1.AppendText("READING DATA FILES......................................\n");
                richTextBox1.AppendText("WRITING USER ACCESS FILES TO C:\\StudentLog.xml.................\n");
                ds.Clear();
                da = new SqlDataAdapter("select * from StudentLog", "Data Source=.;Initial Catalog=access;Integrated Security=true");
                da.Fill(ds);
                ds.WriteXml("C:\\StudentLog.xml");
                richTextBox1.AppendText("CLOSING CONNECTION.........................................\n");
                richTextBox1.AppendText("\n \n \n");


                richTextBox1.AppendText("CONNECTING TO SERVER........................................\n");
                richTextBox1.AppendText("CONNECTING TO DATABASE......................................\n");
                richTextBox1.AppendText("READING DATA FILES......................................\n");
                richTextBox1.AppendText("WRITING USER ACCESS FILES TO C:\\VisitorLog.xml.................\n");
                ds.Clear();
                da = new SqlDataAdapter("select * from VisitorLog", "Data Source=.;Initial Catalog=access;Integrated Security=true");
                da.Fill(ds);
                ds.WriteXml("C:\\VisitorLog.xml");
                richTextBox1.AppendText("CLOSING CONNECTION.........................................\n");
                richTextBox1.AppendText("\n \n \n");
                richTextBox1.AppendText( "ALL TRANSECTION COMPLETE...................................\n");
                richTextBox1.AppendText("YOU CAN CLOSE THE WINDOW NOW...............................\n");

                MessageBox.Show("Done","MESSAGE",MessageBoxButtons.OK);
                richTextBox1.Hide();
                pictureBox1.Show();
            }
            catch
            {
                MessageBox.Show("A Problem Occoured With The Data Server Check Server Settings", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Media_Player obj = new Media_Player();
            obj.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StudentDatabase obj = new StudentDatabase();
            obj.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddStudent obj = new AddStudent();
            obj.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void reportDocument1_InitReport(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            
        }

        private void button15_Click(object sender, EventArgs e)
        {
            
            
        }

        private void button16_Click(object sender, EventArgs e)
        {
            //dataGridView1.Hide();
            //ds.Clear();
            //button14.Hide();
            //button15.Hide();
            //button16.Hide();
            //pictureBox1.Show();
            //ds.Clear();
        }

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            index = e.RowIndex;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            
            Program.log = 1;
            LogScreen obj = new LogScreen();
            obj.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
           
            Program.log = 2;
            LogScreen obj = new LogScreen();
            obj.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Program.log = 3;
            LogScreen obj = new LogScreen();
            obj.Show();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            
            Program.log = 4;
            LogScreen obj = new LogScreen();
            obj.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            ComplaintBook obj = new ComplaintBook();
            obj.Show();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            PhoneDatabse obj = new PhoneDatabse();
            obj.Show();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            EmergencyDatabase OBJ = new EmergencyDatabase();
            OBJ.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddEmployee obj = new AddEmployee();
            obj.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            EmployeeDatabase obj = new EmployeeDatabase();
            obj.Show();
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            LogViewer obj = new LogViewer();
            obj.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Defaulter obj = new Defaulter();
            obj.Show();

        }

        private void button18_Click(object sender, EventArgs e)
        {
            //dataGridView1.Hide();
            //pictureBox1.Show();
            //button18.Hide();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            Change obj = new Change();
            obj.Show();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button23_Click(object sender, EventArgs e)
        {

        }

        
        
    }
}