﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            FillCategoryComboBox();
            FillBrandComboBox();
        }

        public void FillCategoryComboBox()
        {
            comboBox_Filter_Category.DataSource = ctx.categories.ToList();
            comboBox_Filter_Category.ValueMember = "category_id";
            comboBox_Filter_Category.DisplayMember = "category_name";
        }
        public void FillBrandComboBox()
        {
            comboBox_Filter_Brand.DataSource = ctx.brands.ToList();
            comboBox_Filter_Brand.ValueMember = "brand_id";
            comboBox_Filter_Brand.DisplayMember = "brand_name";
        }


        public void fillDataViewGrid( int brand_id , int category_id)
        {
            var table = from product in ctx.products.Where(x => x.brand_id == brand_id && x.category_id == category_id)
                        select new
                        {
                            productId = product.product_id,
                            productName = product.product_name,
                            brandName = product.brand.brand_name,
                            categoryName = product.category.category_name,
                            modelYear = product.model_year,
                            listPrice = product.list_price,
                        };
            dataGridView1.DataSource = table.ToList();
        }

        private void btn_Filter_Click(object sender, EventArgs e)
        {
            var brand = comboBox_Filter_Brand.SelectedItem as DataRowView;
            var brand_id = int.Parse($"{brand["brand_id"]}");
            var category = comboBox_Filter_Category.SelectedItem as DataRowView;
            var category_id = int.Parse($"{category["category_id"]}");
            fillDataViewGrid(brand_id, category_id);
        }
    }
}
