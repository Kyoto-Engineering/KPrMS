namespace ProductManagementSystem.UI
{
    partial class PriceInquiry
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.QtyTextBox = new System.Windows.Forms.TextBox();
            this.RemarksTextBox = new System.Windows.Forms.TextBox();
            this.InqFromTextBox = new System.Windows.Forms.TextBox();
            this.ProDesTextBox = new System.Windows.Forms.TextBox();
            this.ModelTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.QtyTextBox);
            this.groupBox1.Controls.Add(this.RemarksTextBox);
            this.groupBox1.Controls.Add(this.InqFromTextBox);
            this.groupBox1.Controls.Add(this.ProDesTextBox);
            this.groupBox1.Controls.Add(this.ModelTextBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.SaveButton);
            this.groupBox1.Location = new System.Drawing.Point(40, 131);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(489, 285);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // QtyTextBox
            // 
            this.QtyTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QtyTextBox.Location = new System.Drawing.Point(193, 199);
            this.QtyTextBox.Name = "QtyTextBox";
            this.QtyTextBox.Size = new System.Drawing.Size(249, 23);
            this.QtyTextBox.TabIndex = 5;
            this.QtyTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.QtyTextBox_KeyDown);
            this.QtyTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.QtyTextBox_KeyPress);
            // 
            // RemarksTextBox
            // 
            this.RemarksTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemarksTextBox.Location = new System.Drawing.Point(193, 152);
            this.RemarksTextBox.MaxLength = 255;
            this.RemarksTextBox.Multiline = true;
            this.RemarksTextBox.Name = "RemarksTextBox";
            this.RemarksTextBox.Size = new System.Drawing.Size(249, 37);
            this.RemarksTextBox.TabIndex = 4;
            this.RemarksTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RemarksTextBox_KeyDown);
            // 
            // InqFromTextBox
            // 
            this.InqFromTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InqFromTextBox.Location = new System.Drawing.Point(193, 118);
            this.InqFromTextBox.MaxLength = 255;
            this.InqFromTextBox.Name = "InqFromTextBox";
            this.InqFromTextBox.Size = new System.Drawing.Size(249, 23);
            this.InqFromTextBox.TabIndex = 3;
            this.InqFromTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InqFromTextBox_KeyDown);
            // 
            // ProDesTextBox
            // 
            this.ProDesTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProDesTextBox.Location = new System.Drawing.Point(193, 58);
            this.ProDesTextBox.MaxLength = 255;
            this.ProDesTextBox.Multiline = true;
            this.ProDesTextBox.Name = "ProDesTextBox";
            this.ProDesTextBox.Size = new System.Drawing.Size(249, 47);
            this.ProDesTextBox.TabIndex = 2;
            this.ProDesTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ProDesTextBox_KeyDown);
            // 
            // ModelTextBox
            // 
            this.ModelTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelTextBox.Location = new System.Drawing.Point(193, 19);
            this.ModelTextBox.MaxLength = 255;
            this.ModelTextBox.Name = "ModelTextBox";
            this.ModelTextBox.Size = new System.Drawing.Size(249, 26);
            this.ModelTextBox.TabIndex = 1;
            this.ModelTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ModelTextBox_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(175, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "QTY                          :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Remarks                    :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Inquiry From              :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Product Description    :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Model Number            :";
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Location = new System.Drawing.Point(193, 228);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(100, 54);
            this.SaveButton.TabIndex = 6;
            this.SaveButton.Text = "Add";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.IndianRed;
            this.label8.Location = new System.Drawing.Point(409, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(277, 29);
            this.label8.TabIndex = 0;
            this.label8.Text = "Price Inquiry Creation";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listView1);
            this.groupBox2.Location = new System.Drawing.Point(535, 131);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(543, 182);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(6, 19);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(513, 150);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Model Number";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Product Description";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Inquiry Form";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Remarks";
            this.columnHeader4.Width = 80;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Qty";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(233, 67);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(237, 26);
            this.textBox1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(58, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Price Inquiry No";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(541, 355);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 54);
            this.button1.TabIndex = 7;
            this.button1.Text = "Done";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // PriceInquiry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(1090, 421);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Name = "PriceInquiry";
            this.Text = "Price Inquiry";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PriceInquiry_FormClosed);
            this.Load += new System.EventHandler(this.PriceInquiry_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox QtyTextBox;
        private System.Windows.Forms.TextBox RemarksTextBox;
        private System.Windows.Forms.TextBox InqFromTextBox;
        private System.Windows.Forms.TextBox ProDesTextBox;
        private System.Windows.Forms.TextBox ModelTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}