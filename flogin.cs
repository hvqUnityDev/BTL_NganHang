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
    public partial class flogin : Form
    {
        public flogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            fKhachHang fKhachHang = new fKhachHang();   
            fKhachHang.ShowDialog();
            this.Show();    
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void flogin_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (MessageBox.Show(" Bạn có muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
