using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TempConv
{
    public partial class Form1 : Form
    {
        public double rezultat;
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (kombo.SelectedIndex == 1) {
                rezultat = Convert.ToDouble(textBox1.Text) + 273.15;
                textBox2.Text = Convert.ToString(rezultat);
                tekstic.Text = "K";
            
            }
            if (kombo.SelectedIndex == 0)
            {
                rezultat = (Convert.ToDouble(textBox1.Text)*1.8)+32;
                textBox2.Text = Convert.ToString(rezultat);
                tekstic.Text = "F";

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
