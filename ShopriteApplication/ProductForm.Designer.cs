namespace ShopriteApplication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.prodDate = new Guna.UI.WinForms.GunaDateTimePicker();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.filterCB = new System.Windows.Forms.ComboBox();
            this.prodGridView = new Guna.UI.WinForms.GunaDataGridView();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.prodCb = new System.Windows.Forms.ComboBox();
            this.prodName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.prodQty = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.prodPrice = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.prodId = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.expDate = new Guna.UI.WinForms.GunaDateTimePicker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OrangeRed;
            this.panel1.Controls.Add(this.expDate);
            this.panel1.Controls.Add(this.prodDate);
            this.panel1.Controls.Add(this.gunaLabel1);
            this.panel1.Controls.Add(this.gunaPictureBox1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.filterCB);
            this.panel1.Controls.Add(this.prodGridView);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.prodCb);
            this.panel1.Controls.Add(this.prodName);
            this.panel1.Controls.Add(this.prodQty);
            this.panel1.Controls.Add(this.prodPrice);
            this.panel1.Controls.Add(this.prodId);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(150, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1065, 779);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // prodDate
            // 
            this.prodDate.BaseColor = System.Drawing.Color.White;
            this.prodDate.BorderColor = System.Drawing.Color.Silver;
            this.prodDate.CustomFormat = "yyyy-MM-dd";
            this.prodDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.prodDate.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.prodDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.prodDate.ForeColor = System.Drawing.Color.Black;
            this.prodDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.prodDate.Location = new System.Drawing.Point(176, 463);
            this.prodDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.prodDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.prodDate.Name = "prodDate";
            this.prodDate.OnHoverBaseColor = System.Drawing.Color.White;
            this.prodDate.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.prodDate.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.prodDate.OnPressedColor = System.Drawing.Color.Black;
            this.prodDate.Size = new System.Drawing.Size(189, 30);
            this.prodDate.TabIndex = 63;
            this.prodDate.Text = "2022-08-26";
            this.prodDate.Value = new System.DateTime(2022, 8, 26, 0, 0, 0, 0);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.BackColor = System.Drawing.Color.Tomato;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.Transparent;
            this.gunaLabel1.Location = new System.Drawing.Point(119, 699);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(71, 32);
            this.gunaLabel1.TabIndex = 62;
            this.gunaLabel1.Text = "Clear";
            this.gunaLabel1.Click += new System.EventHandler(this.gunaLabel1_Click);
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox1.Image")));
            this.gunaPictureBox1.Location = new System.Drawing.Point(47, 16);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(120, 120);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaPictureBox1.TabIndex = 40;
            this.gunaPictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(438, 97);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(287, 35);
            this.textBox1.TabIndex = 39;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.OrangeRed;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.PeachPuff;
            this.label9.Location = new System.Drawing.Point(245, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(187, 28);
            this.label9.TabIndex = 38;
            this.label9.Text = "Search Product";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.OrangeRed;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.PeachPuff;
            this.label8.Location = new System.Drawing.Point(25, 525);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 28);
            this.label8.TabIndex = 36;
            this.label8.Text = "EXP. DATE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.OrangeRed;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.PeachPuff;
            this.label6.Location = new System.Drawing.Point(25, 465);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 28);
            this.label6.TabIndex = 34;
            this.label6.Text = "PROD. DATE";
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.PeachPuff;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.OrangeRed;
            this.button8.Location = new System.Drawing.Point(925, 96);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(103, 33);
            this.button8.TabIndex = 33;
            this.button8.Text = "Refresh";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // filterCB
            // 
            this.filterCB.BackColor = System.Drawing.Color.PeachPuff;
            this.filterCB.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterCB.ForeColor = System.Drawing.Color.OrangeRed;
            this.filterCB.FormattingEnabled = true;
            this.filterCB.Items.AddRange(new object[] {
            "ADMIN",
            "SELLER"});
            this.filterCB.Location = new System.Drawing.Point(731, 97);
            this.filterCB.Name = "filterCB";
            this.filterCB.Size = new System.Drawing.Size(188, 33);
            this.filterCB.TabIndex = 32;
            this.filterCB.Text = "Select Category";
            // 
            // prodGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.prodGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.prodGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.prodGridView.BackgroundColor = System.Drawing.Color.White;
            this.prodGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.prodGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.prodGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.prodGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.prodGridView.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.prodGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.prodGridView.EnableHeadersVisualStyles = false;
            this.prodGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.prodGridView.Location = new System.Drawing.Point(384, 142);
            this.prodGridView.Name = "prodGridView";
            this.prodGridView.RowHeadersVisible = false;
            this.prodGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.prodGridView.Size = new System.Drawing.Size(646, 599);
            this.prodGridView.TabIndex = 31;
            this.prodGridView.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.prodGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.prodGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.prodGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.prodGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.prodGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.prodGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.prodGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.prodGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.prodGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.prodGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.prodGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.prodGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.prodGridView.ThemeStyle.HeaderStyle.Height = 4;
            this.prodGridView.ThemeStyle.ReadOnly = false;
            this.prodGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.prodGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.prodGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.prodGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.prodGridView.ThemeStyle.RowsStyle.Height = 22;
            this.prodGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.prodGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.prodGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gunaDataGridView1_CellContentClick);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.PeachPuff;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.OrangeRed;
            this.button7.Location = new System.Drawing.Point(125, 638);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(103, 43);
            this.button7.TabIndex = 30;
            this.button7.Text = "UPDATE";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.PeachPuff;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.OrangeRed;
            this.button6.Location = new System.Drawing.Point(245, 638);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(95, 43);
            this.button6.TabIndex = 29;
            this.button6.Text = "DELETE";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.PeachPuff;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.OrangeRed;
            this.button5.Location = new System.Drawing.Point(21, 638);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(87, 43);
            this.button5.TabIndex = 5;
            this.button5.Text = "ADD";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // prodCb
            // 
            this.prodCb.BackColor = System.Drawing.Color.PeachPuff;
            this.prodCb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodCb.ForeColor = System.Drawing.Color.OrangeRed;
            this.prodCb.FormattingEnabled = true;
            this.prodCb.Items.AddRange(new object[] {
            "ADMIN",
            "SELLER"});
            this.prodCb.Location = new System.Drawing.Point(171, 583);
            this.prodCb.Name = "prodCb";
            this.prodCb.Size = new System.Drawing.Size(178, 27);
            this.prodCb.TabIndex = 28;
            this.prodCb.Text = "Select Category";
            // 
            // prodName
            // 
            this.prodName.BackColor = System.Drawing.Color.OrangeRed;
            this.prodName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.prodName.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.prodName.HintForeColor = System.Drawing.Color.Empty;
            this.prodName.HintText = "";
            this.prodName.isPassword = false;
            this.prodName.LineFocusedColor = System.Drawing.Color.DarkRed;
            this.prodName.LineIdleColor = System.Drawing.Color.PeachPuff;
            this.prodName.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.prodName.LineThickness = 4;
            this.prodName.Location = new System.Drawing.Point(176, 239);
            this.prodName.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.prodName.Name = "prodName";
            this.prodName.Size = new System.Drawing.Size(189, 43);
            this.prodName.TabIndex = 27;
            this.prodName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // prodQty
            // 
            this.prodQty.BackColor = System.Drawing.Color.OrangeRed;
            this.prodQty.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.prodQty.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodQty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.prodQty.HintForeColor = System.Drawing.Color.Empty;
            this.prodQty.HintText = "";
            this.prodQty.isPassword = false;
            this.prodQty.LineFocusedColor = System.Drawing.Color.DarkRed;
            this.prodQty.LineIdleColor = System.Drawing.Color.PeachPuff;
            this.prodQty.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.prodQty.LineThickness = 4;
            this.prodQty.Location = new System.Drawing.Point(176, 314);
            this.prodQty.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.prodQty.Name = "prodQty";
            this.prodQty.Size = new System.Drawing.Size(189, 43);
            this.prodQty.TabIndex = 26;
            this.prodQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // prodPrice
            // 
            this.prodPrice.BackColor = System.Drawing.Color.OrangeRed;
            this.prodPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.prodPrice.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.prodPrice.HintForeColor = System.Drawing.Color.Empty;
            this.prodPrice.HintText = "";
            this.prodPrice.isPassword = false;
            this.prodPrice.LineFocusedColor = System.Drawing.Color.DarkRed;
            this.prodPrice.LineIdleColor = System.Drawing.Color.PeachPuff;
            this.prodPrice.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.prodPrice.LineThickness = 4;
            this.prodPrice.Location = new System.Drawing.Point(176, 382);
            this.prodPrice.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.prodPrice.Name = "prodPrice";
            this.prodPrice.Size = new System.Drawing.Size(189, 43);
            this.prodPrice.TabIndex = 25;
            this.prodPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // prodId
            // 
            this.prodId.BackColor = System.Drawing.Color.OrangeRed;
            this.prodId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.prodId.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.prodId.HintForeColor = System.Drawing.Color.Empty;
            this.prodId.HintText = "";
            this.prodId.isPassword = false;
            this.prodId.LineFocusedColor = System.Drawing.Color.DarkRed;
            this.prodId.LineIdleColor = System.Drawing.Color.PeachPuff;
            this.prodId.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.prodId.LineThickness = 4;
            this.prodId.Location = new System.Drawing.Point(176, 166);
            this.prodId.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.prodId.Name = "prodId";
            this.prodId.Size = new System.Drawing.Size(189, 43);
            this.prodId.TabIndex = 24;
            this.prodId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.OrangeRed;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.PeachPuff;
            this.label5.Location = new System.Drawing.Point(25, 579);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 28);
            this.label5.TabIndex = 23;
            this.label5.Text = "CATEGORY";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.OrangeRed;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.PeachPuff;
            this.label4.Location = new System.Drawing.Point(25, 394);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 28);
            this.label4.TabIndex = 22;
            this.label4.Text = "PRICE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.OrangeRed;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.PeachPuff;
            this.label2.Location = new System.Drawing.Point(25, 329);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 28);
            this.label2.TabIndex = 20;
            this.label2.Text = "QUANTITY";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.OrangeRed;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.PeachPuff;
            this.label1.Location = new System.Drawing.Point(25, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 28);
            this.label1.TabIndex = 18;
            this.label1.Text = "NAME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.OrangeRed;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.PeachPuff;
            this.label3.Location = new System.Drawing.Point(25, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 28);
            this.label3.TabIndex = 16;
            this.label3.Text = "ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.OrangeRed;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.PeachPuff;
            this.label7.Location = new System.Drawing.Point(343, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(332, 38);
            this.label7.TabIndex = 14;
            this.label7.Text = "MANAGE PRODUCTS";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.OrangeRed;
            this.button1.Location = new System.Drawing.Point(12, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "Users";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.OrangeRed;
            this.button2.Location = new System.Drawing.Point(12, 174);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 34);
            this.button2.TabIndex = 2;
            this.button2.Text = "Category";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.OrangeRed;
            this.button4.Location = new System.Drawing.Point(1137, 8);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(60, 33);
            this.button4.TabIndex = 4;
            this.button4.Text = "X";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // expDate
            // 
            this.expDate.BaseColor = System.Drawing.Color.White;
            this.expDate.BorderColor = System.Drawing.Color.Silver;
            this.expDate.CustomFormat = "yyyy-MM-dd";
            this.expDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.expDate.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.expDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.expDate.ForeColor = System.Drawing.Color.Black;
            this.expDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.expDate.Location = new System.Drawing.Point(176, 523);
            this.expDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.expDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.expDate.Name = "expDate";
            this.expDate.OnHoverBaseColor = System.Drawing.Color.White;
            this.expDate.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.expDate.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.expDate.OnPressedColor = System.Drawing.Color.Black;
            this.expDate.Size = new System.Drawing.Size(189, 30);
            this.expDate.TabIndex = 64;
            this.expDate.Text = "2022-08-26";
            this.expDate.Value = new System.DateTime(2022, 8, 26, 0, 0, 0, 0);
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 833);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductForm";
            this.Text = "ProductForm";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox prodName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox prodQty;
        private Bunifu.Framework.UI.BunifuMaterialTextbox prodPrice;
        private Bunifu.Framework.UI.BunifuMaterialTextbox prodId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox prodCb;
        private System.Windows.Forms.ComboBox filterCB;
        private Guna.UI.WinForms.GunaDataGridView prodGridView;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label9;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaDateTimePicker prodDate;
        private Guna.UI.WinForms.GunaDateTimePicker expDate;
    }
}