﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void SurnametextBox_TextChanged(object sender, EventArgs e)
        {
            OKbutton.Enabled =
                !(string.IsNullOrWhiteSpace(SurnametextBox.Text) ||
                string.IsNullOrWhiteSpace(NametextBox.Text) ||
                string.IsNullOrWhiteSpace(LastNametextBox.Text) ||
                string.IsNullOrWhiteSpace(GendercomboBox.Text));
        }

        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OKbutton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
