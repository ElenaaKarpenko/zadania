using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form9 : Form
    {
        

        public Form9()
        {
            InitializeComponent();
        }


        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(textBox1.Text);
                int b = int.Parse(textBox3.Text);
                int res = 0;
                string op = textBox2.Text.Trim();

                switch (op)
                {
                    case "+":
                        res = a + b;
                        textBox4.Text = res.ToString();
                        break;

                    case "-":
                        res = a - b;
                        textBox4.Text = res.ToString();
                        break;


                    case "*":
                        res = a * b;
                        textBox4.Text = res.ToString();
                        break;
                    case "/":

                        res = a / b;
                        textBox4.Text = res.ToString();
                        break;
                }
            }
            catch (DivideByZeroException)
            {
                textBox4.Text = "Деление на 0";
            }
            catch (FormatException)
            {
                textBox4.Text = "Неверный формат данных";
            }
        }
    }
}
