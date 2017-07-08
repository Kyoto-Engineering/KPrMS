namespace ProductManagementSystem.Reports
{
    partial class ReportByBrand
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
            this.label1 = new System.Windows.Forms.Label();
            this.BrandIdComboBox = new System.Windows.Forms.ComboBox();
            this.GetButton = new System.Windows.Forms.Button();
            this.ProListRadioButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Brand Id          :";
            // 
            // BrandIdComboBox
            // 
            this.BrandIdComboBox.FormattingEnabled = true;
            this.BrandIdComboBox.Location = new System.Drawing.Point(168, 25);
            this.BrandIdComboBox.Name = "BrandIdComboBox";
            this.BrandIdComboBox.Size = new System.Drawing.Size(121, 21);
            this.BrandIdComboBox.TabIndex = 1;
            // 
            // GetButton
            // 
            this.GetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetButton.Location = new System.Drawing.Point(168, 137);
            this.GetButton.Name = "GetButton";
            this.GetButton.Size = new System.Drawing.Size(71, 30);
            this.GetButton.TabIndex = 2;
            this.GetButton.Text = "GET";
            this.GetButton.UseVisualStyleBackColor = true;
            this.GetButton.Click += new System.EventHandler(this.GetButton_Click);
            // 
            // ProListRadioButton
            // 
            this.ProListRadioButton.AutoSize = true;
            this.ProListRadioButton.Location = new System.Drawing.Point(168, 72);
            this.ProListRadioButton.Name = "ProListRadioButton";
            this.ProListRadioButton.Size = new System.Drawing.Size(81, 17);
            this.ProListRadioButton.TabIndex = 3;
            this.ProListRadioButton.TabStop = true;
            this.ProListRadioButton.Text = "Product List";
            this.ProListRadioButton.UseVisualStyleBackColor = true;
            // 
            // ReportByBrand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 231);
            this.Controls.Add(this.ProListRadioButton);
            this.Controls.Add(this.GetButton);
            this.Controls.Add(this.BrandIdComboBox);
            this.Controls.Add(this.label1);
            this.Name = "ReportByBrand";
            this.Text = "Report By Brand";
            this.Load += new System.EventHandler(this.ReportByBrand_load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox BrandIdComboBox;
        private System.Windows.Forms.Button GetButton;
        private System.Windows.Forms.RadioButton ProListRadioButton;
    }
}