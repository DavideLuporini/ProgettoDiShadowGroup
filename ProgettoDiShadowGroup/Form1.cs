﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgettoDiShadowGroup
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            //db_a967b2_dblogintest_admin nome per login
            //PasswordDb_test1   password per login
            //SQL8001.site4now.net  nome server
            InitializeComponent();
        }

        private void btn_Show_Add_Category_Click(object sender, EventArgs e)
        {
            FormBrand f1 = new FormBrand(); f1.Show();
        }
    }
}
