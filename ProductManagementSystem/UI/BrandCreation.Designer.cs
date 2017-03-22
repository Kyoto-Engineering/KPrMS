namespace ProductManagementSystem.UI
{
    partial class BrandCreation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BrandCreation));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.blIBrowseButton = new System.Windows.Forms.Button();
            this.bfIBrowseButton = new System.Windows.Forms.Button();
            this.txtBrandLogoImage = new System.Windows.Forms.PictureBox();
            this.txtBrandFooterImage = new System.Windows.Forms.PictureBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.txtBrandCode = new System.Windows.Forms.TextBox();
            this.txtBrandName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBrandLogoImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBrandFooterImage)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.blIBrowseButton);
            this.groupBox1.Controls.Add(this.bfIBrowseButton);
            this.groupBox1.Controls.Add(this.txtBrandLogoImage);
            this.groupBox1.Controls.Add(this.txtBrandFooterImage);
            this.groupBox1.Controls.Add(this.submitButton);
            this.groupBox1.Controls.Add(this.txtBrandCode);
            this.groupBox1.Controls.Add(this.txtBrandName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(950, 460);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(516, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 22);
            this.label6.TabIndex = 27;
            this.label6.Text = "Brand Logo Image";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(6, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(604, 17);
            this.label5.TabIndex = 26;
            this.label5.Text = "(Image Type must be PNG with white Background and Width= 2176 And height =300 Pix" +
    "el)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 22);
            this.label4.TabIndex = 25;
            this.label4.Text = "Brand Footer Image";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(453, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 24;
            // 
            // blIBrowseButton
            // 
            this.blIBrowseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.blIBrowseButton.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blIBrowseButton.Location = new System.Drawing.Point(686, 235);
            this.blIBrowseButton.Name = "blIBrowseButton";
            this.blIBrowseButton.Size = new System.Drawing.Size(208, 36);
            this.blIBrowseButton.TabIndex = 3;
            this.blIBrowseButton.Text = "Browse";
            this.blIBrowseButton.UseVisualStyleBackColor = false;
            this.blIBrowseButton.Click += new System.EventHandler(this.blIBrowseButton_Click);
            // 
            // bfIBrowseButton
            // 
            this.bfIBrowseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bfIBrowseButton.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bfIBrowseButton.Location = new System.Drawing.Point(36, 313);
            this.bfIBrowseButton.Name = "bfIBrowseButton";
            this.bfIBrowseButton.Size = new System.Drawing.Size(187, 36);
            this.bfIBrowseButton.TabIndex = 2;
            this.bfIBrowseButton.Text = "Browse";
            this.bfIBrowseButton.UseVisualStyleBackColor = false;
            this.bfIBrowseButton.Click += new System.EventHandler(this.bfIBrowseButton_Click);
            // 
            // txtBrandLogoImage
            // 
            this.txtBrandLogoImage.BackgroundImage = global::ProductManagementSystem.Properties.Resources._12;
            this.txtBrandLogoImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtBrandLogoImage.Location = new System.Drawing.Point(686, 19);
            this.txtBrandLogoImage.Name = "txtBrandLogoImage";
            this.txtBrandLogoImage.Size = new System.Drawing.Size(212, 210);
            this.txtBrandLogoImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.txtBrandLogoImage.TabIndex = 7;
            this.txtBrandLogoImage.TabStop = false;
            // 
            // txtBrandFooterImage
            // 
            this.txtBrandFooterImage.BackgroundImage = global::ProductManagementSystem.Properties.Resources.img12;
            this.txtBrandFooterImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtBrandFooterImage.Location = new System.Drawing.Point(6, 227);
            this.txtBrandFooterImage.Name = "txtBrandFooterImage";
            this.txtBrandFooterImage.Size = new System.Drawing.Size(574, 80);
            this.txtBrandFooterImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.txtBrandFooterImage.TabIndex = 6;
            this.txtBrandFooterImage.TabStop = false;
            // 
            // submitButton
            // 
            this.submitButton.BackColor = System.Drawing.Color.Orchid;
            this.submitButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.ForeColor = System.Drawing.Color.White;
            this.submitButton.Location = new System.Drawing.Point(752, 374);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(192, 80);
            this.submitButton.TabIndex = 4;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // txtBrandCode
            // 
            this.txtBrandCode.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBrandCode.Location = new System.Drawing.Point(170, 78);
            this.txtBrandCode.MaxLength = 3;
            this.txtBrandCode.Name = "txtBrandCode";
            this.txtBrandCode.Size = new System.Drawing.Size(283, 29);
            this.txtBrandCode.TabIndex = 1;
            this.txtBrandCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBrandCode_KeyDown);
            // 
            // txtBrandName
            // 
            this.txtBrandName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBrandName.Location = new System.Drawing.Point(170, 32);
            this.txtBrandName.Name = "txtBrandName";
            this.txtBrandName.Size = new System.Drawing.Size(283, 29);
            this.txtBrandName.TabIndex = 0;
            this.txtBrandName.TextChanged += new System.EventHandler(this.txtBrandName_TextChanged);
            this.txtBrandName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBrandName_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Brand Code";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Brand Name";
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.HotPink;
            this.closeButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.ForeColor = System.Drawing.Color.White;
            this.closeButton.Location = new System.Drawing.Point(969, 5);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(72, 35);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // BrandCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(1040, 471);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.closeButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BrandCreation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BrandCreation";
            this.Load += new System.EventHandler(this.BrandCreation_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBrandLogoImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBrandFooterImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.TextBox txtBrandCode;
        private System.Windows.Forms.TextBox txtBrandName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox txtBrandLogoImage;
        private System.Windows.Forms.PictureBox txtBrandFooterImage;
        public System.Windows.Forms.Button blIBrowseButton;
        public System.Windows.Forms.Button bfIBrowseButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
    }
}