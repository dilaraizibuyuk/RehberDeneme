﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RehberDeneme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label9.Text = textBox1.Text;
            label10.Text = textBox2.Text;
            label11.Text = comboBox1.Text;
            label12.Text = textBox3.Text;

            //comboboxa veri ekleme
            comboBox2.Items.Add("İstanbul");
            comboBox2.Items.Add("Düzce");
            comboBox2.Items.Add("Sivas");
            comboBox2.Items.Add("Artvin");
            comboBox2.Items.Add("Sakarya");
            comboBox2.Items.Add("Bolu");

        }
    }
}
