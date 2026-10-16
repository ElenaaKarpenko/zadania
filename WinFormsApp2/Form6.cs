using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "текст виден при нажатии на копку 1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "текст виден при нажатии на копку 2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label3.Text = "текст виден при нажатии на копку 3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label4.Text = "текст виден при нажатии на копку 4";
        }
    }
}
