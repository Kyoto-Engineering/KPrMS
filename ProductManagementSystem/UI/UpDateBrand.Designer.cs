namespace ProductManagementSystem.UI
{
    partial class UpDateBrand
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpDateBrand));
            this.txtBrandCode = new System.Windows.Forms.TextBox();
            this.txtBrandName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bfIBrowseButton = new System.Windows.Forms.Button();
            this.blIBrowseButton = new System.Windows.Forms.Button();
            this.txtUBrandLogoImage = new System.Windows.Forms.PictureBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.labelk = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtUBrandFooterImage = new System.Windows.Forms.PictureBox();
            this.backButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtUBrandLogoImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUBrandFooterImage)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBrandCode
            // 
            this.txtBrandCode.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBrandCode.Location = new System.Drawing.Point(192, 111);
            this.txtBrandCode.MaxLength = 3;
            this.txtBrandCode.Name = "txtBrandCode";
            this.txtBrandCode.Size = new System.Drawing.Size(193, 29);
            this.txtBrandCode.TabIndex = 2;
            this.txtBrandCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBrandCode_KeyDown);
            // 
            // txtBrandName
            // 
            this.txtBrandName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBrandName.Location = new System.Drawing.Point(192, 65);
            this.txtBrandName.MaxLength = 50;
            this.txtBrandName.Name = "txtBrandName";
            this.txtBrandName.Size = new System.Drawing.Size(193, 29);
            this.txtBrandName.TabIndex = 1;
            this.txtBrandName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBrandName_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Brand Code";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Brand Name";
            // 
            // bfIBrowseButton
            // 
            this.bfIBrowseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bfIBrowseButton.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bfIBrowseButton.Location = new System.Drawing.Point(360, 376);
            this.bfIBrowseButton.Name = "bfIBrowseButton";
            this.bfIBrowseButton.Size = new System.Drawing.Size(187, 36);
            this.bfIBrowseButton.TabIndex = 3;
            this.bfIBrowseButton.Text = "Browse";
            this.bfIBrowseButton.UseVisualStyleBackColor = false;
            this.bfIBrowseButton.Click += new System.EventHandler(this.bfIBrowseButton_Click);
            // 
            // blIBrowseButton
            // 
            this.blIBrowseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.blIBrowseButton.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blIBrowseButton.Location = new System.Drawing.Point(679, 249);
            this.blIBrowseButton.Name = "blIBrowseButton";
            this.blIBrowseButton.Size = new System.Drawing.Size(208, 36);
            this.blIBrowseButton.TabIndex = 4;
            this.blIBrowseButton.Text = "Browse";
            this.blIBrowseButton.UseVisualStyleBackColor = false;
            this.blIBrowseButton.Click += new System.EventHandler(this.blIBrowseButton_Click);
            // 
            // txtUBrandLogoImage
            // 
            this.txtUBrandLogoImage.BackgroundImage = global::ProductManagementSystem.Properties.Resources._12;
            this.txtUBrandLogoImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtUBrandLogoImage.Location = new System.Drawing.Point(632, 12);
            this.txtUBrandLogoImage.Name = "txtUBrandLogoImage";
            this.txtUBrandLogoImage.Size = new System.Drawing.Size(255, 231);
            this.txtUBrandLogoImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.txtUBrandLogoImage.TabIndex = 24;
            this.txtUBrandLogoImage.TabStop = false;
            // 
            // updateButton
            // 
            this.updateButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.Location = new System.Drawing.Point(907, 124);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(96, 60);
            this.updateButton.TabIndex = 26;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // labelk
            // 
            this.labelk.AutoSize = true;
            this.labelk.Location = new System.Drawing.Point(12, 410);
            this.labelk.Name = "labelk";
            this.labelk.Size = new System.Drawing.Size(35, 13);
            this.labelk.TabIndex = 27;
            this.labelk.Text = "label3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(110, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 22);
            this.label3.TabIndex = 28;
            this.label3.Text = "ID";
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(192, 23);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(193, 29);
            this.txtId.TabIndex = 0;
            this.txtId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtId_KeyDown);
            // 
            // txtUBrandFooterImage
            // 
            this.txtUBrandFooterImage.BackgroundImage = global::ProductManagementSystem.Properties.Resources.img12;
            this.txtUBrandFooterImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtUBrandFooterImage.Location = new System.Drawing.Point(12, 290);
            this.txtUBrandFooterImage.Name = "txtUBrandFooterImage";
            this.txtUBrandFooterImage.Size = new System.Drawing.Size(603, 80);
            this.txtUBrandFooterImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.txtUBrandFooterImage.TabIndex = 30;
            this.txtUBrandFooterImage.TabStop = false;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(907, 58);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(103, 60);
            this.backButton.TabIndex = 31;
            this.backButton.Text = ">>";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(907, -3);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(96, 55);
            this.closeButton.TabIndex = 32;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(11, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(604, 17);
            this.label5.TabIndex = 34;
            this.label5.Text = "(Image Type must be PNG with white Background and Width= 2176 And height =300 Pix" +
    "el)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 22);
            this.label4.TabIndex = 33;
            this.label4.Text = "Brand Footer Image";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(462, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 22);
            this.label6.TabIndex = 35;
            this.label6.Text = "Brand Logo Image";
            // 
            // UpDateBrand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(1009, 484);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.txtUBrandFooterImage);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelk);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.blIBrowseButton);
            this.Controls.Add(this.txtUBrandLogoImage);
            this.Controls.Add(this.bfIBrowseButton);
            this.Controls.Add(this.txtBrandCode);
            this.Controls.Add(this.txtBrandName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UpDateBrand";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpDateBrand";
            ((System.ComponentModel.ISupportInitialize)(this.txtUBrandLogoImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUBrandFooterImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public  System.Windows.Forms.TextBox txtBrandCode;
        public  System.Windows.Forms.TextBox txtBrandName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button bfIBrowseButton;
        public System.Windows.Forms.Button blIBrowseButton;
        public  System.Windows.Forms.PictureBox txtUBrandLogoImage;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        public  System.Windows.Forms.Label labelk;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtId;
        public  System.Windows.Forms.PictureBox txtUBrandFooterImage;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
    }
}