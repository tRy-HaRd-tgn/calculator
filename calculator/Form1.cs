using calculator;
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
    
    public partial class Form1 : Form
    {
        double temp1;
        double temp2;
        char temp_c;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {
            string temp = richTextBox1.Text;
            if (temp == "0" || temp == "не число")
            {
                richTextBox1.Text = "1";
                button1.Visible = true;
                button8.Visible = true;
                button7.Visible = true;
                button6.Visible = true;
                button5.Visible = true;
                button9.Visible = true;
                button13.Visible = true;
                button17.Visible = true;
                button24.Visible = true;
                button22.Visible = true;
            }
            else 
            {
                richTextBox1.Text += "1";
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            string temp = richTextBox1.Text;
            if (temp == "0" || temp == "не число")
            {
                richTextBox1.Text = "2";
                button1.Visible = true;
                button8.Visible = true;
                button7.Visible = true;
                button6.Visible = true;
                button5.Visible = true;
                button9.Visible = true;
                button13.Visible = true;
                button17.Visible = true;
                button24.Visible = true;
                button22.Visible = true;
            }
            else
            {
                richTextBox1.Text += "2";
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            string temp = richTextBox1.Text;
            if (temp == "0" || temp == "не число")
            {
                richTextBox1.Text = "3";
                button1.Visible = true;
                button8.Visible = true;
                button7.Visible = true;
                button6.Visible = true;
                button5.Visible = true;
                button9.Visible = true;
                button13.Visible = true;
                button17.Visible = true;
                button24.Visible = true;
                button22.Visible = true;
            }
            else
            {
                richTextBox1.Text += "3";
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            string temp = richTextBox1.Text;
            if (temp == "0" || temp == "не число")
            {
                richTextBox1.Text = "4";
                button1.Visible = true;
                button8.Visible = true;
                button7.Visible = true;
                button6.Visible = true;
                button5.Visible = true;
                button9.Visible = true;
                button13.Visible = true;
                button17.Visible = true;
                button24.Visible = true;
                button22.Visible = true;
            }
            else
            {
                richTextBox1.Text += "4";
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            string temp = richTextBox1.Text;
            if (temp == "0" || temp == "не число")
            {
                richTextBox1.Text = "5";
                button1.Visible = true;
                button8.Visible = true;
                button7.Visible = true;
                button6.Visible = true;
                button5.Visible = true;
                button9.Visible = true;
                button13.Visible = true;
                button17.Visible = true;
                button24.Visible = true;
                button22.Visible = true;
            }
            else
            {
                richTextBox1.Text += "5";
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            string temp = richTextBox1.Text;
            if (temp == "0" || temp == "не число")
            {
                richTextBox1.Text = "6";
                button1.Visible = true;
                button8.Visible = true;
                button7.Visible = true;
                button6.Visible = true;
                button5.Visible = true;
                button9.Visible = true;
                button13.Visible = true;
                button17.Visible = true;
                button24.Visible = true;
                button22.Visible = true;
            }
            else
            {
                richTextBox1.Text += "6";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string temp = richTextBox1.Text;
            if (temp == "0" || temp == "не число")
            {
                richTextBox1.Text = "7";
                button1.Visible = true;
                button8.Visible = true;
                button7.Visible = true;
                button6.Visible = true;
                button5.Visible = true;
                button9.Visible = true;
                button13.Visible = true;
                button17.Visible = true;
                button24.Visible = true;
                button22.Visible = true;
            }
            else
            {
                richTextBox1.Text += "7";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string temp = richTextBox1.Text;
            if (temp == "0" || temp == "не число")
            {
                richTextBox1.Text = "8";
                button1.Visible = true;
                button8.Visible = true;
                button7.Visible = true;
                button6.Visible = true;
                button5.Visible = true;
                button9.Visible = true;
                button13.Visible = true;
                button17.Visible = true;
                button24.Visible = true;
                button22.Visible = true;
            }
            else
            {
                richTextBox1.Text += "8";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string temp = richTextBox1.Text;
            if (temp == "0" || temp == "не число")
            {
                richTextBox1.Text = "9";
                button1.Visible = true;
                button8.Visible = true;
                button7.Visible = true;
                button6.Visible = true;
                button5.Visible = true;
                button9.Visible = true;
                button13.Visible = true;
                button17.Visible = true;
                button24.Visible = true;
                button22.Visible = true;
            }
            else
            {
                richTextBox1.Text += "9";
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            string temp = richTextBox1.Text;
            if (temp == "0" || temp == "не число")
            {
                richTextBox1.Text = "0";
                button1.Visible = true;
                button8.Visible = true;
                button7.Visible = true;
                button6.Visible = true;
                button5.Visible = true;
                button9.Visible = true;
                button13.Visible = true;
                button17.Visible = true;
                button24.Visible = true;
                button22.Visible = true;
            }
            else
            {
                richTextBox1.Text += "0";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "не число")
            {
                button1.Visible = true;
                button8.Visible = true;
                button7.Visible = true;
                button6.Visible = true;
                button5.Visible = true;
                button9.Visible = true;
                button13.Visible = true;
                button17.Visible = true;
                button24.Visible = true;
                button22.Visible = true;
            }
            richTextBox1.Text = "0";
            temp1 = 0;
            temp2 = 0;
            temp_c = ' ';
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "не число")
            {
                button1.Visible = true;
                button8.Visible = true;
                button7.Visible = true;
                button6.Visible = true;
                button5.Visible = true;
                button9.Visible = true;
                button13.Visible = true;
                button17.Visible = true;
                button24.Visible = true;
                button22.Visible = true;
                richTextBox1.Text = "0";
            }
            string temp = richTextBox1.Text;
            temp = temp.Remove(temp.Length - 1);
            richTextBox1.Text = temp;
            if (richTextBox1.Text == "")
            {
                richTextBox1.Text = "0";
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            temp1 = double.Parse( richTextBox1.Text);
            richTextBox1.Text = "0";
            temp_c = '+';
        }

        private void button13_Click(object sender, EventArgs e)
        {
            temp1 = double.Parse(richTextBox1.Text);
            richTextBox1.Text = "0";
            temp_c = '-';
        }

        private void button9_Click(object sender, EventArgs e)
        {
            temp1 = double.Parse(richTextBox1.Text);
            richTextBox1.Text = "0";
            temp_c = '*';
        }

        private void button5_Click(object sender, EventArgs e)
        {
            temp1 = double.Parse(richTextBox1.Text);
            richTextBox1.Text = "0";
            temp_c = '/';
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "не число")
            {
                richTextBox1.Text = "0";
                button1.Visible = true;
                button8.Visible = true;
                button7.Visible = true;
                button6.Visible = true;
                button5.Visible = true;
                button9.Visible = true;
                button13.Visible = true;
                button17.Visible = true;
                button24.Visible = true;
                button22.Visible = true;
                return;
            }
            temp2 = double.Parse(richTextBox1.Text);
            if (temp_c == '+')
            {
                richTextBox1.Text= (temp1 + temp2).ToString();
            }
            else if (temp_c == '-') 
            {
                richTextBox1.Text = (temp1 - temp2).ToString();
            }
            else if (temp_c == '*')
            {
                richTextBox1.Text = (temp1 * temp2).ToString();
            }
            else if (temp_c == '/')
            {
                richTextBox1.Text = (temp1 / temp2).ToString();
               
            }
            temp_c = ' ';
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double aboba = double.Parse(richTextBox1.Text);
            richTextBox1.Text = Math.Sqrt(aboba).ToString();
            if (richTextBox1.Text == "не число")
            {
                button1.Visible = false;
                button8.Visible = false;
                button7.Visible = false;
                button6.Visible = false;
                button5.Visible = false;
                button9.Visible = false;
                button13.Visible = false;
                button17.Visible = false;
                button24.Visible = false;
                button22.Visible = false;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            double aboba = double.Parse(richTextBox1.Text);
            richTextBox1.Text = (aboba*aboba).ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            double aboba = double.Parse(richTextBox1.Text);
            richTextBox1.Text = (1 / aboba).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (temp1 < temp2) { richTextBox1.Text = (temp1 / temp2).ToString(); }
            if (temp1 > temp2) { richTextBox1.Text = (temp2 / temp1).ToString(); }
            if (temp1 == temp2) { richTextBox1.Text = "100"; }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            
            richTextBox1.Text = (double.Parse(richTextBox1.Text) * (-1)).ToString();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += ",";
        }
        int lB1_V = 0;
        private void button25_Click(object sender, EventArgs e)
        {
            if (lB1_V == 1) { listBox1.Visible = false;lB1_V = 0; return; }
            listBox1.Visible = true;
            lB1_V = 1;
        }
        
        private void Form1_Click(object sender, EventArgs e)
        {

            listBox1.Visible = false;
            lB1_V = 0;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem.ToString() == "обычный")
            {
                //готово
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
                this.Hide();
                Form temperature= new Form2();
                temperature.StartPosition = FormStartPosition.Manual;
                temperature.Location = Location;
                temperature.ShowDialog();
                this.Close();
            }
        }
    }
}
