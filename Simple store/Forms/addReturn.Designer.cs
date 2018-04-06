namespace ARK.Forms
{
    partial class addReturn
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cmbx_productName = new System.Windows.Forms.ComboBox();
            this.btt_addSale = new System.Windows.Forms.Button();
            this.dtp_Sale = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbx_unitsSale = new System.Windows.Forms.ComboBox();
            this.txbx_quantitySale = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbx_priceSale = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cmbx_productName);
            this.groupBox4.Controls.Add(this.btt_addSale);
            this.groupBox4.Controls.Add(this.dtp_Sale);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.cmbx_unitsSale);
            this.groupBox4.Controls.Add(this.txbx_quantitySale);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.txbx_priceSale);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(320, 130);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Добавить";
            // 
            // cmbx_productName
            // 
            this.cmbx_productName.DisplayMember = "Название";
            this.cmbx_productName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbx_productName.FormattingEnabled = true;
            this.cmbx_productName.Location = new System.Drawing.Point(89, 21);
            this.cmbx_productName.Name = "cmbx_productName";
            this.cmbx_productName.Size = new System.Drawing.Size(100, 21);
            this.cmbx_productName.TabIndex = 24;
            this.cmbx_productName.ValueMember = "Артикул";
            // 
            // btt_addSale
            // 
            this.btt_addSale.Location = new System.Drawing.Point(195, 64);
            this.btt_addSale.Name = "btt_addSale";
            this.btt_addSale.Size = new System.Drawing.Size(113, 47);
            this.btt_addSale.TabIndex = 21;
            this.btt_addSale.Text = "Добавить";
            this.btt_addSale.UseVisualStyleBackColor = true;
            this.btt_addSale.Click += new System.EventHandler(this.btt_renameSale_Click);
            // 
            // dtp_Sale
            // 
            this.dtp_Sale.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Sale.Location = new System.Drawing.Point(194, 36);
            this.dtp_Sale.Name = "dtp_Sale";
            this.dtp_Sale.Size = new System.Drawing.Size(113, 20);
            this.dtp_Sale.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(230, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Дата";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "ЕдИзмерения";
            // 
            // cmbx_unitsSale
            // 
            this.cmbx_unitsSale.DisplayMember = "uname";
            this.cmbx_unitsSale.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbx_unitsSale.FormattingEnabled = true;
            this.cmbx_unitsSale.Location = new System.Drawing.Point(89, 99);
            this.cmbx_unitsSale.Name = "cmbx_unitsSale";
            this.cmbx_unitsSale.Size = new System.Drawing.Size(100, 21);
            this.cmbx_unitsSale.TabIndex = 17;
            this.cmbx_unitsSale.ValueMember = "id";
            // 
            // txbx_quantitySale
            // 
            this.txbx_quantitySale.Location = new System.Drawing.Point(89, 73);
            this.txbx_quantitySale.Name = "txbx_quantitySale";
            this.txbx_quantitySale.Size = new System.Drawing.Size(100, 20);
            this.txbx_quantitySale.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Количество";
            // 
            // txbx_priceSale
            // 
            this.txbx_priceSale.Location = new System.Drawing.Point(89, 47);
            this.txbx_priceSale.Name = "txbx_priceSale";
            this.txbx_priceSale.Size = new System.Drawing.Size(100, 20);
            this.txbx_priceSale.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Цена";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Название";
            // 
            // addReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 130);
            this.Controls.Add(this.groupBox4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "addReturn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Склад";
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cmbx_productName;
        private System.Windows.Forms.Button btt_addSale;
        private System.Windows.Forms.DateTimePicker dtp_Sale;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbx_unitsSale;
        private System.Windows.Forms.TextBox txbx_quantitySale;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbx_priceSale;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}