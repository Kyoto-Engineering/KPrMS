namespace ProductManagementSystem.Reports
{
    partial class ProductListWithStockStatusUI
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
            this.GetButton = new System.Windows.Forms.Button();
            this.BrandNameComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GetButton
            // 
            this.GetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetButton.Location = new System.Drawing.Point(169, 119);
            this.GetButton.Name = "GetButton";
            this.GetButton.Size = new System.Drawing.Size(76, 30);
            this.GetButton.TabIndex = 5;
            this.GetButton.Text = "GET";
            this.GetButton.UseVisualStyleBackColor = true;
            this.GetButton.Click += new System.EventHandler(this.GetButton_Click);
            // 
            // BrandNameComboBox
            // 
            this.BrandNameComboBox.FormattingEnabled = true;
            this.BrandNameComboBox.Location = new System.Drawing.Point(179, 46);
            this.BrandNameComboBox.Name = "BrandNameComboBox";
            this.BrandNameComboBox.Size = new System.Drawing.Size(183, 21);
            this.BrandNameComboBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Brand Name    :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ProductListWithStockStatusUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 233);
            this.Controls.Add(this.GetButton);
            this.Controls.Add(this.BrandNameComboBox);
            this.Controls.Add(this.label1);
            this.Name = "ProductListWithStockStatusUI";
            this.Text = "ProductListWithStockStatusUI";
            this.Load += new System.EventHandler(this.ProductListWithStockStatusUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GetButton;
        private System.Windows.Forms.ComboBox BrandNameComboBox;
        private System.Windows.Forms.Label label1;
    }
}