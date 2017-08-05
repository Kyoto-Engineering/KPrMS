namespace ProductManagementSystem.Reports
{
    partial class InquiryFeedbackReport
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
            this.PrInIdComboBox = new System.Windows.Forms.ComboBox();
            this.GetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Inquiry Id    :";
            // 
            // PrInIdComboBox
            // 
            this.PrInIdComboBox.FormattingEnabled = true;
            this.PrInIdComboBox.Location = new System.Drawing.Point(193, 37);
            this.PrInIdComboBox.Name = "PrInIdComboBox";
            this.PrInIdComboBox.Size = new System.Drawing.Size(156, 21);
            this.PrInIdComboBox.TabIndex = 1;
            this.PrInIdComboBox.SelectedIndexChanged += new System.EventHandler(this.PrInIdComboBox_SelectedIndexChanged);
            // 
            // GetButton
            // 
            this.GetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetButton.Location = new System.Drawing.Point(225, 229);
            this.GetButton.Name = "GetButton";
            this.GetButton.Size = new System.Drawing.Size(83, 37);
            this.GetButton.TabIndex = 2;
            this.GetButton.Text = "GET";
            this.GetButton.UseVisualStyleBackColor = true;
            this.GetButton.Click += new System.EventHandler(this.GetButton_Click);
            // 
            // InquiryFeedbackReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 293);
            this.Controls.Add(this.GetButton);
            this.Controls.Add(this.PrInIdComboBox);
            this.Controls.Add(this.label1);
            this.Name = "InquiryFeedbackReport";
            this.Text = "InquiryFeedbackReport";
            this.Load += new System.EventHandler(this.InquiryFeedbackReport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox PrInIdComboBox;
        private System.Windows.Forms.Button GetButton;
    }
}