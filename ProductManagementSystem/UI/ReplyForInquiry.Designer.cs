namespace ProductManagementSystem.UI
{
    partial class ReplyForInquiry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReplyForInquiry));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.CogsVsMopTextBox = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.productCodeTextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.productNameTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.eXWTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.StockStatusComboBox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.CountryComboBox = new System.Windows.Forms.ComboBox();
            this.MopBdtTextBox = new System.Windows.Forms.TextBox();
            this.UnitCogsBdtTextBox = new System.Windows.Forms.TextBox();
            this.UnitCogsUsdTextBox = new System.Windows.Forms.TextBox();
            this.QtyTextBox = new System.Windows.Forms.TextBox();
            this.ProDesTextBox = new System.Windows.Forms.TextBox();
            this.ModelNumberTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DoneButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.ExchangeRateTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(546, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(380, 235);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Price Inquiry Info";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(18, 17);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(343, 202);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "PInquiryId";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Model";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Product Description";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Quantity";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.CogsVsMopTextBox);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.productCodeTextBox);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.productNameTextBox);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.eXWTextBox);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.comboBox3);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.StockStatusComboBox);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.CountryComboBox);
            this.groupBox2.Controls.Add(this.MopBdtTextBox);
            this.groupBox2.Controls.Add(this.UnitCogsBdtTextBox);
            this.groupBox2.Controls.Add(this.UnitCogsUsdTextBox);
            this.groupBox2.Controls.Add(this.QtyTextBox);
            this.groupBox2.Controls.Add(this.ProDesTextBox);
            this.groupBox2.Controls.Add(this.ModelNumberTextBox);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(18, 106);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(400, 454);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Feedback Inquiry";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(206, 313);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(20, 17);
            this.label17.TabIndex = 34;
            this.label17.Text = "%";
            // 
            // CogsVsMopTextBox
            // 
            this.CogsVsMopTextBox.Location = new System.Drawing.Point(141, 312);
            this.CogsVsMopTextBox.Name = "CogsVsMopTextBox";
            this.CogsVsMopTextBox.Size = new System.Drawing.Size(59, 20);
            this.CogsVsMopTextBox.TabIndex = 11;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(16, 315);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(127, 13);
            this.label16.TabIndex = 32;
            this.label16.Text = "COGS Vs MOP               :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(15, 406);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(123, 13);
            this.label14.TabIndex = 31;
            this.label14.Text = "Product Code                :";
            this.label14.Visible = false;
            // 
            // productCodeTextBox
            // 
            this.productCodeTextBox.Location = new System.Drawing.Point(141, 403);
            this.productCodeTextBox.Name = "productCodeTextBox";
            this.productCodeTextBox.Size = new System.Drawing.Size(219, 20);
            this.productCodeTextBox.TabIndex = 14;
            this.productCodeTextBox.Visible = false;
            this.productCodeTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.productCodeTextBox_KeyDown);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(15, 376);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(126, 13);
            this.label13.TabIndex = 29;
            this.label13.Text = "Product Name                :";
            this.label13.Visible = false;
            // 
            // productNameTextBox
            // 
            this.productNameTextBox.Location = new System.Drawing.Point(141, 373);
            this.productNameTextBox.Name = "productNameTextBox";
            this.productNameTextBox.Size = new System.Drawing.Size(219, 20);
            this.productNameTextBox.TabIndex = 13;
            this.productNameTextBox.Visible = false;
            this.productNameTextBox.TextChanged += new System.EventHandler(this.productNameTextBox_TextChanged);
            this.productNameTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.productNameTextBox_KeyDown);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 167);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(125, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "Availble                          :";
            this.label12.Visible = false;
            // 
            // eXWTextBox
            // 
            this.eXWTextBox.Location = new System.Drawing.Point(143, 222);
            this.eXWTextBox.Name = "eXWTextBox";
            this.eXWTextBox.Size = new System.Drawing.Size(217, 20);
            this.eXWTextBox.TabIndex = 8;
            this.eXWTextBox.Visible = false;
            this.eXWTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.eXWTextBox_KeyDown);
            this.eXWTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.eXWTextBox_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 225);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(130, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "EXW Price In USD          :";
            this.label11.Visible = false;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Pcs",
            "Set",
            "Pair",
            "Box",
            "Doz",
            "Grs"});
            this.comboBox3.Location = new System.Drawing.Point(301, 164);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(59, 21);
            this.comboBox3.TabIndex = 6;
            this.comboBox3.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(143, 164);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(149, 20);
            this.textBox2.TabIndex = 5;
            this.textBox2.Visible = false;
            this.textBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyDown);
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // StockStatusComboBox
            // 
            this.StockStatusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StockStatusComboBox.FormattingEnabled = true;
            this.StockStatusComboBox.Items.AddRange(new object[] {
            "Indent",
            "Stock",
            "Out of Production",
            "Invalid Model"});
            this.StockStatusComboBox.Location = new System.Drawing.Point(143, 133);
            this.StockStatusComboBox.Name = "StockStatusComboBox";
            this.StockStatusComboBox.Size = new System.Drawing.Size(217, 21);
            this.StockStatusComboBox.TabIndex = 4;
            this.StockStatusComboBox.SelectedIndexChanged += new System.EventHandler(this.StockStatusComboBox_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 136);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(128, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Stock Status                   :";
            // 
            // CountryComboBox
            // 
            this.CountryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CountryComboBox.FormattingEnabled = true;
            this.CountryComboBox.Location = new System.Drawing.Point(143, 193);
            this.CountryComboBox.Name = "CountryComboBox";
            this.CountryComboBox.Size = new System.Drawing.Size(217, 21);
            this.CountryComboBox.TabIndex = 7;
            this.CountryComboBox.Visible = false;
            // 
            // MopBdtTextBox
            // 
            this.MopBdtTextBox.Location = new System.Drawing.Point(141, 342);
            this.MopBdtTextBox.Name = "MopBdtTextBox";
            this.MopBdtTextBox.Size = new System.Drawing.Size(217, 20);
            this.MopBdtTextBox.TabIndex = 12;
            this.MopBdtTextBox.Visible = false;
            this.MopBdtTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MopBdtTextBox_KeyDown);
            this.MopBdtTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MopBdtTextBox_KeyPress);
            // 
            // UnitCogsBdtTextBox
            // 
            this.UnitCogsBdtTextBox.Location = new System.Drawing.Point(141, 281);
            this.UnitCogsBdtTextBox.Name = "UnitCogsBdtTextBox";
            this.UnitCogsBdtTextBox.ReadOnly = true;
            this.UnitCogsBdtTextBox.Size = new System.Drawing.Size(219, 20);
            this.UnitCogsBdtTextBox.TabIndex = 10;
            this.UnitCogsBdtTextBox.Visible = false;
            // 
            // UnitCogsUsdTextBox
            // 
            this.UnitCogsUsdTextBox.Location = new System.Drawing.Point(143, 252);
            this.UnitCogsUsdTextBox.Name = "UnitCogsUsdTextBox";
            this.UnitCogsUsdTextBox.Size = new System.Drawing.Size(217, 20);
            this.UnitCogsUsdTextBox.TabIndex = 9;
            this.UnitCogsUsdTextBox.Visible = false;
            this.UnitCogsUsdTextBox.TextChanged += new System.EventHandler(this.UnitCogsUsdTextBox_TextChanged);
            this.UnitCogsUsdTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UnitCogsUsdTextBox_KeyDown);
            this.UnitCogsUsdTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UnitCogsUsdTextBox_KeyPress);
            // 
            // QtyTextBox
            // 
            this.QtyTextBox.Location = new System.Drawing.Point(143, 107);
            this.QtyTextBox.Name = "QtyTextBox";
            this.QtyTextBox.ReadOnly = true;
            this.QtyTextBox.Size = new System.Drawing.Size(217, 20);
            this.QtyTextBox.TabIndex = 3;
            // 
            // ProDesTextBox
            // 
            this.ProDesTextBox.Location = new System.Drawing.Point(143, 71);
            this.ProDesTextBox.Name = "ProDesTextBox";
            this.ProDesTextBox.ReadOnly = true;
            this.ProDesTextBox.Size = new System.Drawing.Size(217, 20);
            this.ProDesTextBox.TabIndex = 2;
            // 
            // ModelNumberTextBox
            // 
            this.ModelNumberTextBox.Location = new System.Drawing.Point(143, 33);
            this.ModelNumberTextBox.Name = "ModelNumberTextBox";
            this.ModelNumberTextBox.ReadOnly = true;
            this.ModelNumberTextBox.Size = new System.Drawing.Size(217, 20);
            this.ModelNumberTextBox.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 345);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "MOP In BDT                   :";
            this.label7.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Unit COGS In BDT          :";
            this.label6.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Unit COGS In USD          :";
            this.label5.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Country                           :";
            this.label4.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quantity                          :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Product Description        :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Model Number                :";
            // 
            // DoneButton
            // 
            this.DoneButton.Location = new System.Drawing.Point(932, 288);
            this.DoneButton.Name = "DoneButton";
            this.DoneButton.Size = new System.Drawing.Size(75, 23);
            this.DoneButton.TabIndex = 5;
            this.DoneButton.Text = "Done";
            this.DoneButton.UseVisualStyleBackColor = true;
            this.DoneButton.Click += new System.EventHandler(this.DoneButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(430, 180);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 4;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listView1);
            this.groupBox3.Location = new System.Drawing.Point(461, 317);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(889, 326);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Feedback Inquiry Info";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader14,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader10,
            this.columnHeader6,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader5,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(6, 27);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(875, 293);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "PInquiryId";
            this.columnHeader1.Width = 0;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "source";
            this.columnHeader14.Width = 0;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Model";
            this.columnHeader2.Width = 82;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Product Description";
            this.columnHeader3.Width = 108;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Qty";
            this.columnHeader4.Width = 50;
            // 
            // columnHeader10
            // 
            this.columnHeader10.DisplayIndex = 9;
            this.columnHeader10.Text = "Status";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "COGS(USD)U";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 80;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "COGS(BDT)U";
            this.columnHeader8.Width = 80;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "MOP(BDT)U";
            this.columnHeader9.Width = 76;
            // 
            // columnHeader5
            // 
            this.columnHeader5.DisplayIndex = 5;
            this.columnHeader5.Text = "Country";
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Product Name";
            this.columnHeader11.Width = 75;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Prdct Code";
            this.columnHeader12.Width = 100;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "EXW Prc(U)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(504, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(147, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Inquiry Feedback";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(161, 21);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(217, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(427, 92);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(78, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Extra Items";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // ExchangeRateTextBox
            // 
            this.ExchangeRateTextBox.Location = new System.Drawing.Point(161, 57);
            this.ExchangeRateTextBox.Name = "ExchangeRateTextBox";
            this.ExchangeRateTextBox.Size = new System.Drawing.Size(217, 20);
            this.ExchangeRateTextBox.TabIndex = 2;
            this.ExchangeRateTextBox.TextChanged += new System.EventHandler(this.ExchangeRateTextBox_TextChanged_1);
            this.ExchangeRateTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ExchangeRateTextBox_KeyDown);
            this.ExchangeRateTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ExchangeRateTextBox_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Exchange Rate                :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(27, 24);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(132, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "Select Inquiry Number      :";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // ReplyForInquiry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 652);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.ExchangeRateTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.DoneButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReplyForInquiry";
            this.Text = "FeedbackForInquiry        ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ReplyForInquiry_FormClosed);
            this.Load += new System.EventHandler(this.ReplyForInquiry_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox StockStatusComboBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button DoneButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.ComboBox CountryComboBox;
        private System.Windows.Forms.TextBox MopBdtTextBox;
        private System.Windows.Forms.TextBox UnitCogsBdtTextBox;
        private System.Windows.Forms.TextBox UnitCogsUsdTextBox;
        private System.Windows.Forms.TextBox QtyTextBox;
        private System.Windows.Forms.TextBox ProDesTextBox;
        private System.Windows.Forms.TextBox ModelNumberTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox eXWTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox productCodeTextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox productNameTextBox;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.TextBox ExchangeRateTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox CogsVsMopTextBox;
        private System.Windows.Forms.Label label16;
    }
}