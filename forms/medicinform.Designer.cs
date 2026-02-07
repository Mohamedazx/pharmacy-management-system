
namespace pharmacy.forms
{
    partial class medicinform
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(medicinform));
            this.Medicin = new System.Windows.Forms.Label();
            this.med_name = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.buy = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.sell = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Quantity = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.dgp = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.bunifuThinButton23 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton24 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.combany = new System.Windows.Forms.ComboBox();
            this.bunifuThinButton25 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.id = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.BarCode = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton26 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.tablet = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.buying = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.dt = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.name = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.dgp)).BeginInit();
            this.SuspendLayout();
            // 
            // Medicin
            // 
            this.Medicin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Medicin.AutoSize = true;
            this.Medicin.Font = new System.Drawing.Font("splart-h-amana", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Medicin.ForeColor = System.Drawing.Color.Maroon;
            this.Medicin.Location = new System.Drawing.Point(152, 40);
            this.Medicin.Name = "Medicin";
            this.Medicin.Size = new System.Drawing.Size(184, 49);
            this.Medicin.TabIndex = 0;
            this.Medicin.Text = "مخزن الادويه";
            // 
            // med_name
            // 
            this.med_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.med_name.BackColor = System.Drawing.Color.WhiteSmoke;
            this.med_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.med_name.Font = new System.Drawing.Font("splart-h-amana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.med_name.ForeColor = System.Drawing.Color.Maroon;
            this.med_name.HintForeColor = System.Drawing.Color.Empty;
            this.med_name.HintText = "";
            this.med_name.isPassword = false;
            this.med_name.LineFocusedColor = System.Drawing.Color.Maroon;
            this.med_name.LineIdleColor = System.Drawing.Color.Gainsboro;
            this.med_name.LineMouseHoverColor = System.Drawing.Color.Maroon;
            this.med_name.LineThickness = 4;
            this.med_name.Location = new System.Drawing.Point(38, 148);
            this.med_name.Margin = new System.Windows.Forms.Padding(4);
            this.med_name.Name = "med_name";
            this.med_name.Size = new System.Drawing.Size(189, 42);
            this.med_name.TabIndex = 11;
            this.med_name.Text = "اسم الدواء";
            this.med_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.med_name.OnValueChanged += new System.EventHandler(this.med_name_OnValueChanged);
            // 
            // buy
            // 
            this.buy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buy.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buy.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.buy.Font = new System.Drawing.Font("splart-h-amana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.buy.ForeColor = System.Drawing.Color.Maroon;
            this.buy.HintForeColor = System.Drawing.Color.Empty;
            this.buy.HintText = "";
            this.buy.isPassword = false;
            this.buy.LineFocusedColor = System.Drawing.Color.Maroon;
            this.buy.LineIdleColor = System.Drawing.Color.Gainsboro;
            this.buy.LineMouseHoverColor = System.Drawing.Color.Maroon;
            this.buy.LineThickness = 4;
            this.buy.Location = new System.Drawing.Point(304, 148);
            this.buy.Margin = new System.Windows.Forms.Padding(4);
            this.buy.Name = "buy";
            this.buy.Size = new System.Drawing.Size(145, 42);
            this.buy.TabIndex = 12;
            this.buy.Text = "نسبه الخصم";
            this.buy.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.buy.OnValueChanged += new System.EventHandler(this.buy_OnValueChanged);
            // 
            // sell
            // 
            this.sell.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sell.BackColor = System.Drawing.Color.WhiteSmoke;
            this.sell.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.sell.Font = new System.Drawing.Font("splart-h-amana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.sell.ForeColor = System.Drawing.Color.Maroon;
            this.sell.HintForeColor = System.Drawing.Color.Empty;
            this.sell.HintText = "";
            this.sell.isPassword = false;
            this.sell.LineFocusedColor = System.Drawing.Color.Maroon;
            this.sell.LineIdleColor = System.Drawing.Color.Gainsboro;
            this.sell.LineMouseHoverColor = System.Drawing.Color.Maroon;
            this.sell.LineThickness = 4;
            this.sell.Location = new System.Drawing.Point(304, 198);
            this.sell.Margin = new System.Windows.Forms.Padding(4);
            this.sell.Name = "sell";
            this.sell.Size = new System.Drawing.Size(177, 42);
            this.sell.TabIndex = 13;
            this.sell.Text = "سعر البيع";
            this.sell.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.sell.OnValueChanged += new System.EventHandler(this.sell_OnValueChanged);
            // 
            // Quantity
            // 
            this.Quantity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Quantity.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Quantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Quantity.Font = new System.Drawing.Font("splart-h-amana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Quantity.ForeColor = System.Drawing.Color.Maroon;
            this.Quantity.HintForeColor = System.Drawing.Color.Empty;
            this.Quantity.HintText = "";
            this.Quantity.isPassword = false;
            this.Quantity.LineFocusedColor = System.Drawing.Color.Maroon;
            this.Quantity.LineIdleColor = System.Drawing.Color.Gainsboro;
            this.Quantity.LineMouseHoverColor = System.Drawing.Color.Maroon;
            this.Quantity.LineThickness = 4;
            this.Quantity.Location = new System.Drawing.Point(304, 248);
            this.Quantity.Margin = new System.Windows.Forms.Padding(4);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(177, 42);
            this.Quantity.TabIndex = 14;
            this.Quantity.Text = "عدد العلب";
            this.Quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Quantity.OnValueChanged += new System.EventHandler(this.Quantity_OnValueChanged);
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
            this.dgp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgp.DoubleBuffered = true;
            this.dgp.EnableHeadersVisualStyles = false;
            this.dgp.GridColor = System.Drawing.SystemColors.Control;
            this.dgp.HeaderBgColor = System.Drawing.Color.Maroon;
            this.dgp.HeaderForeColor = System.Drawing.Color.WhiteSmoke;
            this.dgp.Location = new System.Drawing.Point(501, 40);
            this.dgp.MultiSelect = false;
            this.dgp.Name = "dgp";
            this.dgp.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgp.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dgp.Size = new System.Drawing.Size(859, 719);
            this.dgp.TabIndex = 16;
            this.dgp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            this.dgp.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
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
            this.bunifuThinButton23.ButtonText = "حذف";
            this.bunifuThinButton23.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton23.Font = new System.Drawing.Font("splart-h-amana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuThinButton23.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuThinButton23.IdleBorderThickness = 1;
            this.bunifuThinButton23.IdleCornerRadius = 20;
            this.bunifuThinButton23.IdleFillColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuThinButton23.IdleForecolor = System.Drawing.Color.Maroon;
            this.bunifuThinButton23.IdleLineColor = System.Drawing.Color.Maroon;
            this.bunifuThinButton23.Location = new System.Drawing.Point(263, 435);
            this.bunifuThinButton23.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.bunifuThinButton23.Name = "bunifuThinButton23";
            this.bunifuThinButton23.Size = new System.Drawing.Size(151, 45);
            this.bunifuThinButton23.TabIndex = 19;
            this.bunifuThinButton23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton23.Click += new System.EventHandler(this.bunifuThinButton23_Click);
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
            this.bunifuThinButton24.ButtonText = "تعديل";
            this.bunifuThinButton24.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton24.Font = new System.Drawing.Font("splart-h-amana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuThinButton24.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuThinButton24.IdleBorderThickness = 1;
            this.bunifuThinButton24.IdleCornerRadius = 20;
            this.bunifuThinButton24.IdleFillColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuThinButton24.IdleForecolor = System.Drawing.Color.Maroon;
            this.bunifuThinButton24.IdleLineColor = System.Drawing.Color.Maroon;
            this.bunifuThinButton24.Location = new System.Drawing.Point(263, 380);
            this.bunifuThinButton24.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.bunifuThinButton24.Name = "bunifuThinButton24";
            this.bunifuThinButton24.Size = new System.Drawing.Size(151, 45);
            this.bunifuThinButton24.TabIndex = 20;
            this.bunifuThinButton24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton24.Click += new System.EventHandler(this.bunifuThinButton24_Click);
            // 
            // combany
            // 
            this.combany.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.combany.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combany.FormattingEnabled = true;
            this.combany.Location = new System.Drawing.Point(37, 247);
            this.combany.Name = "combany";
            this.combany.Size = new System.Drawing.Size(190, 24);
            this.combany.TabIndex = 22;
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
            this.bunifuThinButton25.ButtonText = "تحديث";
            this.bunifuThinButton25.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton25.Font = new System.Drawing.Font("splart-h-amana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuThinButton25.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuThinButton25.IdleBorderThickness = 1;
            this.bunifuThinButton25.IdleCornerRadius = 20;
            this.bunifuThinButton25.IdleFillColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuThinButton25.IdleForecolor = System.Drawing.Color.Maroon;
            this.bunifuThinButton25.IdleLineColor = System.Drawing.Color.Maroon;
            this.bunifuThinButton25.Location = new System.Drawing.Point(91, 435);
            this.bunifuThinButton25.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.bunifuThinButton25.Name = "bunifuThinButton25";
            this.bunifuThinButton25.Size = new System.Drawing.Size(151, 45);
            this.bunifuThinButton25.TabIndex = 23;
            this.bunifuThinButton25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton25.Click += new System.EventHandler(this.bunifuThinButton25_Click);
            // 
            // id
            // 
            this.id.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.id.BackColor = System.Drawing.Color.WhiteSmoke;
            this.id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.id.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.id.ForeColor = System.Drawing.Color.Maroon;
            this.id.HintForeColor = System.Drawing.Color.Empty;
            this.id.HintText = "";
            this.id.isPassword = false;
            this.id.LineFocusedColor = System.Drawing.Color.Maroon;
            this.id.LineIdleColor = System.Drawing.Color.Gainsboro;
            this.id.LineMouseHoverColor = System.Drawing.Color.Maroon;
            this.id.LineThickness = 3;
            this.id.Location = new System.Drawing.Point(39, 111);
            this.id.Margin = new System.Windows.Forms.Padding(4);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(189, 29);
            this.id.TabIndex = 24;
            this.id.Text = "ID";
            this.id.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.id.OnValueChanged += new System.EventHandler(this.id_OnValueChanged);
            // 
            // BarCode
            // 
            this.BarCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BarCode.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BarCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.BarCode.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.BarCode.ForeColor = System.Drawing.Color.Maroon;
            this.BarCode.HintForeColor = System.Drawing.Color.Empty;
            this.BarCode.HintText = "";
            this.BarCode.isPassword = false;
            this.BarCode.LineFocusedColor = System.Drawing.Color.Maroon;
            this.BarCode.LineIdleColor = System.Drawing.Color.Gainsboro;
            this.BarCode.LineMouseHoverColor = System.Drawing.Color.Maroon;
            this.BarCode.LineThickness = 3;
            this.BarCode.Location = new System.Drawing.Point(38, 278);
            this.BarCode.Margin = new System.Windows.Forms.Padding(4);
            this.BarCode.Name = "BarCode";
            this.BarCode.Size = new System.Drawing.Size(189, 33);
            this.BarCode.TabIndex = 58;
            this.BarCode.Text = "BarCode";
            this.BarCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.bunifuThinButton22.ButtonText = "اضافه";
            this.bunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton22.Font = new System.Drawing.Font("splart-h-amana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuThinButton22.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuThinButton22.IdleBorderThickness = 1;
            this.bunifuThinButton22.IdleCornerRadius = 20;
            this.bunifuThinButton22.IdleFillColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuThinButton22.IdleForecolor = System.Drawing.Color.Maroon;
            this.bunifuThinButton22.IdleLineColor = System.Drawing.Color.Maroon;
            this.bunifuThinButton22.Location = new System.Drawing.Point(91, 380);
            this.bunifuThinButton22.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.bunifuThinButton22.Name = "bunifuThinButton22";
            this.bunifuThinButton22.Size = new System.Drawing.Size(151, 45);
            this.bunifuThinButton22.TabIndex = 59;
            this.bunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton22.Click += new System.EventHandler(this.bunifuThinButton22_Click_1);
            // 
            // bunifuThinButton26
            // 
            this.bunifuThinButton26.ActiveBorderThickness = 1;
            this.bunifuThinButton26.ActiveCornerRadius = 20;
            this.bunifuThinButton26.ActiveFillColor = System.Drawing.Color.Maroon;
            this.bunifuThinButton26.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton26.ActiveLineColor = System.Drawing.Color.Maroon;
            this.bunifuThinButton26.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuThinButton26.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuThinButton26.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton26.BackgroundImage")));
            this.bunifuThinButton26.ButtonText = "الصفحه الرئيسيه";
            this.bunifuThinButton26.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton26.Font = new System.Drawing.Font("splart-h-amana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuThinButton26.ForeColor = System.Drawing.Color.Maroon;
            this.bunifuThinButton26.IdleBorderThickness = 1;
            this.bunifuThinButton26.IdleCornerRadius = 20;
            this.bunifuThinButton26.IdleFillColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuThinButton26.IdleForecolor = System.Drawing.Color.Maroon;
            this.bunifuThinButton26.IdleLineColor = System.Drawing.Color.Maroon;
            this.bunifuThinButton26.Location = new System.Drawing.Point(33, 712);
            this.bunifuThinButton26.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.bunifuThinButton26.Name = "bunifuThinButton26";
            this.bunifuThinButton26.Size = new System.Drawing.Size(154, 47);
            this.bunifuThinButton26.TabIndex = 145;
            this.bunifuThinButton26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton26.Click += new System.EventHandler(this.bunifuThinButton26_Click);
            // 
            // tablet
            // 
            this.tablet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tablet.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tablet.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tablet.Font = new System.Drawing.Font("splart-h-amana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tablet.ForeColor = System.Drawing.Color.Maroon;
            this.tablet.HintForeColor = System.Drawing.Color.Empty;
            this.tablet.HintText = "";
            this.tablet.isPassword = false;
            this.tablet.LineFocusedColor = System.Drawing.Color.Maroon;
            this.tablet.LineIdleColor = System.Drawing.Color.Gainsboro;
            this.tablet.LineMouseHoverColor = System.Drawing.Color.Maroon;
            this.tablet.LineThickness = 4;
            this.tablet.Location = new System.Drawing.Point(304, 298);
            this.tablet.Margin = new System.Windows.Forms.Padding(4);
            this.tablet.Name = "tablet";
            this.tablet.Size = new System.Drawing.Size(177, 42);
            this.tablet.TabIndex = 146;
            this.tablet.Text = "عدد الشرايط في العلبه ";
            this.tablet.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // buying
            // 
            this.buying.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buying.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buying.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.buying.Enabled = false;
            this.buying.Font = new System.Drawing.Font("splart-h-amana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.buying.ForeColor = System.Drawing.Color.Maroon;
            this.buying.HintForeColor = System.Drawing.Color.Empty;
            this.buying.HintText = "";
            this.buying.isPassword = false;
            this.buying.LineFocusedColor = System.Drawing.Color.Maroon;
            this.buying.LineIdleColor = System.Drawing.Color.Gainsboro;
            this.buying.LineMouseHoverColor = System.Drawing.Color.Maroon;
            this.buying.LineThickness = 4;
            this.buying.Location = new System.Drawing.Point(304, 98);
            this.buying.Margin = new System.Windows.Forms.Padding(4);
            this.buying.Name = "buying";
            this.buying.Size = new System.Drawing.Size(177, 42);
            this.buying.TabIndex = 147;
            this.buying.Text = "سعر الشراء";
            this.buying.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.buying.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox1_OnValueChanged);
            // 
            // dt
            // 
            this.dt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dt.CalendarForeColor = System.Drawing.Color.Maroon;
            this.dt.CalendarTitleForeColor = System.Drawing.Color.Maroon;
            this.dt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt.Location = new System.Drawing.Point(80, 205);
            this.dt.Name = "dt";
            this.dt.Size = new System.Drawing.Size(148, 29);
            this.dt.TabIndex = 148;
            this.dt.Value = new System.DateTime(2022, 5, 27, 6, 13, 21, 0);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("splart-h-amana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(456, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 32);
            this.label1.TabIndex = 149;
            this.label1.Text = "%";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("splart-h-amana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(28, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 25);
            this.label2.TabIndex = 150;
            this.label2.Text = "EXP";
            // 
            // name
            // 
            this.name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.name.BackColor = System.Drawing.Color.WhiteSmoke;
            this.name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.name.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.name.ForeColor = System.Drawing.Color.Maroon;
            this.name.HintForeColor = System.Drawing.Color.Empty;
            this.name.HintText = "";
            this.name.isPassword = false;
            this.name.LineFocusedColor = System.Drawing.Color.Maroon;
            this.name.LineIdleColor = System.Drawing.Color.Gainsboro;
            this.name.LineMouseHoverColor = System.Drawing.Color.Maroon;
            this.name.LineThickness = 3;
            this.name.Location = new System.Drawing.Point(172, 539);
            this.name.Margin = new System.Windows.Forms.Padding(4);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(189, 29);
            this.name.TabIndex = 151;
            this.name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.name.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox1_OnValueChanged_1);
            // 
            // medicinform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dt);
            this.Controls.Add(this.buying);
            this.Controls.Add(this.tablet);
            this.Controls.Add(this.bunifuThinButton26);
            this.Controls.Add(this.bunifuThinButton22);
            this.Controls.Add(this.BarCode);
            this.Controls.Add(this.id);
            this.Controls.Add(this.bunifuThinButton25);
            this.Controls.Add(this.combany);
            this.Controls.Add(this.bunifuThinButton24);
            this.Controls.Add(this.bunifuThinButton23);
            this.Controls.Add(this.dgp);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.sell);
            this.Controls.Add(this.buy);
            this.Controls.Add(this.med_name);
            this.Controls.Add(this.Medicin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "medicinform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "medicinform";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.medicinform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Medicin;
        private Bunifu.Framework.UI.BunifuMaterialTextbox med_name;
        private Bunifu.Framework.UI.BunifuMaterialTextbox buy;
        private Bunifu.Framework.UI.BunifuMaterialTextbox sell;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Quantity;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton23;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton24;
        private System.Windows.Forms.ComboBox combany;
        public Bunifu.Framework.UI.BunifuCustomDataGrid dgp;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton25;
        private Bunifu.Framework.UI.BunifuMaterialTextbox id;
        private Bunifu.Framework.UI.BunifuMaterialTextbox BarCode;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton22;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton26;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tablet;
        private Bunifu.Framework.UI.BunifuMaterialTextbox buying;
        private System.Windows.Forms.DateTimePicker dt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox name;
    }
}