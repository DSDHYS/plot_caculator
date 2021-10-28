using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            char num = '7';
            textBox1.Text += num;

        }

        public void button3_Click(object sender, EventArgs e)
        {
            char num = '1';
            textBox1.Text += num;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            char num = '2';
            textBox1.Text += num;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            char num = '3';
            textBox1.Text += num;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            char num = '4';
            textBox1.Text += num;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            char num = '5';
            textBox1.Text += num;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            char num = '6';
            textBox1.Text += num;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            char num = '8';
            textBox1.Text += num;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            char num = '9';
            textBox1.Text += num;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            char num = '0';
            textBox1.Text += num;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            char num = '.';
            textBox1.Text += num;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("y"))
            {
                char num = '=';
                textBox1.Text += num;
            }
            else
            {

            string input = textBox1.Text;
            string pattern = @"sin\(\d+\)|sin\(\-\d+\)|sin\(\d+\.\d+\)|sin\(\-\d+\.\d+\)";
            //string pattern = @"sin\d+";
            foreach (System.Text.RegularExpressions.Match m in System.Text.RegularExpressions.Regex.Matches(textBox1.Text,pattern))
            {
                string m_str = m.Value;
                //string m_str_regex =string.Format( "sin({0})", m_str);

                textBox1.Text=textBox1.Text.Replace(m_str, Convert.ToString(Math.Sin(Convert.ToDouble(m_str.Substring(4, m_str.Length - 5)))));
                //textBox1.Text=regex.Replace(textBox1.Text, Convert.ToString(Math.Sin(Convert.ToDouble(m_str.Substring(4, m_str.Length - 5)))));       
            }

            pattern = @"cos\(\d+\)|cos\(\-\d+\)|cos\(\d+\.\d+\)|cos\(\-\d+\.\d+\)";
            foreach (System.Text.RegularExpressions.Match m in System.Text.RegularExpressions.Regex.Matches(textBox1.Text, pattern))
            {
                string m_str = m.Value;
                //string m_str_regex =string.Format( "sin({0})", m_str);

                textBox1.Text = textBox1.Text.Replace(m_str, Convert.ToString(Math.Cos(Convert.ToDouble(m_str.Substring(4, m_str.Length - 5)))));
                //textBox1.Text=regex.Replace(textBox1.Text, Convert.ToString(Math.Sin(Convert.ToDouble(m_str.Substring(4, m_str.Length - 5)))));       
            }
            pattern = @"tan\(\d+\)|tan\(\-\d+\)|tan\(\d+\.\d+\)|tan\(\-\d+\.\d+\)";
            foreach (System.Text.RegularExpressions.Match m in System.Text.RegularExpressions.Regex.Matches(textBox1.Text, pattern))
            {
                string m_str = m.Value;
                //string m_str_regex =string.Format( "sin({0})", m_str);

                textBox1.Text = textBox1.Text.Replace(m_str, Convert.ToString(Math.Tan(Convert.ToDouble(m_str.Substring(4, m_str.Length - 5)))));
                //textBox1.Text=regex.Replace(textBox1.Text, Convert.ToString(Math.Sin(Convert.ToDouble(m_str.Substring(4, m_str.Length - 5)))));       
            }
            DataTable dataTable = new DataTable();
            textBox2.Text = dataTable.Compute(textBox1.Text, "false").ToString();
            textBox1.Text = input;

            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            char num = '+';
            textBox1.Text += num;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            char num = '-';
            textBox1.Text += num;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            char num = '*';
            textBox1.Text += num;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            char num = '/';
            textBox1.Text += num;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            char num = ')';
            textBox1.Text += num;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            char num = '(';
            textBox1.Text += num;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
    }
}
