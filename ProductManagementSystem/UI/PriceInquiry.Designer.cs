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
            this.label7 = new System.Windows.Forms.Label();
            this.COOComboBox = new System.Windows.Forms.ComboBox();
            this.InqFromButton = new System.Windows.Forms.Button();
            this.QtyTextBox = new System.Windows.Forms.TextBox();
            this.RemarksTextBox = new System.Windows.Forms.TextBox();
            this.InqFromTextBox = new System.Windows.Forms.TextBox();
            this.ProCodeTextBox = new System.Windows.Forms.TextBox();
            this.ProDesTextBox = new System.Windows.Forms.TextBox();
            this.ModelTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.COOComboBox);
            this.groupBox1.Controls.Add(this.InqFromButton);
            this.groupBox1.Controls.Add(this.QtyTextBox);
            this.groupBox1.Controls.Add(this.RemarksTextBox);
            this.groupBox1.Controls.Add(this.InqFromTextBox);
            this.groupBox1.Controls.Add(this.ProCodeTextBox);
            this.groupBox1.Controls.Add(this.ProDesTextBox);
            this.groupBox1.Controls.Add(this.ModelTextBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.SaveButton);
            this.groupBox1.Location = new System.Drawing.Point(25, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(551, 397);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(172, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Country of Origin       :";
            // 
            // COOComboBox
            // 
            this.COOComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.COOComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COOComboBox.FormattingEnabled = true;
            this.COOComboBox.Location = new System.Drawing.Point(193, 157);
            this.COOComboBox.Name = "COOComboBox";
            this.COOComboBox.Size = new System.Drawing.Size(249, 25);
            this.COOComboBox.TabIndex = 10;
            this.COOComboBox.SelectedIndexChanged += new System.EventHandler(this.COOComboBox_SelectedIndexChanged);
            // 
            // InqFromButton
            // 
            this.InqFromButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InqFromButton.Location = new System.Drawing.Point(458, 192);
            this.InqFromButton.Name = "InqFromButton";
            this.InqFromButton.Size = new System.Drawing.Size(50, 23);
            this.InqFromButton.TabIndex = 9;
            this.InqFromButton.Text = ">>";
            this.InqFromButton.UseVisualStyleBackColor = true;
            // 
            // QtyTextBox
            // 
            this.QtyTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QtyTextBox.Location = new System.Drawing.Point(193, 271);
            this.QtyTextBox.Name = "QtyTextBox";
            this.QtyTextBox.Size = new System.Drawing.Size(249, 23);
            this.QtyTextBox.TabIndex = 6;
            this.QtyTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.QtyTextBox_KeyDown);
            this.QtyTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.QtyTextBox_KeyPress);
            // 
            // RemarksTextBox
            // 
            this.RemarksTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemarksTextBox.Location = new System.Drawing.Point(193, 224);
            this.RemarksTextBox.MaxLength = 255;
            this.RemarksTextBox.Multiline = true;
            this.RemarksTextBox.Name = "RemarksTextBox";
            this.RemarksTextBox.Size = new System.Drawing.Size(249, 37);
            this.RemarksTextBox.TabIndex = 2;
            this.RemarksTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RemarksTextBox_KeyDown);
            // 
            // InqFromTextBox
            // 
            this.InqFromTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InqFromTextBox.Location = new System.Drawing.Point(193, 192);
            this.InqFromTextBox.MaxLength = 255;
            this.InqFromTextBox.Name = "InqFromTextBox";
            this.InqFromTextBox.Size = new System.Drawing.Size(249, 23);
            this.InqFromTextBox.TabIndex = 4;
            this.InqFromTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InqFromTextBox_KeyDown);
            // 
            // ProCodeTextBox
            // 
            this.ProCodeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProCodeTextBox.Location = new System.Drawing.Point(193, 121);
            this.ProCodeTextBox.MaxLength = 255;
            this.ProCodeTextBox.Name = "ProCodeTextBox";
            this.ProCodeTextBox.Size = new System.Drawing.Size(249, 23);
            this.ProCodeTextBox.TabIndex = 3;
            this.ProCodeTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ProCodeTextBox_KeyDown);
            // 
            // ProDesTextBox
            // 
            this.ProDesTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProDesTextBox.Location = new System.Drawing.Point(193, 62);
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
            this.ModelTextBox.Location = new System.Drawing.Point(193, 23);
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
            this.label6.Location = new System.Drawing.Point(21, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(175, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "QTY                          :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 233);
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
            this.label4.Location = new System.Drawing.Point(21, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Inquiry From              :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Product Code             :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Product Description    :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Model Number            :";
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Location = new System.Drawing.Point(263, 328);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(100, 54);
            this.SaveButton.TabIndex = 8;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.IndianRed;
            this.label8.Location = new System.Drawing.Point(169, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(277, 29);
            this.label8.TabIndex = 0;
            this.label8.Text = "Price Inquiry Creation";
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.PeachPuff;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.ForeColor = System.Drawing.Color.DarkMagenta;
            this.CloseButton.Location = new System.Drawing.Point(512, 19);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(64, 29);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // PriceInquiry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(598, 477);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Name = "PriceInquiry";
            this.Text = "Price Inquiry";
            this.Load += new System.EventHandler(this.PriceInquiry_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox QtyTextBox;
        private System.Windows.Forms.TextBox RemarksTextBox;
        private System.Windows.Forms.TextBox InqFromTextBox;
        private System.Windows.Forms.TextBox ProCodeTextBox;
        private System.Windows.Forms.TextBox ProDesTextBox;
        private System.Windows.Forms.TextBox ModelTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox COOComboBox;
        private System.Windows.Forms.Button InqFromButton;
    }
}