using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string num = "sin(";
            textBox1.Text += num;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string num = "cos(";
            textBox1.Text += num;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string num = "tan(";
            textBox1.Text += num;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string num = "y";
            textBox1.Text += num;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string num = "x";
            textBox1.Text += num;
        }

        private void button4_Click(object sender, EventArgs e)
        {

            chart1.Series[0].Points.Clear();
            double y;
            
            string input = textBox1.Text;
            textBox1.Text = textBox1.Text.Remove(0, 2);


            for (int i = -100; i < 100; i++)
            {
                textBox1.Text = input;
                textBox1.Text = textBox1.Text.Remove(0, 2);
                string pattern = @"x";
                foreach (System.Text.RegularExpressions.Match m in System.Text.RegularExpressions.Regex.Matches(textBox1.Text, pattern))
                {
                    string num = $"{i}";
                    textBox1.Text = textBox1.Text.Replace("x", num);
                }
                //DataTable dataTable = new DataTable();
                string y_str = Library.Dsd.caculate(textBox1.Text);
                y = Convert.ToDouble(y_str);
                chart1.Series[0].Points.AddXY(i,y);
                //y = Convert.ToInt32(dataTable.Compute(textBox1.Text, "false"));



            }

            textBox1.Text = input;
        }

        private void chart1_Click(object sender, EventArgs e)
        {
            chart1.MouseClick += new System.Windows.Forms.MouseEventHandler(Chart_MouseClick);
        }
        static void Chart_MouseClick(object sender,MouseEventArgs e)
        {
            System.Windows.Forms.DataVisualization.Charting.Chart chart1 = sender as System.Windows.Forms.DataVisualization.Charting.Chart;
            if(e.Button==MouseButtons.Right)
            {
                chart1.ChartAreas[0].AxisX.ScaleView.ZoomReset(0);
            }
        }
    }
}
