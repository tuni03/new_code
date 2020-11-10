using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";//текстовото поле за фаренхайт да присвои стойността  0
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";//текстовото поле за фаренхайт да присвои стойността  1
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";//текстовото поле за фаренхайт да присвои стойността  2      
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";//текстовото поле за фаренхайт да присвои стойността  3
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";//текстовото поле за фаренхайт да присвои стойността  4
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";//текстовото поле за фаренхайт да присвои стойността  5
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";//текстовото поле за фаренхайт да присвои стойността 6 
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";//текстовото поле за фаренхайт да присвои стойността  7
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";//текстовото поле за фаренхайт да присвои стойността  8
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";//текстовото поле за фаренхайт да присвои стойността 9 
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = "-";//добавяне на знак за отрицателните стойности  
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";//добавяне на десетична запетая
        }
        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";//стойностите на текстовото поле да се изтрият
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            double value = Convert.ToDouble(textBox1.Text);
            textBox2.Text = Convert.ToString((value - 32) * 5 / 9 + 273.15);
            textBox3.Text = Convert.ToString((5.0 / 9) * (value - 32));
        }
    }
}