using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using IdGenerator;
using System.Data.SqlClient;

namespace Student_Management
{
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=access;Integrated Security=True");
        SqlDataAdapter da;
        SqlDataAdapter da1;
        SqlDataAdapter da2;
        DataSet ds3 = new DataSet();
        DataSet ds1 = new DataSet();
        DataSet ds2 = new DataSet();
        DataSet ds4 = new DataSet();

        private void button2_Click(object sender, EventArgs e)
        {
            textBox12.ReadOnly = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox16.ReadOnly = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox8.ReadOnly = false;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void AddStudent_Load(object sender, EventArgs e)
        {
            IdGenerator.Class1 obj = new IdGenerator.Class1();
            textBox117.Text=obj.GetId();

            for (int i = 7; i <= 35; i++)
            {
                comboBox2.Items.Add(i.ToString());
            }
            comboBox1.Items.Add("B.Tech");
            comboBox1.Items.Add("MCA");
            comboBox1.Items.Add("MBA");
            comboBox8.Items.Add("Yes");
            comboBox8.Items.Add("No");
            comboBox9.Items.Add("Single Sitter");
            comboBox9.Items.Add("Double Sitter");
            comboBox9.Items.Add("Triple Sitter");
            comboBox6.Items.Add("First Year");
            comboBox6.Items.Add("Second Year");
            comboBox6.Items.Add("Third Year");
            comboBox6.Items.Add("Fourth Year");
            comboBox10.Items.Add("Required");
            comboBox10.Items.Add("Not Required");
            comboBox3.Items.Add("Male");
            comboBox3.Items.Add("Female");
            comboBox4.Items.Add("A+");
            comboBox4.Items.Add("A-");
            comboBox4.Items.Add("B+");
            comboBox4.Items.Add("B-");
            comboBox4.Items.Add("AB+");
            comboBox4.Items.Add("AB-");
            comboBox4.Items.Add("O+");
            comboBox4.Items.Add("O-");
            comboBox5.Items.Add("Computer Science");
            comboBox5.Items.Add("Electronics And Communication");
            comboBox5.Items.Add("Information Technology");
            comboBox5.Items.Add("Electronics And Electrical");
            comboBox5.Items.Add("Mechancal Engineering");
            try
            {
                
                DataSet ds = new DataSet();
                da = new SqlDataAdapter("select * from StudentList", conn);
                da.Fill(ds);
                
            }
            catch
            {
                MessageBox.Show("A Problem Occoured With The Data Server Check Server Settings", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            IdGenerator.Class1 obj = new IdGenerator.Class1();
            obj.GenerateID(textBox117.Text.Trim());
            // addition of the form element
            da = new SqlDataAdapter("select * from StudentList", conn);
            da.Fill(ds4);     
            MessageBox.Show("Student Added", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog op = new OpenFileDialog();

                op.Filter = "Image files (*.jpg)|*.txt|All files (*.*)|*.*";
                op.ShowDialog();
                Image img = Image.FromFile(op.FileName);
                pictureBox1.Image = img;
            }

            catch (ArgumentOutOfRangeException)
            {

            }
            catch
            {

            }
        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

       

        

        
    }
}