
namespace pharmacy.forms
{
    partial class billing_form
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(billing_form));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Medicin = new System.Windows.Forms.Label();
            this.ava = new System.Windows.Forms.Label();
            this.Quantity = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Total_Amount = new System.Windows.Forms.Label();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.bunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.barcode = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.dgp = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.id = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.unite_buying = new System.Windows.Forms.Label();
            this.unit_price = new System.Windows.Forms.Label();
            this.bunifuThinButton23 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.namper = new System.Windows.Forms.Label();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.exp = new System.Windows.Forms.Label();
            this.total_profit = new System.Windows.Forms.Label();
            this.cust = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuThinButton25 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton24 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.tablet = new System.Windows.Forms.Label();
            this.tablets = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.expd = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgp)).BeginInit();
            this.SuspendLayout();
            // 
            // Medicin
            // 
            this.Medicin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Medicin.AutoSize = true;
            this.Medicin.Font = new System.Drawing.Font("splart-h-amana", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Medicin.ForeColor = System.Drawing.Color.Maroon;
            this.Medicin.Location = new System.Drawing.Point(140, 20);
            this.Medicin.Name = "Medicin";
            this.Medicin.Size = new System.Drawing.Size(173, 49);
            this.Medicin.TabIndex = 18;
            this.Medicin.Text = "قسم الفواتير";
            this.Medicin.Click += new System.EventHandler(this.Medicin_Click);
            // 
            // ava
            // 
            this.ava.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ava.AutoSize = true;
            this.ava.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ava.ForeColor = System.Drawing.Color.Maroon;
            this.ava.Location = new System.Drawing.Point(147, 297);
            this.ava.Name = "ava";
            this.ava.Size = new System.Drawing.Size(120, 22);
            this.ava.TabIndex = 24;
            this.ava.Text = "الكـمـيـه الـمـتـاحـه";
            // 
            // Quantity
            // 
            this.Quantity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Quantity.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Quantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Quantity.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Quantity.ForeColor = System.Drawing.Color.Maroon;
            this.Quantity.HintForeColor = System.Drawing.Color.Empty;
            this.Quantity.HintText = "";
            this.Quantity.isPassword = false;
            this.Quantity.LineFocusedColor = System.Drawing.Color.Maroon;
            this.Quantity.LineIdleColor = System.Drawing.Color.Gainsboro;
            this.Quantity.LineMouseHoverColor = System.Drawing.Color.Maroon;
            this.Quantity.LineThickness = 3;
            this.Quantity.Location = new System.Drawing.Point(245, 478);
            this.Quantity.Margin = new System.Windows.Forms.Padding(4);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(134, 33);
            this.Quantity.TabIndex = 25;
            this.Quantity.Text = "0";
            this.Quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Quantity.OnValueChanged += new System.EventHandler(this.Quantity_OnValueChanged_1);
            this.Quantity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Quantity_KeyDown);
            this.Quantity.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Quantity_MouseDoubleClick);
            // 
            // Total_Amount
            // 
            this.Total_Amount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Total_Amount.AutoSize = true;
            this.Total_Amount.Font = new System.Drawing.Font("splart-h-amana", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Total_Amount.ForeColor = System.Drawing.Color.Maroon;
            this.Total_Amount.Location = new System.Drawing.Point(793, 705);
            this.Total_Amount.Name = "Total_Amount";
            this.Total_Amount.Size = new System.Drawing.Size(208, 49);
            this.Total_Amount.TabIndex = 27;
            this.Total_Amount.Text = "اجمالي التكلفه";
            this.Total_Amount.Click += new System.EventHandler(this.Total_Amount_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // bunifuThinButton22
            // 
            this.bunifuThinButton22.ActiveBorderThickness = 1;
            this.bunifuThinButton22.ActiveCornerRadius = 20;
            this.bunifuThinButton22.ActiveFillColor = System.Drawing.Color.Maroon;
            this.bunifuThinButton22.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton22.ActiveLineColor = System.Drawing.Color.Maroon;
            this.bunifuThinButton22.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuThinButton22.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuThinButton22.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton22.BackgroundImage")));
            this.bunifuThinButton22.ButtonText = "ارجاع";
            this.bunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton22.Font = new System.Drawing.Font("splart-h-amana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuThinButton22.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuThinButton22.IdleBorderThickness = 1;
            this.bunifuThinButton22.IdleCornerRadius = 20;
            this.bunifuThinButton22.IdleFillColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuThinButton22.IdleForecolor = System.Drawing.Color.Maroon;
            this.bunifuThinButton22.IdleLineColor = System.Drawing.Color.Maroon;
            this.bunifuThinButton22.Location = new System.Drawing.Point(145, 613);
            this.bunifuThinButton22.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.bunifuThinButton22.Name = "bunifuThinButton22";
            this.bunifuThinButton22.Size = new System.Drawing.Size(168, 45);
            this.bunifuThinButton22.TabIndex = 31;
            this.bunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton22.Click += new System.EventHandler(this.bunifuThinButton22_Click_2);
            // 
            // barcode
            // 
            this.barcode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.barcode.BackColor = System.Drawing.Color.WhiteSmoke;
            this.barcode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.barcode.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.barcode.ForeColor = System.Drawing.Color.Maroon;
            this.barcode.HintForeColor = System.Drawing.Color.Empty;
            this.barcode.HintText = "";
            this.barcode.isPassword = false;
            this.barcode.LineFocusedColor = System.Drawing.Color.Maroon;
            this.barcode.LineIdleColor = System.Drawing.Color.Gainsboro;
            this.barcode.LineMouseHoverColor = System.Drawing.Color.Maroon;
            this.barcode.LineThickness = 3;
            this.barcode.Location = new System.Drawing.Point(100, 213);
            this.barcode.Margin = new System.Windows.Forms.Padding(4);
            this.barcode.Name = "barcode";
            this.barcode.Size = new System.Drawing.Size(227, 33);
            this.barcode.TabIndex = 32;
            this.barcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.barcode.OnValueChanged += new System.EventHandler(this.barcode_OnValueChanged);
            // 
            // dgp
            // 
            this.dgp.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgp.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgp.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgp.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgp.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgp.DoubleBuffered = true;
            this.dgp.EnableHeadersVisualStyles = false;
            this.dgp.HeaderBgColor = System.Drawing.Color.Maroon;
            this.dgp.HeaderForeColor = System.Drawing.Color.WhiteSmoke;
            this.dgp.Location = new System.Drawing.Point(449, 55);
            this.dgp.MultiSelect = false;
            this.dgp.Name = "dgp";
            this.dgp.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgp.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dgp.Size = new System.Drawing.Size(914, 648);
            this.dgp.TabIndex = 34;
            // 
            // id
            // 
            this.id.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.id.AutoSize = true;
            this.id.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.ForeColor = System.Drawing.Color.Maroon;
            this.id.Location = new System.Drawing.Point(205, 80);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(25, 19);
            this.id.TabIndex = 35;
            this.id.Text = "ID";
            this.id.Click += new System.EventHandler(this.id_Click);
            // 
            // date
            // 
            this.date.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.date.AutoSize = true;
            this.date.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.ForeColor = System.Drawing.Color.Maroon;
            this.date.Location = new System.Drawing.Point(193, 181);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(48, 19);
            this.date.TabIndex = 36;
            this.date.Text = "date";
            this.date.Click += new System.EventHandler(this.date_Click);
            // 
            // time
            // 
            this.time.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.time.AutoSize = true;
            this.time.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.ForeColor = System.Drawing.Color.Maroon;
            this.time.Location = new System.Drawing.Point(194, 146);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(47, 19);
            this.time.TabIndex = 37;
            this.time.Text = "time";
            this.time.Click += new System.EventHandler(this.time_Click);
            // 
            // unite_buying
            // 
            this.unite_buying.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.unite_buying.AutoSize = true;
            this.unite_buying.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unite_buying.ForeColor = System.Drawing.Color.Maroon;
            this.unite_buying.Location = new System.Drawing.Point(356, 559);
            this.unite_buying.Name = "unite_buying";
            this.unite_buying.Size = new System.Drawing.Size(57, 19);
            this.unite_buying.TabIndex = 38;
            this.unite_buying.Text = "سعر الشراء";
            this.unite_buying.Visible = false;
            this.unite_buying.Click += new System.EventHandler(this.unite_buying_Click);
            // 
            // unit_price
            // 
            this.unit_price.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.unit_price.AutoSize = true;
            this.unit_price.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unit_price.ForeColor = System.Drawing.Color.Maroon;
            this.unit_price.Location = new System.Drawing.Point(207, 405);
            this.unit_price.Name = "unit_price";
            this.unit_price.Size = new System.Drawing.Size(0, 19);
            this.unit_price.TabIndex = 39;
            this.unit_price.Click += new System.EventHandler(this.unit_price_Click);
            // 
            // bunifuThinButton23
            // 
            this.bunifuThinButton23.ActiveBorderThickness = 1;
            this.bunifuThinButton23.ActiveCornerRadius = 20;
            this.bunifuThinButton23.ActiveFillColor = System.Drawing.Color.Maroon;
            this.bunifuThinButton23.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton23.ActiveLineColor = System.Drawing.Color.Maroon;
            this.bunifuThinButton23.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuThinButton23.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuThinButton23.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton23.BackgroundImage")));
            this.bunifuThinButton23.ButtonText = "اضـافـه";
            this.bunifuThinButton23.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton23.Font = new System.Drawing.Font("splart-h-amana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuThinButton23.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuThinButton23.IdleBorderThickness = 1;
            this.bunifuThinButton23.IdleCornerRadius = 20;
            this.bunifuThinButton23.IdleFillColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuThinButton23.IdleForecolor = System.Drawing.Color.Maroon;
            this.bunifuThinButton23.IdleLineColor = System.Drawing.Color.Maroon;
            this.bunifuThinButton23.Location = new System.Drawing.Point(145, 571);
            this.bunifuThinButton23.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.bunifuThinButton23.Name = "bunifuThinButton23";
            this.bunifuThinButton23.Size = new System.Drawing.Size(168, 45);
            this.bunifuThinButton23.TabIndex = 40;
            this.bunifuThinButton23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton23.Click += new System.EventHandler(this.bunifuThinButton23_Click);
            this.bunifuThinButton23.Enter += new System.EventHandler(this.bunifuThinButton23_Enter);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(96, 370);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 19);
            this.label1.TabIndex = 42;
            this.label1.Text = "EXP DATE";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(112, 405);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 19);
            this.label2.TabIndex = 43;
            this.label2.Text = "سعر البيع";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(356, 588);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 19);
            this.label3.TabIndex = 44;
            this.label3.Text = "سعر الشراء";
            this.label3.Visible = false;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // namper
            // 
            this.namper.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.namper.AutoSize = true;
            this.namper.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namper.ForeColor = System.Drawing.Color.Maroon;
            this.namper.Location = new System.Drawing.Point(208, 115);
            this.namper.Name = "namper";
            this.namper.Size = new System.Drawing.Size(18, 19);
            this.namper.TabIndex = 45;
            this.namper.Text = "0";
            this.namper.Click += new System.EventHandler(this.namper_Click);
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.Maroon;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.Maroon;
            this.bunifuThinButton21.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuThinButton21.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "فاتوره جديده";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("splart-h-amana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.Maroon;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.Maroon;
            this.bunifuThinButton21.Location = new System.Drawing.Point(145, 658);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(168, 45);
            this.bunifuThinButton21.TabIndex = 46;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click_1);
            // 
            // exp
            // 
            this.exp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.exp.AutoSize = true;
            this.exp.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exp.ForeColor = System.Drawing.Color.Maroon;
            this.exp.Location = new System.Drawing.Point(196, 370);
            this.exp.Name = "exp";
            this.exp.Size = new System.Drawing.Size(0, 19);
            this.exp.TabIndex = 47;
            this.exp.Click += new System.EventHandler(this.exp_Click);
            // 
            // total_profit
            // 
            this.total_profit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.total_profit.AutoSize = true;
            this.total_profit.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_profit.ForeColor = System.Drawing.Color.Maroon;
            this.total_profit.Location = new System.Drawing.Point(340, 719);
            this.total_profit.Name = "total_profit";
            this.total_profit.Size = new System.Drawing.Size(122, 19);
            this.total_profit.TabIndex = 48;
            this.total_profit.Text = "total_profit";
            this.total_profit.Visible = false;
            // 
            // cust
            // 
            this.cust.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cust.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cust.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cust.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cust.ForeColor = System.Drawing.Color.Maroon;
            this.cust.HintForeColor = System.Drawing.Color.Empty;
            this.cust.HintText = "";
            this.cust.isPassword = false;
            this.cust.LineFocusedColor = System.Drawing.Color.Maroon;
            this.cust.LineIdleColor = System.Drawing.Color.Gainsboro;
            this.cust.LineMouseHoverColor = System.Drawing.Color.Maroon;
            this.cust.LineThickness = 3;
            this.cust.Location = new System.Drawing.Point(116, 519);
            this.cust.Margin = new System.Windows.Forms.Padding(4);
            this.cust.Name = "cust";
            this.cust.Size = new System.Drawing.Size(227, 33);
            this.cust.TabIndex = 49;
            this.cust.Text = "رقم العميل";
            this.cust.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cust.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.cust_MouseDoubleClick);
            // 
            // bunifuThinButton25
            // 
            this.bunifuThinButton25.ActiveBorderThickness = 1;
            this.bunifuThinButton25.ActiveCornerRadius = 20;
            this.bunifuThinButton25.ActiveFillColor = System.Drawing.Color.Maroon;
            this.bunifuThinButton25.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton25.ActiveLineColor = System.Drawing.Color.Maroon;
            this.bunifuThinButton25.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuThinButton25.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuThinButton25.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton25.BackgroundImage")));
            this.bunifuThinButton25.ButtonText = "رجوع";
            this.bunifuThinButton25.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton25.Font = new System.Drawing.Font("splart-h-amana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuThinButton25.ForeColor = System.Drawing.Color.Maroon;
            this.bunifuThinButton25.IdleBorderThickness = 1;
            this.bunifuThinButton25.IdleCornerRadius = 20;
            this.bunifuThinButton25.IdleFillColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuThinButton25.IdleForecolor = System.Drawing.Color.Maroon;
            this.bunifuThinButton25.IdleLineColor = System.Drawing.Color.Maroon;
            this.bunifuThinButton25.Location = new System.Drawing.Point(224, 719);
            this.bunifuThinButton25.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.bunifuThinButton25.Name = "bunifuThinButton25";
            this.bunifuThinButton25.Size = new System.Drawing.Size(144, 54);
            this.bunifuThinButton25.TabIndex = 136;
            this.bunifuThinButton25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton25.Click += new System.EventHandler(this.bunifuThinButton25_Click);
            // 
            // bunifuThinButton24
            // 
            this.bunifuThinButton24.ActiveBorderThickness = 1;
            this.bunifuThinButton24.ActiveCornerRadius = 20;
            this.bunifuThinButton24.ActiveFillColor = System.Drawing.Color.Maroon;
            this.bunifuThinButton24.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton24.ActiveLineColor = System.Drawing.Color.Maroon;
            this.bunifuThinButton24.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuThinButton24.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuThinButton24.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton24.BackgroundImage")));
            this.bunifuThinButton24.ButtonText = "الصفحه الرئيسيه";
            this.bunifuThinButton24.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton24.Font = new System.Drawing.Font("splart-h-amana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuThinButton24.ForeColor = System.Drawing.Color.Maroon;
            this.bunifuThinButton24.IdleBorderThickness = 1;
            this.bunifuThinButton24.IdleCornerRadius = 20;
            this.bunifuThinButton24.IdleFillColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuThinButton24.IdleForecolor = System.Drawing.Color.Maroon;
            this.bunifuThinButton24.IdleLineColor = System.Drawing.Color.Maroon;
            this.bunifuThinButton24.Location = new System.Drawing.Point(43, 719);
            this.bunifuThinButton24.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.bunifuThinButton24.Name = "bunifuThinButton24";
            this.bunifuThinButton24.Size = new System.Drawing.Size(167, 54);
            this.bunifuThinButton24.TabIndex = 135;
            this.bunifuThinButton24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton24.Click += new System.EventHandler(this.bunifuThinButton24_Click);
            // 
            // tablet
            // 
            this.tablet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tablet.AutoSize = true;
            this.tablet.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tablet.ForeColor = System.Drawing.Color.Maroon;
            this.tablet.Location = new System.Drawing.Point(165, 332);
            this.tablet.Name = "tablet";
            this.tablet.Size = new System.Drawing.Size(85, 22);
            this.tablet.TabIndex = 137;
            this.tablet.Text = "عدد الاشرطه";
            // 
            // tablets
            // 
            this.tablets.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tablets.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tablets.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tablets.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tablets.ForeColor = System.Drawing.Color.Maroon;
            this.tablets.HintForeColor = System.Drawing.Color.Empty;
            this.tablets.HintText = "";
            this.tablets.isPassword = false;
            this.tablets.LineFocusedColor = System.Drawing.Color.Maroon;
            this.tablets.LineIdleColor = System.Drawing.Color.Gainsboro;
            this.tablets.LineMouseHoverColor = System.Drawing.Color.Maroon;
            this.tablets.LineThickness = 3;
            this.tablets.Location = new System.Drawing.Point(67, 478);
            this.tablets.Margin = new System.Windows.Forms.Padding(4);
            this.tablets.Name = "tablets";
            this.tablets.Size = new System.Drawing.Size(134, 33);
            this.tablets.TabIndex = 138;
            this.tablets.Text = "0";
            this.tablets.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // expd
            // 
            this.expd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.expd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expd.ForeColor = System.Drawing.Color.Maroon;
            this.expd.FormattingEnabled = true;
            this.expd.Location = new System.Drawing.Point(34, 253);
            this.expd.Name = "expd";
            this.expd.Size = new System.Drawing.Size(143, 28);
            this.expd.TabIndex = 139;
            this.expd.Text = "EXP";
            this.expd.SelectedIndexChanged += new System.EventHandler(this.expd_SelectedIndexChanged);
            this.expd.Click += new System.EventHandler(this.expd_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.Maroon;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(209, 253);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(143, 28);
            this.comboBox1.TabIndex = 140;
            this.comboBox1.Text = "EXP";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.Click += new System.EventHandler(this.comboBox1_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(92, 452);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 22);
            this.label4.TabIndex = 141;
            this.label4.Text = "عدد الاشرطه";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(270, 452);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 22);
            this.label5.TabIndex = 142;
            this.label5.Text = "عدد العلب";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // billing_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.expd);
            this.Controls.Add(this.tablets);
            this.Controls.Add(this.tablet);
            this.Controls.Add(this.bunifuThinButton25);
            this.Controls.Add(this.bunifuThinButton24);
            this.Controls.Add(this.cust);
            this.Controls.Add(this.total_profit);
            this.Controls.Add(this.exp);
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.namper);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bunifuThinButton23);
            this.Controls.Add(this.unit_price);
            this.Controls.Add(this.unite_buying);
            this.Controls.Add(this.time);
            this.Controls.Add(this.date);
            this.Controls.Add(this.id);
            this.Controls.Add(this.dgp);
            this.Controls.Add(this.barcode);
            this.Controls.Add(this.bunifuThinButton22);
            this.Controls.Add(this.Total_Amount);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.ava);
            this.Controls.Add(this.Medicin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "billing_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.billing_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Medicin;
        private System.Windows.Forms.Label ava;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Quantity;
        private System.Windows.Forms.Label Total_Amount;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton22;
        private Bunifu.Framework.UI.BunifuMaterialTextbox barcode;
        public Bunifu.Framework.UI.BunifuCustomDataGrid dgp;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Label unite_buying;
        private System.Windows.Forms.Label unit_price;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton23;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label namper;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private System.Windows.Forms.Label exp;
        private System.Windows.Forms.Label total_profit;
        private Bunifu.Framework.UI.BunifuMaterialTextbox cust;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton25;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton24;
        private System.Windows.Forms.Label tablet;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tablets;
        private System.Windows.Forms.ComboBox expd;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer1;
    }
}