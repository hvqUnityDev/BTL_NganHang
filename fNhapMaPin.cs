﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class fNhapMaPin : Form
    {
        public fNhapMaPin()
        {
            InitializeComponent();
        }

        private void fnhapmapin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            fNhapMaOTP otp = new fNhapMaOTP();
            this.Hide();
            otp.ShowDialog();
            this.Show();   
        }
    }
}