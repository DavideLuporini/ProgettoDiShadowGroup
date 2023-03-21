using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgettoDiShadowGroup
{
    public partial class Form1 : Form
    {
        private db_a967b2_dblogintestEntities ctx;
        public Form1()
        {
            //db_a967b2_dblogintest_admin nome per login
            //PasswordDb_test1   password per login
            //SQL8001.site4now.net  nome server
            InitializeComponent();
            ctx = new db_a967b2_dblogintestEntities();
        }

        private void btn_Show_Add_Category_Click(object sender, EventArgs e)
        {
            FormBrand f1 = new FormBrand(); 
            f1.ShowDialog();
        }

        private void btn_Show_Add_Product_Click(object sender, EventArgs e)
        {
            FormProduct f2 = new FormProduct(); 
            f2.ShowDialog();
        }

        private void btn_Show_Add_Brand_Click(object sender, EventArgs e)
        {
            FormBrand f3 = new FormBrand();
            f3.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
