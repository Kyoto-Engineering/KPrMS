namespace ProductManagementSystem.Reports
{
    partial class WithoutPriceProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WithoutPriceProduct));
            this.label1 = new System.Windows.Forms.Label();
            this.BrandNameComboBox = new System.Windows.Forms.ComboBox();
            this.GetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Brand Name    :";
            // 
            // BrandNameComboBox
            // 
            this.BrandNameComboBox.FormattingEnabled = true;
            this.BrandNameComboBox.Location = new System.Drawing.Point(148, 19);
            this.BrandNameComboBox.Name = "BrandNameComboBox";
            this.BrandNameComboBox.Size = new System.Drawing.Size(183, 21);
            this.BrandNameComboBox.TabIndex = 1;
            // 
            // GetButton
            // 
            this.GetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetButton.Location = new System.Drawing.Point(180, 195);
            this.GetButton.Name = "GetButton";
            this.GetButton.Size = new System.Drawing.Size(76, 30);
            this.GetButton.TabIndex = 2;
            this.GetButton.Text = "GET";
            this.GetButton.UseVisualStyleBackColor = true;
            this.GetButton.Click += new System.EventHandler(this.GetButton_Click);
            // 
            // WithoutPriceProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 250);
            this.Controls.Add(this.GetButton);
            this.Controls.Add(this.BrandNameComboBox);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WithoutPriceProduct";
            this.Text = "WithoutPriceProduct";
            this.Load += new System.EventHandler(this.WithoutPriceProduct_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox BrandNameComboBox;
        private System.Windows.Forms.Button GetButton;
    }
}