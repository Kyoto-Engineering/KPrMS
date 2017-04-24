namespace ProductManagementSystem.UI
{
    partial class frmProductUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductUpdate));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.browseButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.txtUProductId = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtUPrice = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtUItemCode = new System.Windows.Forms.TextBox();
            this.txtUItemDescription = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUProductName = new System.Windows.Forms.TextBox();
            this.labelk = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.cmbBrand = new System.Windows.Forms.ComboBox();
            this.cmbCountryOfOrigin = new System.Windows.Forms.ComboBox();
            this.txtUPictureBox = new System.Windows.Forms.PictureBox();
            this.txtUKBrandName = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtUPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Blue;
            this.button2.Location = new System.Drawing.Point(990, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(59, 47);
            this.button2.TabIndex = 3;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(913, 196);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 42);
            this.button1.TabIndex = 2;
            this.button1.Text = "New";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // browseButton
            // 
            this.browseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.browseButton.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseButton.ForeColor = System.Drawing.Color.Blue;
            this.browseButton.Location = new System.Drawing.Point(551, 378);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(300, 54);
            this.browseButton.TabIndex = 8;
            this.browseButton.Text = "&Browse";
            this.browseButton.UseVisualStyleBackColor = false;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.backButton.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.Color.Blue;
            this.backButton.Location = new System.Drawing.Point(910, 129);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(105, 49);
            this.backButton.TabIndex = 0;
            this.backButton.Text = ">>";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.updateButton.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.ForeColor = System.Drawing.Color.Blue;
            this.updateButton.Location = new System.Drawing.Point(913, 256);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(102, 48);
            this.updateButton.TabIndex = 1;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // txtUProductId
            // 
            this.txtUProductId.Location = new System.Drawing.Point(274, 31);
            this.txtUProductId.Name = "txtUProductId";
            this.txtUProductId.ReadOnly = true;
            this.txtUProductId.Size = new System.Drawing.Size(238, 29);
            this.txtUProductId.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(117, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 22);
            this.label10.TabIndex = 18;
            this.label10.Text = "Product Id";
            // 
            // txtUPrice
            // 
            this.txtUPrice.Location = new System.Drawing.Point(274, 440);
            this.txtUPrice.Name = "txtUPrice";
            this.txtUPrice.Size = new System.Drawing.Size(238, 29);
            this.txtUPrice.TabIndex = 7;
            this.txtUPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUPrice_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(139, 403);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 22);
            this.label9.TabIndex = 15;
            this.label9.Text = " Select Brand";
            // 
            // txtUItemCode
            // 
            this.txtUItemCode.Location = new System.Drawing.Point(276, 162);
            this.txtUItemCode.Name = "txtUItemCode";
            this.txtUItemCode.Size = new System.Drawing.Size(236, 29);
            this.txtUItemCode.TabIndex = 3;
            // 
            // txtUItemDescription
            // 
            this.txtUItemDescription.Location = new System.Drawing.Point(275, 125);
            this.txtUItemDescription.Name = "txtUItemDescription";
            this.txtUItemDescription.Size = new System.Drawing.Size(237, 29);
            this.txtUItemDescription.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(249, 22);
            this.label7.TabIndex = 10;
            this.label7.Text = " Product Generic Description";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(145, 447);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 22);
            this.label6.TabIndex = 9;
            this.label6.Text = "Price (in Tk)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(107, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "Country Of Origin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-85, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Features";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(164, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Item Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Item Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Product Name  or";
            // 
            // txtUProductName
            // 
            this.txtUProductName.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUProductName.Location = new System.Drawing.Point(275, 85);
            this.txtUProductName.Name = "txtUProductName";
            this.txtUProductName.Size = new System.Drawing.Size(237, 32);
            this.txtUProductName.TabIndex = 1;
            // 
            // labelk
            // 
            this.labelk.AutoSize = true;
            this.labelk.Location = new System.Drawing.Point(15, 518);
            this.labelk.Name = "labelk";
            this.labelk.Size = new System.Drawing.Size(41, 13);
            this.labelk.TabIndex = 16;
            this.labelk.Text = "label11";
            this.labelk.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Controls.Add(this.cmbBrand);
            this.groupBox1.Controls.Add(this.cmbCountryOfOrigin);
            this.groupBox1.Controls.Add(this.browseButton);
            this.groupBox1.Controls.Add(this.txtUPictureBox);
            this.groupBox1.Controls.Add(this.txtUProductId);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtUPrice);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtUItemCode);
            this.groupBox1.Controls.Add(this.txtUItemDescription);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtUProductName);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(15, 30);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(876, 476);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product Info";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(720, 50);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(131, 22);
            this.label11.TabIndex = 9;
            this.label11.Text = "Product Image";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(144, 240);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 22);
            this.label8.TabIndex = 27;
            this.label8.Text = "Specification";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(276, 237);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(236, 151);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // cmbBrand
            // 
            this.cmbBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBrand.FormattingEnabled = true;
            this.cmbBrand.Location = new System.Drawing.Point(274, 404);
            this.cmbBrand.Name = "cmbBrand";
            this.cmbBrand.Size = new System.Drawing.Size(236, 30);
            this.cmbBrand.TabIndex = 6;
            this.cmbBrand.SelectedIndexChanged += new System.EventHandler(this.cmbBrand_SelectedIndexChanged);
            this.cmbBrand.SelectionChangeCommitted += new System.EventHandler(this.cmbBrand_SelectionChangeCommitted);
            // 
            // cmbCountryOfOrigin
            // 
            this.cmbCountryOfOrigin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCountryOfOrigin.FormattingEnabled = true;
            this.cmbCountryOfOrigin.Items.AddRange(new object[] {
            "Afghanistan",
            "Albania",
            "Algeria",
            "Andorra",
            "Angola",
            "Antigua and Barbuda",
            "Argentina",
            "Armenia",
            "Australia",
            "Austria",
            "Azerbaijan",
            "Bahamas",
            "Bahrain",
            "Bangladesh",
            "Barbados",
            "Belarus",
            "Belgium",
            "Belize",
            "Benin",
            "Bhutan",
            "Bolivia",
            "Bosnia and Herzegovina",
            "Botswana",
            "Brazil",
            "Brunei",
            "Bulgaria",
            "Burkina Faso",
            "Burundi",
            "Cabo Verde",
            "Cambodia",
            "Cameroon",
            "Canada",
            "Central African Republic (CAR)",
            "Chad",
            "Chile",
            "China",
            "Colombia",
            "Comoros",
            "Democratic Republic of the Congo",
            "Republic of the Congo",
            "Costa Rica",
            "Cote d\'Ivoire",
            "Croatia",
            "Cuba",
            "Cyprus",
            "Czech Republic",
            "Denmark",
            "Djibouti",
            "Dominica",
            "Dominican Republic",
            "Ecuador",
            "Egypt",
            "El Salvador",
            "Equatorial Guinea",
            "Eritrea",
            "Estonia",
            "Ethiopia",
            "Europe",
            "Fiji",
            "Finland",
            "France",
            "Gabon",
            "Gambia",
            "Georgia",
            "Germany",
            "Ghana",
            "Greece",
            "Grenada",
            "Guatemala",
            "Guinea",
            "Guinea-Bissau",
            "Guyana",
            "Haiti",
            "Honduras",
            "Hungary",
            "Iceland",
            "India",
            "Indonesia",
            "Iran",
            "Iraq",
            "Ireland",
            "Israel",
            "Italy",
            "Jamaica",
            "Japan",
            "Jordan",
            "Kazakhstan",
            "Kenya",
            "Kiribati",
            "Kosovo",
            "Kuwait",
            "Kyrgyzstan",
            "Laos",
            "Latvia",
            "Lebanon",
            "Lesotho",
            "Liberia",
            "Libya",
            "Liechtenstein",
            "Lithuania",
            "Luxembourg",
            "Macedonia",
            "Madagascar",
            "Malawi",
            "Malaysia",
            "Maldives",
            "Mali",
            "Malta",
            "Marshall Islands",
            "Mauritania",
            "Mauritius",
            "Mexico",
            "Micronesia",
            "Moldova",
            "Monaco",
            "Mongolia",
            "Montenegro",
            "Morocco",
            "Mozambique",
            "Myanmar (Burma)",
            "Namibia",
            "Nauru",
            "Nepal",
            "Netherlands",
            "New Zealand",
            "Nicaragua",
            "Niger",
            "Nigeria",
            "North Korea",
            "Norway",
            "Oman",
            "Pakistan",
            "Palau",
            "Palestine",
            "Panama",
            "Papua New Guinea",
            "Paraguay",
            "Peru",
            "Philippines",
            "Poland",
            "Portugal",
            "Qatar",
            "Romania",
            "Russia",
            "Rwanda",
            "Saint Kitts and Nevis",
            "Saint Lucia",
            "Saint Vincent and the Grenadines",
            "Samoa",
            "San Marino",
            "Sao Tome and Principe",
            "Saudi Arabia",
            "Senegal",
            "Serbia",
            "Seychelles",
            "Sierra Leone",
            "Singapore",
            "Slovakia",
            "Slovenia",
            "Solomon Islands",
            "Somalia",
            "Switzerland",
            "Syria",
            "South Africa",
            "South Korea",
            "South Sudan",
            "Spain",
            "Sri Lanka",
            "Sudan",
            "Suriname",
            "Swaziland",
            "Sweden",
            "Taiwan",
            "Tajikistan",
            "Tanzania",
            "Thailand",
            "Timor-Leste",
            "Togo",
            "Tonga",
            "Trinidad and Tobago",
            "Tunisia",
            "Turkey",
            "Turkmenistan",
            "Tuvalu",
            "Uganda",
            "Ukraine",
            "United Arab Emirates (UAE)",
            "United Kingdom (UK)",
            "United States of America (USA)",
            "Uruguay",
            "Uzbekistan",
            "Vanuatu",
            "Vatican City (Holy See)",
            "Venezuela",
            "Vietnam",
            "Yemen",
            "Zambia",
            "Zimbabwe"});
            this.cmbCountryOfOrigin.Location = new System.Drawing.Point(276, 200);
            this.cmbCountryOfOrigin.Name = "cmbCountryOfOrigin";
            this.cmbCountryOfOrigin.Size = new System.Drawing.Size(236, 30);
            this.cmbCountryOfOrigin.TabIndex = 4;
            // 
            // txtUPictureBox
            // 
            this.txtUPictureBox.BackgroundImage = global::ProductManagementSystem.Properties.Resources._121;
            this.txtUPictureBox.Location = new System.Drawing.Point(548, 75);
            this.txtUPictureBox.Name = "txtUPictureBox";
            this.txtUPictureBox.Size = new System.Drawing.Size(300, 292);
            this.txtUPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.txtUPictureBox.TabIndex = 21;
            this.txtUPictureBox.TabStop = false;
            // 
            // txtUKBrandName
            // 
            this.txtUKBrandName.Location = new System.Drawing.Point(63, 518);
            this.txtUKBrandName.Name = "txtUKBrandName";
            this.txtUKBrandName.Size = new System.Drawing.Size(81, 20);
            this.txtUKBrandName.TabIndex = 25;
            this.txtUKBrandName.Visible = false;
            this.txtUKBrandName.TextChanged += new System.EventHandler(this.txtUKBrandName_TextChanged);
            // 
            // frmProductUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1049, 549);
            this.ControlBox = false;
            this.Controls.Add(this.txtUKBrandName);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.labelk);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.updateButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmProductUpdate";
            this.Text = "frmProductUpdate";
            this.Load += new System.EventHandler(this.frmProductUpdate_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtUPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button browseButton;
        public System.Windows.Forms.PictureBox txtUPictureBox;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button updateButton;
        public System.Windows.Forms.TextBox txtUProductId;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox txtUPrice;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox txtUItemCode;
        public System.Windows.Forms.TextBox txtUItemDescription;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtUProductName;
        public System.Windows.Forms.Label labelk;
        private System.Windows.Forms.GroupBox groupBox1;
        public  System.Windows.Forms.ComboBox cmbCountryOfOrigin;
        public  System.Windows.Forms.ComboBox cmbBrand;
        public System.Windows.Forms.TextBox txtUKBrandName;
        public System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
    }
}