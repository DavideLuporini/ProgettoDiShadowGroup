namespace ProgettoDiShadowGroup
{
    partial class FormCategory
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
            this.textBox_Category_Name = new System.Windows.Forms.TextBox();
            this.btn_Add_Category = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_Category_Name
            // 
            this.textBox_Category_Name.Location = new System.Drawing.Point(12, 89);
            this.textBox_Category_Name.Name = "textBox_Category_Name";
            this.textBox_Category_Name.Size = new System.Drawing.Size(343, 26);
            this.textBox_Category_Name.TabIndex = 0;
            // 
            // btn_Add_Category
            // 
            this.btn_Add_Category.Location = new System.Drawing.Point(354, 213);
            this.btn_Add_Category.Name = "btn_Add_Category";
            this.btn_Add_Category.Size = new System.Drawing.Size(202, 65);
            this.btn_Add_Category.TabIndex = 1;
            this.btn_Add_Category.Text = "Add category";
            this.btn_Add_Category.UseVisualStyleBackColor = true;
            this.btn_Add_Category.Click += new System.EventHandler(this.btn_Add_Category_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Category Name";
            // 
            // FormCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 290);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Add_Category);
            this.Controls.Add(this.textBox_Category_Name);
            this.Name = "FormCategory";
            this.Text = "FormCategorie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Category_Name;
        private System.Windows.Forms.Button btn_Add_Category;
        private System.Windows.Forms.Label label1;
    }
}