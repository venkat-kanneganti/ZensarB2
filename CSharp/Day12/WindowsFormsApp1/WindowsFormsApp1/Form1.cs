﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Form1 invoked");
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hi All!! I am a Button in the Form ");
            if(UserName.Text=="Zensar")
            {
                MessageBox.Show("It is a company name");
            }
        }

        private void BtnLogin_MouseEnter(object sender, EventArgs e)
        {
            BtnLogin.BackColor = Color.Red;          

        }

        private void BtnLogin_MouseLeave(object sender, EventArgs e)
        {
            BtnLogin.ForeColor = Color.White;
        }
    }
}