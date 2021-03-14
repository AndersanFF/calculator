using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int number = int.Parse(textBox1.Text);
            if (radioButton1.Checked)
            {
                if (radioButton5.Checked)
                {
                    textBox2.Text = number.ToString(); 
                    
                }
                if (radioButton6.Checked)
                {
                    string binary = textBox1.Text;
                    int integer = Convert.ToInt32(binary, 2);
                    textBox2.Text = Convert.ToString(integer, 8);

                }
                if (radioButton7.Checked)
                {
                    int gotovo = 0;
                    int num;
                    string bin = textBox1.Text;
                    int n = bin.Length;
                    foreach (char symbol in bin)
                    {
                        num = int.Parse(symbol.ToString());
                        gotovo += num * (int)Math.Pow(2, n-1);
                        n -= 1;

                    }
                    textBox2.Text = gotovo.ToString();
                }
                if (radioButton8.Checked)
                {
                    string binary = textBox1.Text;
                    int integer = Convert.ToInt32(binary, 2);
                    textBox2.Text = Convert.ToString(integer, 16);
                }
            }
            if (radioButton2.Checked)
            {
                if (radioButton5.Checked)
                {
                    string binary = textBox1.Text;
                    int integer = Convert.ToInt32(binary, 8);
                    textBox2.Text = Convert.ToString(integer, 2);
                }
                if (radioButton6.Checked)
                {
                    textBox2.Text = number.ToString();
                }
                if (radioButton7.Checked)
                {
                    string binary = textBox1.Text;
                    int integer = Convert.ToInt32(binary, 8);
                    textBox2.Text = Convert.ToString(integer, 10);
                }
                if (radioButton8.Checked)
                {
                    string binary = textBox1.Text;
                    int integer = Convert.ToInt32(binary, 8);
                    textBox2.Text = Convert.ToString(integer, 16);
                }
            }
            if (radioButton3.Checked)
            {
                if (radioButton5.Checked)
                {
                    int chislo = int.Parse(textBox1.Text);
                    string todec = "";
                    int delenie = chislo;
                    string ostatok = "";
                    while (delenie == 0 || delenie == 1)
                    {
                        todec += delenie % 2;
                        delenie /= 2;
                    }
                    for (int i = todec.Length - 1; i > 0; i--)
                    {
                        ostatok += todec[i];
                    }
                }
                if (radioButton6.Checked)
                {
                    string binary = textBox1.Text;
                    int integer = Convert.ToInt32(binary, 10);
                    textBox2.Text = Convert.ToString(integer, 8);
                }
                if (radioButton7.Checked)
                {
                    textBox2.Text = number.ToString();
                }
                if (radioButton8.Checked)
                {
                    string binary = textBox1.Text;
                    int integer = Convert.ToInt32(binary, 10);
                    textBox2.Text = Convert.ToString(integer, 16);
                }
            }
            if (radioButton4.Checked)
            {
                if (radioButton5.Checked)
                {
                    string binary = textBox1.Text;
                    int integer = Convert.ToInt32(binary, 16);
                    textBox2.Text = Convert.ToString(integer, 2);
                }
                if (radioButton6.Checked)
                {
                    string binary = textBox1.Text;
                    int integer = Convert.ToInt32(binary, 16);
                    textBox2.Text = Convert.ToString(integer, 8);
                }
                if (radioButton7.Checked)
                {
                    string binary = textBox1.Text;
                    int integer = Convert.ToInt32(binary, 16);
                    textBox2.Text = Convert.ToString(integer, 10);
                }
                if (radioButton8.Checked)
                {
                    textBox2.Text = number.ToString();
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
