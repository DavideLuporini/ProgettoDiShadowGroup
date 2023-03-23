using System;
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
            FormCategory f1 = new FormCategory();
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
            var categories = new List<category>();
            categories.Add(new category() { category_id = -1, category_name = "nessuna selezione" });
            categories.AddRange(ctx.categories.ToList());
            comboBox_Filter_Category.DataSource = categories;
            comboBox_Filter_Category.ValueMember = "category_id";
            comboBox_Filter_Category.DisplayMember = "category_name";
        }
        public void FillBrandComboBox()
        {
            //TODO agggiungi come sopra
            var brands = new List<brand>();
            brands.Add(new brand() { brand_id = -1, brand_name = "nessuna selezione" });
            brands.AddRange(ctx.brands.ToList());
            comboBox_Filter_Brand.DataSource = brands;
            comboBox_Filter_Brand.ValueMember = "brand_id";
            comboBox_Filter_Brand.DisplayMember = "brand_name";
        }


        public void FillDataViewGrid(int brand_id, int category_id)
        {
            var whereResult = ctx.products.Where(x => x.brand_id == brand_id && x.category_id == category_id);
            if (brand_id == -1 && category_id != -1) whereResult = ctx.products.Where(x => x.category_id == category_id);
            if (brand_id != -1 && category_id == -1) whereResult = ctx.products.Where(x => x.brand_id == brand_id);
            var table = (from product in whereResult
                         select product).ToList();
                         //new
                         //{
                         //    productId = product.product_id,
                         //    productName = product.product_name,
                         //    brandName = product.brand.brand_name,
                         //    categoryName = product.category.category_name,
                         //    modelYear = product.model_year,
                         //    listPrice = product.list_price,
                         //}).ToList();
            //var tableList = table.ToList();
            if (!table.Any())
            {
                dataGridView1.DataSource = null;
                MessageBox.Show("nessun elemento trovato");
            }
            else
            {
                dataGridView1.DataSource = table;
                //dataGridView1.ReadOnly= false;
                dataGridView1.Columns["brand_id"].Visible= false;
                dataGridView1.Columns["category_id"].Visible= false;
                //dataGridView1.Columns["category"].DataGridView.DataSource = ctx.products.Select(x => x.category_id == category_id);

                //dataGridView1.Columns["brand_id"].DataPropertyName
            }
        }

        private void btn_Filter_Click(object sender, EventArgs e)
        {
            var brand_id = (int)comboBox_Filter_Brand.SelectedValue;
            var category_id = (int)comboBox_Filter_Category.SelectedValue;
            FillDataViewGrid(brand_id, category_id);
        }

        private void comboBox_Filter_Brand_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var brand_id = (int)comboBox_Filter_Brand.SelectedValue;
            var category_id = (int)comboBox_Filter_Category.SelectedValue;
            FillDataViewGrid(brand_id, category_id);
        }

        private void comboBox_Filter_Category_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var brand_id = (int)comboBox_Filter_Brand.SelectedValue;
            var category_id = (int)comboBox_Filter_Category.SelectedValue;
            FillDataViewGrid(brand_id, category_id);
        }

        private void btn_Save_Changes_Click(object sender, EventArgs e)
        {
            ctx.SaveChanges();
            MessageBox.Show("Hai modificato questo elemento");
        }
    }
}
