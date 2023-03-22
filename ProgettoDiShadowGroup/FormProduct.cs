using System;
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
    public partial class FormProduct : Form
    {
        private db_a967b2_dblogintestEntities ctx;
        public FormProduct()
        {
            InitializeComponent();
            ctx = new db_a967b2_dblogintestEntities();
        }

        private void FormProduct_Load(object sender, EventArgs e)
        {
            FillBrandComboBox();
            FillCategoryComboBox();
        }

        public void FillBrandComboBox()
        {
            comboBox_Brand.DataSource = ctx.brands.ToList();
            comboBox_Brand.ValueMember = "brand_id";
            comboBox_Brand.DisplayMember = "brand_name";
        }
        public void FillCategoryComboBox()
        {
            comboBox_Category.DataSource = ctx.categories.ToList();
            comboBox_Category.ValueMember = "category_id";
            comboBox_Category.DisplayMember = "category_name";
        }

        private void btn_Add_Product_Click(object sender, EventArgs e)
        {
            product pr = new product();
            try{
            pr.product_name = textBox_Product_Name.Text.Trim();
            pr.list_price = int.Parse(textBox_List_price.Text.Trim());
            pr.brand_id = (int)comboBox_Brand.SelectedValue;
            pr.category_id = (int)comboBox_Category.SelectedValue;
            pr.model_year = short.Parse(textBox_Model_Year.Text.Trim());    
            ctx.products.Add(pr);
            ctx.SaveChanges();
            MessageBox.Show("Hai aggiunto un nuovo Brand con successo!");
            ClearElements();
            }
            catch(ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void ClearElements()
        {
            textBox_Product_Name.Clear();
            textBox_List_price.Clear();
            textBox_Model_Year.Clear();
            comboBox_Brand.SelectedValue = 0;
            comboBox_Category.SelectedValue = 0;

        }
    }
}
