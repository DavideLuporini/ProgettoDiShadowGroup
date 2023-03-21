namespace ProgettoDiShadowGroup
{
    partial class FormBrand
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
            this.textBox_Brand_Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Add_Brand = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_Brand_Name
            // 
            this.textBox_Brand_Name.Location = new System.Drawing.Point(12, 72);
            this.textBox_Brand_Name.Name = "textBox_Brand_Name";
            this.textBox_Brand_Name.Size = new System.Drawing.Size(272, 26);
            this.textBox_Brand_Name.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Brand Name";
            // 
            // btn_Add_Brand
            // 
            this.btn_Add_Brand.Location = new System.Drawing.Point(439, 248);
            this.btn_Add_Brand.Name = "btn_Add_Brand";
            this.btn_Add_Brand.Size = new System.Drawing.Size(142, 56);
            this.btn_Add_Brand.TabIndex = 2;
            this.btn_Add_Brand.Text = "Add brand";
            this.btn_Add_Brand.UseVisualStyleBackColor = true;
            // 
            // FormBrand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 316);
            this.Controls.Add(this.btn_Add_Brand);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Brand_Name);
            this.Name = "FormBrand";
            this.Text = "FormBrand";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Brand_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Add_Brand;
    }
}