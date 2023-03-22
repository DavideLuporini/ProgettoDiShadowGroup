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
    public partial class FormCategory : Form
    {
        private db_a967b2_dblogintestEntities ctx;
        public FormCategory()
        {
            InitializeComponent();
            ctx = new db_a967b2_dblogintestEntities();
        }

        private void btn_Add_Category_Click(object sender, EventArgs e)
        {
            AddCategory();
        }
        private void AddCategory()
        {
            category cat = new category();
            cat.category_name = textBox_Category_Name.Text.Trim();
            if (cat.category_name != "" && cat.category_name != null)
            {
                if (ctx.categories.Any(x => x.category_name == cat.category_name))
                {
                    MessageBox.Show("La categoria inserita esiste già");
                }
                else
                {
                    ctx.categories.Add(cat);
                    ctx.SaveChanges();
                    textBox_Category_Name.Clear();
                    MessageBox.Show("Hai aggiunto una nuova categoria!");
                }
            }
            else
            {
                MessageBox.Show("Non hai inserito nessuna categoria");
            }
        }
    }
}
