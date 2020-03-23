using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tsp.netSapt2
{
    public partial class Form1 : Form
    {
        Double resultValue = 0;
        String operatieFacuta = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Clear();
            Button button = (Button)sender;
            textBox1.Text = textBox1.Text + button.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Clear();
            Button button = (Button)sender;
            textBox1.Text = textBox1.Text + button.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Clear();
            Button button = (Button)sender;
            textBox1.Text = textBox1.Text + button.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Clear();
            Button button = (Button)sender;
            textBox1.Text = textBox1.Text + button.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Clear();
            Button button = (Button)sender;
            textBox1.Text = textBox1.Text + button.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Clear();
            Button button = (Button)sender;
            textBox1.Text = textBox1.Text + button.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Clear();
            Button button = (Button)sender;
            textBox1.Text = textBox1.Text + button.Text;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operatieFacuta = button.Text;
            resultValue = Double.Parse(textBox1.Text);
            textBox1.Text = "";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Clear();
            Button button = (Button)sender;
            textBox1.Text = textBox1.Text + button.Text;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operatieFacuta = button.Text;
            resultValue = Double.Parse(textBox1.Text);
            textBox1.Text = "";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Clear();
            textBox1.Text = "-" + textBox1.Text;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Clear();
            Button button = (Button)sender;
            textBox1.Text = textBox1.Text + button.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operatieFacuta = button.Text;
            resultValue = Double.Parse(textBox1.Text);
            textBox1.Text = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operatieFacuta = button.Text;
            resultValue = Double.Parse(textBox1.Text);
            textBox1.Text = "";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            switch (operatieFacuta)
            {
                case "+":
                    textBox1.Text = (resultValue + Double.Parse(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (resultValue - Double.Parse(textBox1.Text)).ToString();
                    break;
                case "*":
                    textBox1.Text = (resultValue * Double.Parse(textBox1.Text)).ToString();
                    break;
                case "÷":
                    textBox1.Text = (resultValue / Double.Parse(textBox1.Text)).ToString();
                    break;
                default:
                    break;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Clear();
            Button button = (Button)sender;
            textBox1.Text = textBox1.Text + button.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Clear();
            Button button = (Button)sender;
            textBox1.Text = textBox1.Text + button.Text;
        }
    }
}
