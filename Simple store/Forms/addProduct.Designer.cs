namespace ARK.Forms
{
    partial class addProduct
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.cmbx_status = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btt_add = new System.Windows.Forms.Button();
            this.txbx_price = new System.Windows.Forms.TextBox();
            this.cmbx_units = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txbx_quantity = new System.Windows.Forms.TextBox();
            this.cmbx_producer = new System.Windows.Forms.ComboBox();
            this.cmbx_category = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbx_comment = new System.Windows.Forms.TextBox();
            this.txbx_artikul = new System.Windows.Forms.TextBox();
            this.txbx_name = new System.Windows.Forms.TextBox();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtp);
            this.groupBox3.Controls.Add(this.cmbx_status);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.btt_add);
            this.groupBox3.Controls.Add(this.txbx_price);
            this.groupBox3.Controls.Add(this.cmbx_units);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txbx_quantity);
            this.groupBox3.Controls.Add(this.cmbx_producer);
            this.groupBox3.Controls.Add(this.cmbx_category);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txbx_comment);
            this.groupBox3.Controls.Add(this.txbx_artikul);
            this.groupBox3.Controls.Add(this.txbx_name);
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(1);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox3.Size = new System.Drawing.Size(460, 179);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Кнопки";
            // 
            // dtp
            // 
            this.dtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp.Location = new System.Drawing.Point(78, 124);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(144, 20);
            this.dtp.TabIndex = 21;
            // 
            // cmbx_status
            // 
            this.cmbx_status.DisplayMember = "sname";
            this.cmbx_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbx_status.FormattingEnabled = true;
            this.cmbx_status.Location = new System.Drawing.Point(314, 98);
            this.cmbx_status.Name = "cmbx_status";
            this.cmbx_status.Size = new System.Drawing.Size(133, 21);
            this.cmbx_status.TabIndex = 20;
            this.cmbx_status.ValueMember = "id";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(228, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Статус";
            // 
            // btt_add
            // 
            this.btt_add.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btt_add.Location = new System.Drawing.Point(6, 150);
            this.btt_add.Name = "btt_add";
            this.btt_add.Size = new System.Drawing.Size(216, 22);
            this.btt_add.TabIndex = 2;
            this.btt_add.Text = "Добавить";
            this.btt_add.UseVisualStyleBackColor = true;
            this.btt_add.Click += new System.EventHandler(this.btt_add_Click);
            // 
            // txbx_price
            // 
            this.txbx_price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbx_price.Location = new System.Drawing.Point(314, 19);
            this.txbx_price.Name = "txbx_price";
            this.txbx_price.Size = new System.Drawing.Size(133, 20);
            this.txbx_price.TabIndex = 13;
            // 
            // cmbx_units
            // 
            this.cmbx_units.DisplayMember = "uname";
            this.cmbx_units.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbx_units.FormattingEnabled = true;
            this.cmbx_units.Location = new System.Drawing.Point(314, 71);
            this.cmbx_units.Name = "cmbx_units";
            this.cmbx_units.Size = new System.Drawing.Size(133, 21);
            this.cmbx_units.TabIndex = 18;
            this.cmbx_units.ValueMember = "id";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(228, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Цена";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(228, 74);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "Ед. измерения";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(228, 45);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Количество";
            // 
            // txbx_quantity
            // 
            this.txbx_quantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbx_quantity.Location = new System.Drawing.Point(314, 43);
            this.txbx_quantity.Name = "txbx_quantity";
            this.txbx_quantity.Size = new System.Drawing.Size(133, 20);
            this.txbx_quantity.TabIndex = 15;
            // 
            // cmbx_producer
            // 
            this.cmbx_producer.DisplayMember = "Название";
            this.cmbx_producer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbx_producer.FormattingEnabled = true;
            this.cmbx_producer.Location = new System.Drawing.Point(78, 97);
            this.cmbx_producer.Name = "cmbx_producer";
            this.cmbx_producer.Size = new System.Drawing.Size(144, 21);
            this.cmbx_producer.TabIndex = 12;
            this.cmbx_producer.ValueMember = "id";
            // 
            // cmbx_category
            // 
            this.cmbx_category.DisplayMember = "cname";
            this.cmbx_category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbx_category.FormattingEnabled = true;
            this.cmbx_category.Location = new System.Drawing.Point(78, 70);
            this.cmbx_category.Name = "cmbx_category";
            this.cmbx_category.Size = new System.Drawing.Size(144, 21);
            this.cmbx_category.TabIndex = 11;
            this.cmbx_category.ValueMember = "id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Поставщик";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Дата";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Категория";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(228, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Описание";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Название";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Артикул";
            // 
            // txbx_comment
            // 
            this.txbx_comment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbx_comment.Location = new System.Drawing.Point(314, 124);
            this.txbx_comment.Multiline = true;
            this.txbx_comment.Name = "txbx_comment";
            this.txbx_comment.Size = new System.Drawing.Size(133, 44);
            this.txbx_comment.TabIndex = 5;
            // 
            // txbx_artikul
            // 
            this.txbx_artikul.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbx_artikul.Location = new System.Drawing.Point(78, 19);
            this.txbx_artikul.Name = "txbx_artikul";
            this.txbx_artikul.Size = new System.Drawing.Size(144, 20);
            this.txbx_artikul.TabIndex = 3;
            // 
            // txbx_name
            // 
            this.txbx_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbx_name.Location = new System.Drawing.Point(78, 45);
            this.txbx_name.Name = "txbx_name";
            this.txbx_name.Size = new System.Drawing.Size(144, 20);
            this.txbx_name.TabIndex = 2;
            // 
            // addProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 187);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "addProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.ComboBox cmbx_status;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btt_add;
        private System.Windows.Forms.TextBox txbx_price;
        private System.Windows.Forms.ComboBox cmbx_units;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txbx_quantity;
        private System.Windows.Forms.ComboBox cmbx_producer;
        private System.Windows.Forms.ComboBox cmbx_category;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbx_comment;
        private System.Windows.Forms.TextBox txbx_artikul;
        private System.Windows.Forms.TextBox txbx_name;
    }
}