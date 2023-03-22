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
    public partial class FormBrand : Form
    {
        private db_a967b2_dblogintestEntities ctx;
        public FormBrand()
        {
            InitializeComponent();
            ctx  = new db_a967b2_dblogintestEntities();
        }

        private void btn_Add_Brand_Click(object sender, EventArgs e)
        {
            AddBrand();
        }
        private void AddBrand()
        {
            brand br = new brand();
            br.brand_name = textBox_Brand_Name.Text.Trim();
            if (br.brand_name != ""  &&  br.brand_name != null )
            {
                ctx.brands.Add(br);
                ctx.SaveChanges();
                textBox_Brand_Name.Clear();
                MessageBox.Show(" Hai aggiunto un nuovo Brand con successo!");
            }
            else
            {
                MessageBox.Show(" Non hai inserito nessun Brand");
            }
                

        }

    }
}
