namespace ARK.Forms
{
    partial class ProductForm
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmi_print = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_export = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btt_Next = new System.Windows.Forms.Button();
            this.btt_search = new System.Windows.Forms.Button();
            this.cmbx_searchStatus = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbx_searchProducer = new System.Windows.Forms.ComboBox();
            this.cmbx_searchCategory = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txbx_searchArtikul = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txbx_searchName = new System.Windows.Forms.TextBox();
            this.grb_Tools = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btt_delete = new System.Windows.Forms.Button();
            this.btt_add = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btt_rename = new System.Windows.Forms.Button();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.cmbx_status = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grb_Tools.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgv);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(0, 226);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(743, 293);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Список товаров";
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(3, 16);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(737, 274);
            this.dgv.TabIndex = 1;
            this.dgv.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellEnter);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 519);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(743, 22);
            this.statusStrip1.TabIndex = 15;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_print,
            this.tsmi_export});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(743, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmi_print
            // 
            this.tsmi_print.Name = "tsmi_print";
            this.tsmi_print.Size = new System.Drawing.Size(69, 20);
            this.tsmi_print.Text = "Печатать";
            this.tsmi_print.Click += new System.EventHandler(this.tsmi_print_Click);
            // 
            // tsmi_export
            // 
            this.tsmi_export.Name = "tsmi_export";
            this.tsmi_export.Size = new System.Drawing.Size(146, 20);
            this.tsmi_export.Text = "Экспортировать в Excel";
            this.tsmi_export.Click += new System.EventHandler(this.tsmi_export_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btt_Next);
            this.groupBox2.Controls.Add(this.btt_search);
            this.groupBox2.Controls.Add(this.cmbx_searchStatus);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.cmbx_searchProducer);
            this.groupBox2.Controls.Add(this.cmbx_searchCategory);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txbx_searchArtikul);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txbx_searchName);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Location = new System.Drawing.Point(549, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(191, 183);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Поиск";
            // 
            // btt_Next
            // 
            this.btt_Next.Location = new System.Drawing.Point(110, 150);
            this.btt_Next.Name = "btt_Next";
            this.btt_Next.Size = new System.Drawing.Size(76, 24);
            this.btt_Next.TabIndex = 24;
            this.btt_Next.Text = "Следующий";
            this.btt_Next.UseVisualStyleBackColor = true;
            // 
            // btt_search
            // 
            this.btt_search.Location = new System.Drawing.Point(9, 150);
            this.btt_search.Name = "btt_search";
            this.btt_search.Size = new System.Drawing.Size(95, 24);
            this.btt_search.TabIndex = 23;
            this.btt_search.Text = "Поиск";
            this.btt_search.UseVisualStyleBackColor = true;
            this.btt_search.Click += new System.EventHandler(this.btt_search_Click);
            // 
            // cmbx_searchStatus
            // 
            this.cmbx_searchStatus.DisplayMember = "sname";
            this.cmbx_searchStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbx_searchStatus.FormattingEnabled = true;
            this.cmbx_searchStatus.Location = new System.Drawing.Point(75, 123);
            this.cmbx_searchStatus.Name = "cmbx_searchStatus";
            this.cmbx_searchStatus.Size = new System.Drawing.Size(111, 21);
            this.cmbx_searchStatus.TabIndex = 22;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 123);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 13);
            this.label13.TabIndex = 21;
            this.label13.Text = "Статус";
            // 
            // cmbx_searchProducer
            // 
            this.cmbx_searchProducer.DisplayMember = "Название";
            this.cmbx_searchProducer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbx_searchProducer.FormattingEnabled = true;
            this.cmbx_searchProducer.Location = new System.Drawing.Point(75, 93);
            this.cmbx_searchProducer.Name = "cmbx_searchProducer";
            this.cmbx_searchProducer.Size = new System.Drawing.Size(111, 21);
            this.cmbx_searchProducer.TabIndex = 16;
            // 
            // cmbx_searchCategory
            // 
            this.cmbx_searchCategory.DisplayMember = "cname";
            this.cmbx_searchCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbx_searchCategory.FormattingEnabled = true;
            this.cmbx_searchCategory.Location = new System.Drawing.Point(75, 66);
            this.cmbx_searchCategory.Name = "cmbx_searchCategory";
            this.cmbx_searchCategory.Size = new System.Drawing.Size(111, 21);
            this.cmbx_searchCategory.TabIndex = 15;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 96);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 13);
            this.label14.TabIndex = 14;
            this.label14.Text = "Поставщик";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 70);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(60, 13);
            this.label15.TabIndex = 13;
            this.label15.Text = "Категория";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Артикул";
            // 
            // txbx_searchArtikul
            // 
            this.txbx_searchArtikul.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbx_searchArtikul.Location = new System.Drawing.Point(75, 14);
            this.txbx_searchArtikul.Name = "txbx_searchArtikul";
            this.txbx_searchArtikul.Size = new System.Drawing.Size(111, 20);
            this.txbx_searchArtikul.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Название";
            // 
            // txbx_searchName
            // 
            this.txbx_searchName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbx_searchName.Location = new System.Drawing.Point(75, 40);
            this.txbx_searchName.Name = "txbx_searchName";
            this.txbx_searchName.Size = new System.Drawing.Size(111, 20);
            this.txbx_searchName.TabIndex = 6;
            // 
            // grb_Tools
            // 
            this.grb_Tools.Controls.Add(this.button1);
            this.grb_Tools.Controls.Add(this.btt_delete);
            this.grb_Tools.Controls.Add(this.btt_add);
            this.grb_Tools.Dock = System.Windows.Forms.DockStyle.Left;
            this.grb_Tools.Location = new System.Drawing.Point(3, 16);
            this.grb_Tools.Name = "grb_Tools";
            this.grb_Tools.Size = new System.Drawing.Size(137, 183);
            this.grb_Tools.TabIndex = 10;
            this.grb_Tools.TabStop = false;
            this.grb_Tools.Text = "Кнопки";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 45);
            this.button1.TabIndex = 2;
            this.button1.Text = "Печатать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btt_delete
            // 
            this.btt_delete.Location = new System.Drawing.Point(8, 73);
            this.btt_delete.Name = "btt_delete";
            this.btt_delete.Size = new System.Drawing.Size(121, 45);
            this.btt_delete.TabIndex = 0;
            this.btt_delete.Text = "Удалить";
            this.btt_delete.UseVisualStyleBackColor = true;
            this.btt_delete.Click += new System.EventHandler(this.btt_delete_Click);
            // 
            // btt_add
            // 
            this.btt_add.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btt_add.Location = new System.Drawing.Point(8, 22);
            this.btt_add.Name = "btt_add";
            this.btt_add.Size = new System.Drawing.Size(121, 45);
            this.btt_add.TabIndex = 2;
            this.btt_add.Text = "Добавить";
            this.btt_add.UseVisualStyleBackColor = true;
            this.btt_add.Click += new System.EventHandler(this.btt_add_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btt_rename);
            this.groupBox3.Controls.Add(this.dtp);
            this.groupBox3.Controls.Add(this.cmbx_status);
            this.groupBox3.Controls.Add(this.label5);
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
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(140, 16);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(1);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox3.Size = new System.Drawing.Size(409, 183);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Кнопки";
            // 
            // btt_rename
            // 
            this.btt_rename.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btt_rename.Location = new System.Drawing.Point(6, 142);
            this.btt_rename.Name = "btt_rename";
            this.btt_rename.Size = new System.Drawing.Size(186, 22);
            this.btt_rename.TabIndex = 22;
            this.btt_rename.Text = "Редактировать";
            this.btt_rename.UseVisualStyleBackColor = true;
            this.btt_rename.Click += new System.EventHandler(this.btt_rename_Click_1);
            // 
            // dtp
            // 
            this.dtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp.Location = new System.Drawing.Point(78, 124);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(114, 20);
            this.dtp.TabIndex = 21;
            // 
            // cmbx_status
            // 
            this.cmbx_status.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbx_status.DisplayMember = "sname";
            this.cmbx_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbx_status.FormattingEnabled = true;
            this.cmbx_status.Location = new System.Drawing.Point(280, 97);
            this.cmbx_status.Name = "cmbx_status";
            this.cmbx_status.Size = new System.Drawing.Size(123, 21);
            this.cmbx_status.TabIndex = 20;
            this.cmbx_status.ValueMember = "id";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(194, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Статус";
            // 
            // txbx_price
            // 
            this.txbx_price.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txbx_price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbx_price.Location = new System.Drawing.Point(280, 18);
            this.txbx_price.Name = "txbx_price";
            this.txbx_price.Size = new System.Drawing.Size(123, 20);
            this.txbx_price.TabIndex = 13;
            // 
            // cmbx_units
            // 
            this.cmbx_units.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbx_units.DisplayMember = "uname";
            this.cmbx_units.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbx_units.FormattingEnabled = true;
            this.cmbx_units.Location = new System.Drawing.Point(280, 70);
            this.cmbx_units.Name = "cmbx_units";
            this.cmbx_units.Size = new System.Drawing.Size(123, 21);
            this.cmbx_units.TabIndex = 18;
            this.cmbx_units.ValueMember = "id";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(194, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Цена";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(194, 73);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "Ед. измерения";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(194, 44);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Количество";
            // 
            // txbx_quantity
            // 
            this.txbx_quantity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txbx_quantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbx_quantity.Location = new System.Drawing.Point(280, 42);
            this.txbx_quantity.Name = "txbx_quantity";
            this.txbx_quantity.Size = new System.Drawing.Size(123, 20);
            this.txbx_quantity.TabIndex = 15;
            // 
            // cmbx_producer
            // 
            this.cmbx_producer.DisplayMember = "Название";
            this.cmbx_producer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbx_producer.FormattingEnabled = true;
            this.cmbx_producer.Location = new System.Drawing.Point(78, 97);
            this.cmbx_producer.Name = "cmbx_producer";
            this.cmbx_producer.Size = new System.Drawing.Size(114, 21);
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
            this.cmbx_category.Size = new System.Drawing.Size(114, 21);
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
            this.label6.Location = new System.Drawing.Point(194, 125);
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
            this.txbx_comment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txbx_comment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbx_comment.Location = new System.Drawing.Point(280, 123);
            this.txbx_comment.Multiline = true;
            this.txbx_comment.Name = "txbx_comment";
            this.txbx_comment.Size = new System.Drawing.Size(123, 44);
            this.txbx_comment.TabIndex = 5;
            // 
            // txbx_artikul
            // 
            this.txbx_artikul.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbx_artikul.Location = new System.Drawing.Point(78, 19);
            this.txbx_artikul.Name = "txbx_artikul";
            this.txbx_artikul.Size = new System.Drawing.Size(114, 20);
            this.txbx_artikul.TabIndex = 3;
            // 
            // txbx_name
            // 
            this.txbx_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbx_name.Location = new System.Drawing.Point(78, 45);
            this.txbx_name.Name = "txbx_name";
            this.txbx_name.Size = new System.Drawing.Size(114, 20);
            this.txbx_name.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.grb_Tools);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(743, 202);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Панель инструментов";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(102, 17);
            this.toolStripStatusLabel1.Text = "Форма - Товаров";
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 541);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "ProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Склад";
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grb_Tools.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmi_print;
        private System.Windows.Forms.ToolStripMenuItem tsmi_export;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbx_searchStatus;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbx_searchProducer;
        private System.Windows.Forms.ComboBox cmbx_searchCategory;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txbx_searchArtikul;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txbx_searchName;
        private System.Windows.Forms.GroupBox grb_Tools;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btt_delete;
        private System.Windows.Forms.Button btt_add;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btt_rename;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.ComboBox cmbx_status;
        private System.Windows.Forms.Label label5;
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btt_Next;
        private System.Windows.Forms.Button btt_search;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;

    }
}