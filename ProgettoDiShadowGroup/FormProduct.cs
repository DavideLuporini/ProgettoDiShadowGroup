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

    }
}
