﻿namespace ProductManagementSystem.Reports
{
    partial class PriceInquiryReport
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
            this.PrInIdComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GetButton
            // 
            this.GetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetButton.Location = new System.Drawing.Point(223, 214);
            this.GetButton.Name = "GetButton";
            this.GetButton.Size = new System.Drawing.Size(84, 45);
            this.GetButton.TabIndex = 0;
            this.GetButton.Text = "GET";
            this.GetButton.UseVisualStyleBackColor = true;
            this.GetButton.Click += new System.EventHandler(this.GetButton_Click);
            // 
            // PrInIdComboBox
            // 
            this.PrInIdComboBox.FormattingEnabled = true;
            this.PrInIdComboBox.Location = new System.Drawing.Point(180, 41);
            this.PrInIdComboBox.Name = "PrInIdComboBox";
            this.PrInIdComboBox.Size = new System.Drawing.Size(167, 21);
            this.PrInIdComboBox.TabIndex = 1;
            this.PrInIdComboBox.SelectedIndexChanged += new System.EventHandler(this.PrInIdComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Price Inquiry Id        :";
            // 
            // PriceInquiryReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 302);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PrInIdComboBox);
            this.Controls.Add(this.GetButton);
            this.Name = "PriceInquiryReport";
            this.Text = "PriceInquiryReport";
            this.Load += new System.EventHandler(this.PriceInquiryReport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GetButton;
        private System.Windows.Forms.ComboBox PrInIdComboBox;
        private System.Windows.Forms.Label label1;
    }
}