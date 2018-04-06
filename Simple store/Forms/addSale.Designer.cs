namespace ARK.Forms
{
    partial class addSale
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
            this.cmbx_buyer = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btt_add = new System.Windows.Forms.Button();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbx_units = new System.Windows.Forms.ComboBox();
            this.txbx_quantity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbx_price = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cmbx_productName);
            this.groupBox4.Controls.Add(this.cmbx_buyer);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.btt_add);
            this.groupBox4.Controls.Add(this.dtp);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.cmbx_units);
            this.groupBox4.Controls.Add(this.txbx_quantity);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.txbx_price);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(313, 125);
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
            this.cmbx_productName.TabIndex = 25;
            this.cmbx_productName.ValueMember = "Артикул";
            // 
            // cmbx_buyer
            // 
            this.cmbx_buyer.DisplayMember = "ФИО";
            this.cmbx_buyer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbx_buyer.FormattingEnabled = true;
            this.cmbx_buyer.Location = new System.Drawing.Point(195, 73);
            this.cmbx_buyer.Name = "cmbx_buyer";
            this.cmbx_buyer.Size = new System.Drawing.Size(113, 21);
            this.cmbx_buyer.TabIndex = 23;
            this.cmbx_buyer.ValueMember = "ID";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(211, 53);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 13);
            this.label15.TabIndex = 22;
            this.label15.Text = "Покупатель";
            // 
            // btt_add
            // 
            this.btt_add.Location = new System.Drawing.Point(195, 99);
            this.btt_add.Name = "btt_add";
            this.btt_add.Size = new System.Drawing.Size(113, 23);
            this.btt_add.TabIndex = 21;
            this.btt_add.Text = "Добавить";
            this.btt_add.UseVisualStyleBackColor = true;
            this.btt_add.Click += new System.EventHandler(this.btt_add_Click);
            // 
            // dtp
            // 
            this.dtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp.Location = new System.Drawing.Point(195, 30);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(113, 20);
            this.dtp.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(231, 14);
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
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Измерения";
            // 
            // cmbx_units
            // 
            this.cmbx_units.DisplayMember = "uname";
            this.cmbx_units.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbx_units.FormattingEnabled = true;
            this.cmbx_units.Location = new System.Drawing.Point(89, 99);
            this.cmbx_units.Name = "cmbx_units";
            this.cmbx_units.Size = new System.Drawing.Size(100, 21);
            this.cmbx_units.TabIndex = 17;
            this.cmbx_units.ValueMember = "ID";
            // 
            // txbx_quantity
            // 
            this.txbx_quantity.Location = new System.Drawing.Point(89, 73);
            this.txbx_quantity.Name = "txbx_quantity";
            this.txbx_quantity.Size = new System.Drawing.Size(100, 20);
            this.txbx_quantity.TabIndex = 16;
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
            // txbx_price
            // 
            this.txbx_price.Location = new System.Drawing.Point(89, 47);
            this.txbx_price.Name = "txbx_price";
            this.txbx_price.Size = new System.Drawing.Size(100, 20);
            this.txbx_price.TabIndex = 14;
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
            // addSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 125);
            this.Controls.Add(this.groupBox4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "addSale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Склад";
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cmbx_buyer;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbx_quantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbx_price;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btt_add;
        private System.Windows.Forms.ComboBox cmbx_units;
        private System.Windows.Forms.ComboBox cmbx_productName;
    }
}