namespace ProgettoDiShadowGroup
{
    partial class Form1
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
            this.comboBox_Filter_Category = new System.Windows.Forms.ComboBox();
            this.comboBox_Filter_Brand = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_Save_Changes = new System.Windows.Forms.Button();
            this.btn_Filter = new System.Windows.Forms.Button();
            this.btn_Show_Add_Category = new System.Windows.Forms.Button();
            this.btn_Show_Add_Brand = new System.Windows.Forms.Button();
            this.btn_Show_Add_Product = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_Filter_Category
            // 
            this.comboBox_Filter_Category.FormattingEnabled = true;
            this.comboBox_Filter_Category.Location = new System.Drawing.Point(31, 147);
            this.comboBox_Filter_Category.Name = "comboBox_Filter_Category";
            this.comboBox_Filter_Category.Size = new System.Drawing.Size(179, 28);
            this.comboBox_Filter_Category.TabIndex = 0;
            // 
            // comboBox_Filter_Brand
            // 
            this.comboBox_Filter_Brand.FormattingEnabled = true;
            this.comboBox_Filter_Brand.Location = new System.Drawing.Point(235, 147);
            this.comboBox_Filter_Brand.Name = "comboBox_Filter_Brand";
            this.comboBox_Filter_Brand.Size = new System.Drawing.Size(179, 28);
            this.comboBox_Filter_Brand.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 181);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(733, 216);
            this.dataGridView1.TabIndex = 2;
            // 
            // btn_Save_Changes
            // 
            this.btn_Save_Changes.Location = new System.Drawing.Point(574, 403);
            this.btn_Save_Changes.Name = "btn_Save_Changes";
            this.btn_Save_Changes.Size = new System.Drawing.Size(190, 35);
            this.btn_Save_Changes.TabIndex = 3;
            this.btn_Save_Changes.Text = "Salva";
            this.btn_Save_Changes.UseVisualStyleBackColor = true;
            // 
            // btn_Filter
            // 
            this.btn_Filter.Location = new System.Drawing.Point(645, 137);
            this.btn_Filter.Name = "btn_Filter";
            this.btn_Filter.Size = new System.Drawing.Size(119, 38);
            this.btn_Filter.TabIndex = 4;
            this.btn_Filter.Text = "Filtra";
            this.btn_Filter.UseVisualStyleBackColor = true;
            this.btn_Filter.Click += new System.EventHandler(this.btn_Filter_Click);
            // 
            // btn_Show_Add_Category
            // 
            this.btn_Show_Add_Category.Location = new System.Drawing.Point(31, 12);
            this.btn_Show_Add_Category.Name = "btn_Show_Add_Category";
            this.btn_Show_Add_Category.Size = new System.Drawing.Size(202, 81);
            this.btn_Show_Add_Category.TabIndex = 5;
            this.btn_Show_Add_Category.Text = "Aggiungi Categoria";
            this.btn_Show_Add_Category.UseVisualStyleBackColor = true;
            this.btn_Show_Add_Category.Click += new System.EventHandler(this.btn_Show_Add_Category_Click);
            // 
            // btn_Show_Add_Brand
            // 
            this.btn_Show_Add_Brand.Location = new System.Drawing.Point(562, 12);
            this.btn_Show_Add_Brand.Name = "btn_Show_Add_Brand";
            this.btn_Show_Add_Brand.Size = new System.Drawing.Size(202, 81);
            this.btn_Show_Add_Brand.TabIndex = 6;
            this.btn_Show_Add_Brand.Text = "Aggiungi Brand";
            this.btn_Show_Add_Brand.UseVisualStyleBackColor = true;
            this.btn_Show_Add_Brand.Click += new System.EventHandler(this.btn_Show_Add_Brand_Click);
            // 
            // btn_Show_Add_Product
            // 
            this.btn_Show_Add_Product.Location = new System.Drawing.Point(304, 12);
            this.btn_Show_Add_Product.Name = "btn_Show_Add_Product";
            this.btn_Show_Add_Product.Size = new System.Drawing.Size(202, 81);
            this.btn_Show_Add_Product.TabIndex = 7;
            this.btn_Show_Add_Product.Text = "Aggiungi Prodotto";
            this.btn_Show_Add_Product.UseVisualStyleBackColor = true;
            this.btn_Show_Add_Product.Click += new System.EventHandler(this.btn_Show_Add_Product_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Show_Add_Product);
            this.Controls.Add(this.btn_Show_Add_Brand);
            this.Controls.Add(this.btn_Show_Add_Category);
            this.Controls.Add(this.btn_Filter);
            this.Controls.Add(this.btn_Save_Changes);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox_Filter_Brand);
            this.Controls.Add(this.comboBox_Filter_Category);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_Filter_Category;
        private System.Windows.Forms.ComboBox comboBox_Filter_Brand;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Save_Changes;
        private System.Windows.Forms.Button btn_Filter;
        private System.Windows.Forms.Button btn_Show_Add_Category;
        private System.Windows.Forms.Button btn_Show_Add_Brand;
        private System.Windows.Forms.Button btn_Show_Add_Product;
    }
}

