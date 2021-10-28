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
    public partial class Form1 : Form
    {
        Form2 f2 = new Form2();
        Form4 f4 = new Form4();
        public Form1()
        {
            InitializeComponent();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            f2.MdiParent = this;
            f2.WindowState = FormWindowState.Maximized;
            f2.FormBorderStyle = FormBorderStyle.None;
            f2.Parent = panel1;
            f2.Show();

        }
        //private void panel1_Resize(object sender, EventArgs e)
        //{

        //    if (this != null)
        //    {
        //        this.Size = this.panel1.Size;
        //    }
        //}



            private void panel1_Paint(object sender, PaintEventArgs e)
            {

            }


        private void button1_Click_1(object sender, EventArgs e)
        {

            if (f4.Visible==false)
            {
                f4.MdiParent = this;
                f4.WindowState = FormWindowState.Maximized;
                f4.FormBorderStyle = FormBorderStyle.None;
                f4.Parent = panel1;
                f4.Show();
                f4.Visible = true;
                f2.Visible=false;
                f4.textBox1.Text= f2.textBox1.Text;
                f4.textBox2.Text = f2.textBox2.Text;
            }
            else 
            {
                f2.MdiParent = this;
                f2.WindowState = FormWindowState.Maximized;
                f2.FormBorderStyle = FormBorderStyle.None;
                f2.Parent = panel1;
                f2.Show();
                f2.Visible = true;
                f4.Visible = false;
                f2.textBox1.Text = f4.textBox1.Text;
                f2.textBox2.Text = f4.textBox2.Text;


            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

        }


    }
    } 
