using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void getvalues(Button btn)
        {
            if(button1.Text==label1.Text)
            {
                button1.Text = btn.Text;
            }
            else if(button1.Text=="0.")
            {
                button1.Text = btn.Text;
            }
            else if(button1.Text==label3.Text)
            {
                button1.Text = btn.Text;
            }
            else
            {
                button1.Text = button1.Text+btn.Text;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            getvalues(button2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            getvalues(button3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            getvalues(button4);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            getvalues(button7);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            getvalues(button6);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            getvalues(button5);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            getvalues(button10);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            getvalues(button9);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            getvalues(button8);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            getvalues(button16);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            label2.Text = "+";
            label1.Text = button1.Text;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            label2.Text = "-";
            label1.Text = button1.Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            label2.Text = "*";
            label1.Text = button1.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            label2.Text = "/";
            label1.Text = button1.Text;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text ="";
            label3.Text = "";
            button1.Text = "";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            double l1, b1;
            l1 = double.Parse(label1.Text);
            b1 = double.Parse(button1.Text);
            if(label2.Text!="" && label2.Text=="+")
            {
                b1 = l1 + b1;
                button1.Text = b1.ToString();
                label3.Text = button1.Text;
            }

            if (label2.Text != "" && label2.Text == "-")
            {
                b1 = l1 - b1;
                button1.Text = b1.ToString();
                label3.Text = button1.Text;
            }

            if (label2.Text != "" && label2.Text == "*")
            {
                b1 = l1 * b1;
                button1.Text = b1.ToString();
                label3.Text = button1.Text;
            }

            if (label2.Text != "" && label2.Text == "/")
            {
                b1 = l1 / b1;
                button1.Text = b1.ToString();
                label3.Text = button1.Text;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            getvalues(button17);
        }
    }
}
