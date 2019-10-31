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
    public partial class Калькулятор : Form
    {
        string action="";



        public Калькулятор()
        {
            InitializeComponent();

            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0) return;

            textBox1.Text = textBox1.Text + "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0) return;
            if (action.Length != 0) calc();

            textBox1.Text = textBox1.Text + "+";
            action = "+";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0) return;
            if (action.Length != 0) calc();

            textBox1.Text = textBox1.Text + "-";
            action = "-";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0) return;
            if (action.Length != 0) calc();

            textBox1.Text = textBox1.Text + "x";
            action = "x";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0) return;
            if (action.Length != 0) calc();

            textBox1.Text = textBox1.Text + ":";
            action = ":";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (action.Length != 0) calc();
        }

        private void calc()
        {
            
            string text = textBox1.Text;
            string[] t = text.Split(new string[] { action }, StringSplitOptions.RemoveEmptyEntries);

            if (t[0].Length == 0) return;
            if (t.Length < 2) return;

            int a = Convert.ToInt32(t[0]);
            int b = Convert.ToInt32(t[1]);

            int c = 0;
            switch (action)
            {
                case ":":
                    if (b == 0) return;
                    c = a / b;
                    break;
                case "+":
                    c = a + b;
                    break;
                case "-":
                    c = a - b;
                    break;
                case "x":
                    c = a * b;
                    break;
            }
           
            textBox1.Text = c.ToString();

            action = "";
        }

        private void button16_Click(object sender, EventArgs e)
        {
           if (textBox1.Text.Length == 0) return;
            
            textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0) return;
            textBox1.Text = textBox1.Text + "00";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0) return;
            textBox1.Text = textBox1.Text + "000";
        }
    }
}
