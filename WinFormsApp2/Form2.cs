using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form2 : Form
    {
        private int secret;
        private int popit;
        private readonly Random rand = new Random();
        public Form2()
        {
            InitializeComponent();
            Start();
        }
        private void Start()
        {
            secret = rand.Next(1, 10);
            popit = 0;
           textBox1.Clear();
            label1.Text = "";
            label5.Text = "Попытки: 0";
            textBox1.Focus();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {





        }

        private void button1_Click(object sender, EventArgs e)
        {
                if (!int.TryParse(textBox1.Text, out int userNumber))
                {
                    //return;
                }

                popit++;
            label5.Text = "Попытки: " + popit;

                if (userNumber == secret)
                {
                    label3.Text = "Вы угадали!";
                    //return;
                }

                if (userNumber < secret)
                label1.Text = "Загаданное число больше.";
                else
                label1.Text = "Загаданное число меньше.";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Start();
        }
    }
}
