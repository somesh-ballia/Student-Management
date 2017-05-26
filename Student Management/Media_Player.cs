using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Media;


namespace Student_Management
{
    public partial class Media_Player : Form
    {
        public Media_Player()
        {
            InitializeComponent();
        }
        int index,lastindex;
        OpenFileDialog op = new OpenFileDialog();
        System.Media.SoundPlayer me;
        OpenFileDialog op1 = new OpenFileDialog();
            
        private void button2_Click(object sender, EventArgs e)
        {
            op.Filter = "Wav files (*.wav)|*.wav|All files (*.*)|*.*";
            op.ShowDialog();
            textBox1.Text = op.FileName;
            try
            {
                me = new SoundPlayer(textBox1.Text.Trim());
                me.Play();
            }
            catch (ArgumentException)
            {
            }
            

            
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                me.Stop();
            }
            catch
            {

            }
            me = new SoundPlayer(textBox1.Text.Trim());
            try
            {
                me.Play();
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("File Corrupted", "Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            catch (ArgumentOutOfRangeException)
            {
            }
            label6.Text = textBox1.Text.Trim();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            me.Stop();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                me.Stop();
            }
            catch
            {

            }
            this.Close();
        }

        private void Media_Player_Load(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
            
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            op1.Filter = "Wav files (*.wav)|*.wav|All files (*.*)|*.*";
       
            op1.Multiselect = true;
            op1.ShowDialog();
            try
            {
                comboBox1.Items.AddRange(op1.FileNames);
                comboBox1.Text = comboBox1.Items[0].ToString();
                textBox1.Text = comboBox1.Items[0].ToString();
                lastindex = comboBox1.ItemHeight;
            }
            catch(ArgumentOutOfRangeException)
            {
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            
            try
            {
                index -= 1;
                textBox1.Text = comboBox1.Items[index].ToString();
                me = new SoundPlayer(textBox1.Text.Trim());
                me.Play();
                comboBox1.Text = comboBox1.Items[index].ToString();
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("File Corrupted", "Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                comboBox1.Items.RemoveAt(index);
            }
            catch (ArgumentOutOfRangeException)
            {
                index = comboBox1.ItemHeight;
            }
            label6.Text = textBox1.Text.Trim();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                index += 1;
                textBox1.Text = comboBox1.Items[index].ToString();
                me = new SoundPlayer(textBox1.Text.Trim());
                me.Play();
                comboBox1.Text = comboBox1.Items[index].ToString();
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("File Corrupted", "Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                comboBox1.Items.RemoveAt(index);
            }
            catch (ArgumentOutOfRangeException)
            {
                index = 0;
            }
            label6.Text = textBox1.Text.Trim();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            me = new SoundPlayer(textBox1.Text.Trim());
            try
            {
                me.PlayLooping();
                comboBox1.Text = comboBox1.Items[index].ToString();
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("File Corrupted", "Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                comboBox1.Items.RemoveAt(index);
            }
        }
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = comboBox1.SelectedIndex;
            textBox1.Text = comboBox1.Items[index].ToString();
            me = new SoundPlayer(textBox1.Text.Trim());
            try
            {
                me.Play();
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("File Corrupted", "Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                comboBox1.Items.RemoveAt(index);
            }
            
            label6.Text = textBox1.Text.Trim();

        }

        private void Media_Player_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                me.Stop();
            }
            catch
            {
            }
        }
    }
}