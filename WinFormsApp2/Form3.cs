using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form3 : Form
    {
        private readonly Random rand = new Random();
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int r = rand.Next(256);
            int g = rand.Next(256);
            int b = rand.Next(256);
            this.BackColor = Color.FromArgb(r, g, b);
        }
    }
}
