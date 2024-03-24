using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form2 : Form
    {
        double temp1;
        double temp2;
        public Form2()
        {
            InitializeComponent();
            double aboba = double.Parse(richTextBox1.Text);
            richTextBox2.Text = (aboba + 273.15).ToString();
            richTextBox3.Text = ((aboba * 1.8)+32).ToString();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (listBox1.Visible == false)
            {
                listBox1.Visible = true;
            }
            else 
            {
                listBox1.Visible = false;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void Form2_Click(object sender, EventArgs e)
        {
            if (listBox1.Visible == true)
            {
                listBox1.Visible = false;
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void richTextBox1_Click(object sender, EventArgs e)
        {
            if (listBox1.Visible == true)
            {
                listBox1.Visible = false;
            }
        }
        private void button12_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = "1";
                double aboba = double.Parse(richTextBox1.Text);
                richTextBox2.Text = (aboba + 273.15).ToString();
                richTextBox3.Text = ((aboba * 1.8) + 32).ToString();
            }
            else 
            { 
                richTextBox1.Text += "1";
                double aboba = double.Parse(richTextBox1.Text);
                richTextBox2.Text = (aboba + 273.15).ToString();
                richTextBox3.Text = ((aboba * 1.8) + 32).ToString();
            }
        }
        private void button11_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = "2";
                double aboba = double.Parse(richTextBox1.Text);
                richTextBox2.Text = (aboba + 273.15).ToString();
                richTextBox3.Text = ((aboba * 1.8) + 32).ToString();
            }
            else 
            { 
                richTextBox1.Text += "2";
                double aboba = double.Parse(richTextBox1.Text);
                richTextBox2.Text = (aboba + 273.15).ToString();
                richTextBox3.Text = ((aboba * 1.8) + 32).ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "0";
            double aboba = double.Parse(richTextBox1.Text);
            richTextBox2.Text = (aboba + 273.15).ToString();
            richTextBox3.Text = ((aboba * 1.8) + 32).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text.Remove(richTextBox1.Text.Length-1);
            if (richTextBox1.Text == "") 
            {
                richTextBox1.Text = "0";
            }
            double aboba = double.Parse(richTextBox1.Text);
            richTextBox2.Text = (aboba + 273.15).ToString();
            richTextBox3.Text = ((aboba * 1.8) + 32).ToString();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0")
            {

            }
            else 
            {
                richTextBox1.Text += "0";
                double aboba = double.Parse(richTextBox1.Text);
                richTextBox2.Text = (aboba + 273.15).ToString();
                richTextBox3.Text = ((aboba * 1.8) + 32).ToString();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = "3";
                double aboba = double.Parse(richTextBox1.Text);
                richTextBox2.Text = (aboba + 273.15).ToString();
                richTextBox3.Text = ((aboba * 1.8) + 32).ToString();
            }
            else 
            { 
                richTextBox1.Text += "3";
                double aboba = double.Parse(richTextBox1.Text);
                richTextBox2.Text = (aboba + 273.15).ToString();
                richTextBox3.Text = ((aboba * 1.8) + 32).ToString();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = "4";
                double aboba = double.Parse(richTextBox1.Text);
                richTextBox2.Text = (aboba + 273.15).ToString();
                richTextBox3.Text = ((aboba * 1.8) + 32).ToString();
            }
            else 
            { 
                richTextBox1.Text += "4";
                double aboba = double.Parse(richTextBox1.Text);
                richTextBox2.Text = (aboba + 273.15).ToString();
                richTextBox3.Text = ((aboba * 1.8) + 32).ToString();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = "5";
                double aboba = double.Parse(richTextBox1.Text);
                richTextBox2.Text = (aboba + 273.15).ToString();
                richTextBox3.Text = ((aboba * 1.8) + 32).ToString();
            }
            else 
            { 
                richTextBox1.Text += "5";
                double aboba = double.Parse(richTextBox1.Text);
                richTextBox2.Text = (aboba + 273.15).ToString();
                richTextBox3.Text = ((aboba * 1.8) + 32).ToString();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = "6";
                double aboba = double.Parse(richTextBox1.Text);
                richTextBox2.Text = (aboba + 273.15).ToString();
                richTextBox3.Text = ((aboba * 1.8) + 32).ToString();
            }
            else 
            { 
                richTextBox1.Text += "6";
                double aboba = double.Parse(richTextBox1.Text);
                richTextBox2.Text = (aboba + 273.15).ToString();
                richTextBox3.Text = ((aboba * 1.8) + 32).ToString();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = "7";
                double aboba = double.Parse(richTextBox1.Text);
                richTextBox2.Text = (aboba + 273.15).ToString();
                richTextBox3.Text = ((aboba * 1.8) + 32).ToString();
            }
            else 
            { 
                richTextBox1.Text += "7";
                double aboba = double.Parse(richTextBox1.Text);
                richTextBox2.Text = (aboba + 273.15).ToString();
                richTextBox3.Text = ((aboba * 1.8) + 32).ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = "8";
                double aboba = double.Parse(richTextBox1.Text);
                richTextBox2.Text = (aboba + 273.15).ToString();
                richTextBox3.Text = ((aboba * 1.8) + 32).ToString();
            }
            else 
            { 
                richTextBox1.Text += "8";
                double aboba = double.Parse(richTextBox1.Text);
                richTextBox2.Text = (aboba + 273.15).ToString();
                richTextBox3.Text = ((aboba * 1.8) + 32).ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = "9";
                double aboba = double.Parse(richTextBox1.Text);
                richTextBox2.Text = (aboba + 273.15).ToString();
                richTextBox3.Text = ((aboba * 1.8) + 32).ToString();
            }
            else 
            { 
                richTextBox1.Text += "9";
                double aboba = double.Parse(richTextBox1.Text);
                richTextBox2.Text = (aboba + 273.15).ToString();
                richTextBox3.Text = ((aboba * 1.8) + 32).ToString();
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += ",";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = (double.Parse(richTextBox1.Text) * (-1)).ToString();
            double aboba = double.Parse(richTextBox1.Text);
            richTextBox2.Text = (aboba + 273.15).ToString();
            richTextBox3.Text = ((aboba * 1.8) + 32).ToString();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem.ToString() == "обычный")
            {
                this.Hide();
                Form ordinary= new Form1();
                ordinary.StartPosition = FormStartPosition.Manual;
                ordinary.Location = Location;
                ordinary.ShowDialog();
                this.Close();
            }
            if (listBox1.SelectedItem.ToString() == "Инженерный")
            {
                //планируется
            }
            if (listBox1.SelectedItem.ToString() == "время")
            {
                //планируется
            }
            if (listBox1.SelectedItem.ToString() == "дата")
            {
                //планируется
            }
            if (listBox1.SelectedItem.ToString() == "температура")
            {
                //в процессе
            }
        }
    }
}
