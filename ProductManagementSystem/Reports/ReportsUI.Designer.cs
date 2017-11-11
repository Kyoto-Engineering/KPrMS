namespace ProductManagementSystem.Reports
{
    partial class ReportsUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportsUI));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ProductListWithStockStatusbutton = new System.Windows.Forms.Button();
            this.InFeedbackButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.PriceInqListButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ProductListWithStockStatusbutton);
            this.groupBox1.Controls.Add(this.InFeedbackButton);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.PriceInqListButton);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(24, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(519, 313);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // ProductListWithStockStatusbutton
            // 
            this.ProductListWithStockStatusbutton.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ProductListWithStockStatusbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductListWithStockStatusbutton.ForeColor = System.Drawing.Color.Blue;
            this.ProductListWithStockStatusbutton.Location = new System.Drawing.Point(152, 95);
            this.ProductListWithStockStatusbutton.Name = "ProductListWithStockStatusbutton";
            this.ProductListWithStockStatusbutton.Size = new System.Drawing.Size(152, 52);
            this.ProductListWithStockStatusbutton.TabIndex = 4;
            this.ProductListWithStockStatusbutton.Text = "Product With Stock Status";
            this.ProductListWithStockStatusbutton.UseVisualStyleBackColor = false;
            this.ProductListWithStockStatusbutton.Click += new System.EventHandler(this.ProductListWithStockStatusbutton_Click);
            // 
            // InFeedbackButton
            // 
            this.InFeedbackButton.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.InFeedbackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InFeedbackButton.ForeColor = System.Drawing.Color.Blue;
            this.InFeedbackButton.Location = new System.Drawing.Point(18, 95);
            this.InFeedbackButton.Name = "InFeedbackButton";
            this.InFeedbackButton.Size = new System.Drawing.Size(119, 56);
            this.InFeedbackButton.TabIndex = 3;
            this.InFeedbackButton.Text = "Inquiry Feedback";
            this.InFeedbackButton.UseVisualStyleBackColor = false;
            this.InFeedbackButton.Click += new System.EventHandler(this.InFeedbackButton_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Blue;
            this.button2.Location = new System.Drawing.Point(322, 27);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 52);
            this.button2.TabIndex = 2;
            this.button2.Text = "Product List Without Price";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // PriceInqListButton
            // 
            this.PriceInqListButton.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.PriceInqListButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceInqListButton.ForeColor = System.Drawing.Color.Blue;
            this.PriceInqListButton.Location = new System.Drawing.Point(152, 27);
            this.PriceInqListButton.Name = "PriceInqListButton";
            this.PriceInqListButton.Size = new System.Drawing.Size(155, 52);
            this.PriceInqListButton.TabIndex = 1;
            this.PriceInqListButton.Text = "Price Inquiry List";
            this.PriceInqListButton.UseVisualStyleBackColor = false;
            this.PriceInqListButton.Click += new System.EventHandler(this.PriceInqListButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Blue;
            this.button1.Location = new System.Drawing.Point(18, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 52);
            this.button1.TabIndex = 0;
            this.button1.Text = "Product List";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ReportsUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(565, 375);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReportsUI";
            this.Text = "ReportsUI";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ReportsUI_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button PriceInqListButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button InFeedbackButton;
        private System.Windows.Forms.Button ProductListWithStockStatusbutton;
    }
}