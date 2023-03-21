namespace ProgettoDiShadowGroup
{
    partial class FormProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox_Category = new System.Windows.Forms.ComboBox();
            this.comboBox_Brand = new System.Windows.Forms.ComboBox();
            this.textBox_Product_Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Model_Year = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_List_price = new System.Windows.Forms.TextBox();
            this.btn_Add_Product = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox_Category
            // 
            this.comboBox_Category.FormattingEnabled = true;
            this.comboBox_Category.Location = new System.Drawing.Point(627, 55);
            this.comboBox_Category.Name = "comboBox_Category";
            this.comboBox_Category.Size = new System.Drawing.Size(150, 28);
            this.comboBox_Category.TabIndex = 0;
            // 
            // comboBox_Brand
            // 
            this.comboBox_Brand.FormattingEnabled = true;
            this.comboBox_Brand.Location = new System.Drawing.Point(466, 55);
            this.comboBox_Brand.Name = "comboBox_Brand";
            this.comboBox_Brand.Size = new System.Drawing.Size(155, 28);
            this.comboBox_Brand.TabIndex = 1;
            // 
            // textBox_Product_Name
            // 
            this.textBox_Product_Name.Location = new System.Drawing.Point(27, 55);
            this.textBox_Product_Name.Name = "textBox_Product_Name";
            this.textBox_Product_Name.Size = new System.Drawing.Size(413, 26);
            this.textBox_Product_Name.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Product Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(623, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Category";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Model Year";
            // 
            // textBox_Model_Year
            // 
            this.textBox_Model_Year.Location = new System.Drawing.Point(27, 162);
            this.textBox_Model_Year.Name = "textBox_Model_Year";
            this.textBox_Model_Year.Size = new System.Drawing.Size(158, 26);
            this.textBox_Model_Year.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(462, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Brand";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "List Price";
            // 
            // textBox_List_price
            // 
            this.textBox_List_price.Location = new System.Drawing.Point(27, 256);
            this.textBox_List_price.Name = "textBox_List_price";
            this.textBox_List_price.Size = new System.Drawing.Size(158, 26);
            this.textBox_List_price.TabIndex = 8;
            // 
            // btn_Add_Product
            // 
            this.btn_Add_Product.Location = new System.Drawing.Point(506, 333);
            this.btn_Add_Product.Name = "btn_Add_Product";
            this.btn_Add_Product.Size = new System.Drawing.Size(271, 95);
            this.btn_Add_Product.TabIndex = 10;
            this.btn_Add_Product.Text = "Add Product";
            this.btn_Add_Product.UseVisualStyleBackColor = true;
            // 
            // FormProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Add_Product);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_List_price);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_Model_Year);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Product_Name);
            this.Controls.Add(this.comboBox_Brand);
            this.Controls.Add(this.comboBox_Category);
            this.Name = "FormProduct";
            this.Text = "FormProducts";
            this.Load += new System.EventHandler(this.FormProduct_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_Category;
        private System.Windows.Forms.ComboBox comboBox_Brand;
        private System.Windows.Forms.TextBox textBox_Product_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Model_Year;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_List_price;
        private System.Windows.Forms.Button btn_Add_Product;
    }
}