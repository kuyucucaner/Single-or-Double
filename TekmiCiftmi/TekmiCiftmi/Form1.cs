﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TekmiCiftmi
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

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(textBox1.Text);
            if (sayi % 2 == 0)
                MessageBox.Show("Girilen Sayı Bir ÇİFT Sayıdır!");
            else
                MessageBox.Show("Girilen Sayı Bir TEK Sayıdır!");
        }
    }
}
