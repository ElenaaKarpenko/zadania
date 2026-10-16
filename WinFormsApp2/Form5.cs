using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = textBox1.Text;
            button1.Text = a;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string a = textBox1.Text;
            button2.Text = a;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string a = textBox1.Text;
            button3.Text = a;
        }
    }
}
