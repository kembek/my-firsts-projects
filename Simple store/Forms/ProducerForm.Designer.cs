namespace ARK.Forms
{
    partial class ProducerForm
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
            this.grb_Table = new System.Windows.Forms.GroupBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.печататьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbx_town = new System.Windows.Forms.ComboBox();
            this.cmbx_country = new System.Windows.Forms.ComboBox();
            this.btt_rename = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbx_number = new System.Windows.Forms.TextBox();
            this.txbx_address = new System.Windows.Forms.TextBox();
            this.txbx_email = new System.Windows.Forms.TextBox();
            this.txbx_name = new System.Windows.Forms.TextBox();
            this.txbx_surname = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btt_Next = new System.Windows.Forms.Button();
            this.btt_search = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txbx_searchSurname = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txbx_searchName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txbx_searchNumber = new System.Windows.Forms.TextBox();
            this.grb_Tools = new System.Windows.Forms.GroupBox();
            this.btt_add = new System.Windows.Forms.Button();
            this.btt_delete = new System.Windows.Forms.Button();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.grb_Table.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grb_Tools.SuspendLayout();
            this.SuspendLayout();
            // 
            // grb_Table
            // 
            this.grb_Table.Controls.Add(this.dgv);
            this.grb_Table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grb_Table.Location = new System.Drawing.Point(0, 181);
            this.grb_Table.Name = "grb_Table";
            this.grb_Table.Size = new System.Drawing.Size(772, 308);
            this.grb_Table.TabIndex = 0;
            this.grb_Table.TabStop = false;
            this.grb_Table.Text = "Список поставщиков";
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(3, 16);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(766, 289);
            this.dgv.TabIndex = 0;
            this.dgv.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellEnter);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 489);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(772, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.печататьToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(772, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // печататьToolStripMenuItem
            // 
            this.печататьToolStripMenuItem.Name = "печататьToolStripMenuItem";
            this.печататьToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.печататьToolStripMenuItem.Text = "Печатать";
            this.печататьToolStripMenuItem.Click += new System.EventHandler(this.печататьToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(146, 20);
            this.справкаToolStripMenuItem.Text = "Экспортировать в Excel";
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.справкаToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.grb_Tools);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(772, 157);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Панель инструментов";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbx_town);
            this.groupBox3.Controls.Add(this.cmbx_country);
            this.groupBox3.Controls.Add(this.btt_rename);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txbx_number);
            this.groupBox3.Controls.Add(this.txbx_address);
            this.groupBox3.Controls.Add(this.txbx_email);
            this.groupBox3.Controls.Add(this.txbx_name);
            this.groupBox3.Controls.Add(this.txbx_surname);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(133, 16);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(1);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox3.Size = new System.Drawing.Size(429, 138);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Кнопки";
            // 
            // cmbx_town
            // 
            this.cmbx_town.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbx_town.FormattingEnabled = true;
            this.cmbx_town.Location = new System.Drawing.Point(108, 97);
            this.cmbx_town.Name = "cmbx_town";
            this.cmbx_town.Size = new System.Drawing.Size(114, 21);
            this.cmbx_town.TabIndex = 12;
            // 
            // cmbx_country
            // 
            this.cmbx_country.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbx_country.FormattingEnabled = true;
            this.cmbx_country.Location = new System.Drawing.Point(108, 70);
            this.cmbx_country.Name = "cmbx_country";
            this.cmbx_country.Size = new System.Drawing.Size(114, 21);
            this.cmbx_country.TabIndex = 11;
            this.cmbx_country.SelectedIndexChanged += new System.EventHandler(this.cmbx_country_SelectedIndexChanged);
            // 
            // btt_rename
            // 
            this.btt_rename.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btt_rename.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btt_rename.Location = new System.Drawing.Point(302, 95);
            this.btt_rename.Name = "btt_rename";
            this.btt_rename.Size = new System.Drawing.Size(120, 22);
            this.btt_rename.TabIndex = 2;
            this.btt_rename.Text = "Редактировать";
            this.btt_rename.UseVisualStyleBackColor = true;
            this.btt_rename.Click += new System.EventHandler(this.btt_rename_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Город";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(225, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Элект. почта";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Страна";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(225, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Адрес";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Полное название";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(225, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Номер тел.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Название";
            // 
            // txbx_number
            // 
            this.txbx_number.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txbx_number.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbx_number.Location = new System.Drawing.Point(302, 19);
            this.txbx_number.Name = "txbx_number";
            this.txbx_number.Size = new System.Drawing.Size(120, 20);
            this.txbx_number.TabIndex = 6;
            // 
            // txbx_address
            // 
            this.txbx_address.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txbx_address.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbx_address.Location = new System.Drawing.Point(302, 45);
            this.txbx_address.Name = "txbx_address";
            this.txbx_address.Size = new System.Drawing.Size(120, 20);
            this.txbx_address.TabIndex = 5;
            // 
            // txbx_email
            // 
            this.txbx_email.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txbx_email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbx_email.Location = new System.Drawing.Point(302, 71);
            this.txbx_email.Name = "txbx_email";
            this.txbx_email.Size = new System.Drawing.Size(120, 20);
            this.txbx_email.TabIndex = 4;
            // 
            // txbx_name
            // 
            this.txbx_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbx_name.Location = new System.Drawing.Point(108, 19);
            this.txbx_name.Name = "txbx_name";
            this.txbx_name.Size = new System.Drawing.Size(114, 20);
            this.txbx_name.TabIndex = 3;
            // 
            // txbx_surname
            // 
            this.txbx_surname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbx_surname.Location = new System.Drawing.Point(108, 45);
            this.txbx_surname.Name = "txbx_surname";
            this.txbx_surname.Size = new System.Drawing.Size(114, 20);
            this.txbx_surname.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btt_Next);
            this.groupBox2.Controls.Add(this.btt_search);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txbx_searchSurname);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txbx_searchName);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txbx_searchNumber);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Location = new System.Drawing.Point(562, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(207, 138);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Поиск";
            // 
            // btt_Next
            // 
            this.btt_Next.Location = new System.Drawing.Point(107, 97);
            this.btt_Next.Name = "btt_Next";
            this.btt_Next.Size = new System.Drawing.Size(96, 30);
            this.btt_Next.TabIndex = 13;
            this.btt_Next.Text = "Следующий";
            this.btt_Next.UseVisualStyleBackColor = true;
            this.btt_Next.Click += new System.EventHandler(this.btt_Next_Click);
            // 
            // btt_search
            // 
            this.btt_search.Location = new System.Drawing.Point(6, 97);
            this.btt_search.Name = "btt_search";
            this.btt_search.Size = new System.Drawing.Size(95, 30);
            this.btt_search.TabIndex = 12;
            this.btt_search.Text = "Поиск";
            this.btt_search.UseVisualStyleBackColor = true;
            this.btt_search.Click += new System.EventHandler(this.btt_search_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(0, 46);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Пол. название";
            // 
            // txbx_searchSurname
            // 
            this.txbx_searchSurname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbx_searchSurname.Location = new System.Drawing.Point(87, 44);
            this.txbx_searchSurname.Name = "txbx_searchSurname";
            this.txbx_searchSurname.Size = new System.Drawing.Size(116, 20);
            this.txbx_searchSurname.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(0, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Название";
            // 
            // txbx_searchName
            // 
            this.txbx_searchName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbx_searchName.Location = new System.Drawing.Point(87, 18);
            this.txbx_searchName.Name = "txbx_searchName";
            this.txbx_searchName.Size = new System.Drawing.Size(116, 20);
            this.txbx_searchName.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(0, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Номер тел.";
            // 
            // txbx_searchNumber
            // 
            this.txbx_searchNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbx_searchNumber.Location = new System.Drawing.Point(87, 70);
            this.txbx_searchNumber.Name = "txbx_searchNumber";
            this.txbx_searchNumber.Size = new System.Drawing.Size(116, 20);
            this.txbx_searchNumber.TabIndex = 6;
            // 
            // grb_Tools
            // 
            this.grb_Tools.Controls.Add(this.btt_add);
            this.grb_Tools.Controls.Add(this.btt_delete);
            this.grb_Tools.Dock = System.Windows.Forms.DockStyle.Left;
            this.grb_Tools.Location = new System.Drawing.Point(3, 16);
            this.grb_Tools.Name = "grb_Tools";
            this.grb_Tools.Size = new System.Drawing.Size(130, 138);
            this.grb_Tools.TabIndex = 6;
            this.grb_Tools.TabStop = false;
            this.grb_Tools.Text = "Кнопки";
            // 
            // btt_add
            // 
            this.btt_add.Location = new System.Drawing.Point(7, 19);
            this.btt_add.Name = "btt_add";
            this.btt_add.Size = new System.Drawing.Size(117, 45);
            this.btt_add.TabIndex = 1;
            this.btt_add.Text = "Добавить";
            this.btt_add.UseVisualStyleBackColor = true;
            this.btt_add.Click += new System.EventHandler(this.btt_add_Click);
            // 
            // btt_delete
            // 
            this.btt_delete.Location = new System.Drawing.Point(7, 74);
            this.btt_delete.Name = "btt_delete";
            this.btt_delete.Size = new System.Drawing.Size(117, 45);
            this.btt_delete.TabIndex = 0;
            this.btt_delete.Text = "Удалить";
            this.btt_delete.UseVisualStyleBackColor = true;
            this.btt_delete.Click += new System.EventHandler(this.btt_delete_Click);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(132, 17);
            this.toolStripStatusLabel1.Text = "Форма - Поставщиков";
            // 
            // ProducerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 511);
            this.Controls.Add(this.grb_Table);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ProducerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Склад";
            this.grb_Table.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grb_Tools.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grb_Table;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem печататьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txbx_searchName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txbx_searchNumber;
        private System.Windows.Forms.GroupBox grb_Tools;
        private System.Windows.Forms.Button btt_add;
        private System.Windows.Forms.Button btt_delete;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmbx_town;
        private System.Windows.Forms.ComboBox cmbx_country;
        private System.Windows.Forms.Button btt_rename;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbx_number;
        private System.Windows.Forms.TextBox txbx_address;
        private System.Windows.Forms.TextBox txbx_email;
        private System.Windows.Forms.TextBox txbx_name;
        private System.Windows.Forms.TextBox txbx_surname;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txbx_searchSurname;
        private System.Windows.Forms.Button btt_Next;
        private System.Windows.Forms.Button btt_search;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}