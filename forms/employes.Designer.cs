
namespace pharmacy.forms
{
    partial class employes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(employes));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.id = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.sex = new System.Windows.Forms.ComboBox();
            this.card_number = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Age = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.salary = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.name = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Medicin = new System.Windows.Forms.Label();
            this.bunifuThinButton25 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton24 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton23 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.dgv = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.mob = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton26 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.dt = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
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
            this.id.Location = new System.Drawing.Point(39, 148);
            this.id.Margin = new System.Windows.Forms.Padding(4);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(189, 29);
            this.id.TabIndex = 32;
            this.id.Text = "id";
            this.id.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // sex
            // 
            this.sex.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sex.BackColor = System.Drawing.Color.WhiteSmoke;
            this.sex.ForeColor = System.Drawing.Color.Maroon;
            this.sex.FormattingEnabled = true;
            this.sex.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.sex.Location = new System.Drawing.Point(298, 276);
            this.sex.Name = "sex";
            this.sex.Size = new System.Drawing.Size(177, 21);
            this.sex.TabIndex = 31;
            this.sex.Text = "النوع";
            this.sex.SelectedIndexChanged += new System.EventHandler(this.male_SelectedIndexChanged);
            // 
            // card_number
            // 
            this.card_number.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.card_number.BackColor = System.Drawing.Color.WhiteSmoke;
            this.card_number.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.card_number.Font = new System.Drawing.Font("splart-h-amana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.card_number.ForeColor = System.Drawing.Color.Maroon;
            this.card_number.HintForeColor = System.Drawing.Color.Empty;
            this.card_number.HintText = "";
            this.card_number.isPassword = false;
            this.card_number.LineFocusedColor = System.Drawing.Color.Maroon;
            this.card_number.LineIdleColor = System.Drawing.Color.Gainsboro;
            this.card_number.LineMouseHoverColor = System.Drawing.Color.Maroon;
            this.card_number.LineThickness = 4;
            this.card_number.Location = new System.Drawing.Point(38, 224);
            this.card_number.Margin = new System.Windows.Forms.Padding(4);
            this.card_number.Name = "card_number";
            this.card_number.Size = new System.Drawing.Size(190, 42);
            this.card_number.TabIndex = 29;
            this.card_number.Text = "الرقم القومي";
            this.card_number.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Age
            // 
            this.Age.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Age.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Age.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Age.Font = new System.Drawing.Font("splart-h-amana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Age.ForeColor = System.Drawing.Color.Maroon;
            this.Age.HintForeColor = System.Drawing.Color.Empty;
            this.Age.HintText = "";
            this.Age.isPassword = false;
            this.Age.LineFocusedColor = System.Drawing.Color.Maroon;
            this.Age.LineIdleColor = System.Drawing.Color.Gainsboro;
            this.Age.LineMouseHoverColor = System.Drawing.Color.Maroon;
            this.Age.LineThickness = 4;
            this.Age.Location = new System.Drawing.Point(298, 224);
            this.Age.Margin = new System.Windows.Forms.Padding(4);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(177, 42);
            this.Age.TabIndex = 28;
            this.Age.Text = "العمر";
            this.Age.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // salary
            // 
            this.salary.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.salary.BackColor = System.Drawing.Color.WhiteSmoke;
            this.salary.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.salary.Font = new System.Drawing.Font("splart-h-amana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.salary.ForeColor = System.Drawing.Color.Maroon;
            this.salary.HintForeColor = System.Drawing.Color.Empty;
            this.salary.HintText = "";
            this.salary.isPassword = false;
            this.salary.LineFocusedColor = System.Drawing.Color.Maroon;
            this.salary.LineIdleColor = System.Drawing.Color.Gainsboro;
            this.salary.LineMouseHoverColor = System.Drawing.Color.Maroon;
            this.salary.LineThickness = 4;
            this.salary.Location = new System.Drawing.Point(298, 183);
            this.salary.Margin = new System.Windows.Forms.Padding(4);
            this.salary.Name = "salary";
            this.salary.Size = new System.Drawing.Size(177, 42);
            this.salary.TabIndex = 27;
            this.salary.Text = "سعر الساعه";
            this.salary.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // name
            // 
            this.name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.name.BackColor = System.Drawing.Color.WhiteSmoke;
            this.name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.name.Font = new System.Drawing.Font("splart-h-amana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.name.ForeColor = System.Drawing.Color.Maroon;
            this.name.HintForeColor = System.Drawing.Color.Empty;
            this.name.HintText = "";
            this.name.isPassword = false;
            this.name.LineFocusedColor = System.Drawing.Color.Maroon;
            this.name.LineIdleColor = System.Drawing.Color.Gainsboro;
            this.name.LineMouseHoverColor = System.Drawing.Color.Maroon;
            this.name.LineThickness = 4;
            this.name.Location = new System.Drawing.Point(39, 184);
            this.name.Margin = new System.Windows.Forms.Padding(4);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(189, 42);
            this.name.TabIndex = 26;
            this.name.Text = "الاسم";
            this.name.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Medicin
            // 
            this.Medicin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Medicin.AutoSize = true;
            this.Medicin.Font = new System.Drawing.Font("splart-h-amana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Medicin.ForeColor = System.Drawing.Color.Maroon;
            this.Medicin.Location = new System.Drawing.Point(197, 50);
            this.Medicin.Name = "Medicin";
            this.Medicin.Size = new System.Drawing.Size(121, 43);
            this.Medicin.TabIndex = 25;
            this.Medicin.Text = "الموظفين";
            this.Medicin.Click += new System.EventHandler(this.Medicin_Click);
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
            this.bunifuThinButton25.Location = new System.Drawing.Point(99, 493);
            this.bunifuThinButton25.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.bunifuThinButton25.Name = "bunifuThinButton25";
            this.bunifuThinButton25.Size = new System.Drawing.Size(151, 45);
            this.bunifuThinButton25.TabIndex = 37;
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
            this.bunifuThinButton24.ButtonText = "تعديل";
            this.bunifuThinButton24.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton24.Font = new System.Drawing.Font("splart-h-amana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuThinButton24.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuThinButton24.IdleBorderThickness = 1;
            this.bunifuThinButton24.IdleCornerRadius = 20;
            this.bunifuThinButton24.IdleFillColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuThinButton24.IdleForecolor = System.Drawing.Color.Maroon;
            this.bunifuThinButton24.IdleLineColor = System.Drawing.Color.Maroon;
            this.bunifuThinButton24.Location = new System.Drawing.Point(271, 438);
            this.bunifuThinButton24.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.bunifuThinButton24.Name = "bunifuThinButton24";
            this.bunifuThinButton24.Size = new System.Drawing.Size(151, 45);
            this.bunifuThinButton24.TabIndex = 36;
            this.bunifuThinButton24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton24.Click += new System.EventHandler(this.bunifuThinButton24_Click);
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
            this.bunifuThinButton23.Location = new System.Drawing.Point(271, 493);
            this.bunifuThinButton23.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.bunifuThinButton23.Name = "bunifuThinButton23";
            this.bunifuThinButton23.Size = new System.Drawing.Size(151, 45);
            this.bunifuThinButton23.TabIndex = 35;
            this.bunifuThinButton23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton23.Click += new System.EventHandler(this.bunifuThinButton23_Click);
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
            this.bunifuThinButton21.ButtonText = "اضافه ";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("splart-h-amana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.Maroon;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.Maroon;
            this.bunifuThinButton21.Location = new System.Drawing.Point(99, 438);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(151, 45);
            this.bunifuThinButton21.TabIndex = 33;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.DoubleBuffered = true;
            this.dgv.EnableHeadersVisualStyles = false;
            this.dgv.HeaderBgColor = System.Drawing.Color.Maroon;
            this.dgv.HeaderForeColor = System.Drawing.Color.WhiteSmoke;
            this.dgv.Location = new System.Drawing.Point(520, 50);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dgv.Size = new System.Drawing.Size(841, 698);
            this.dgv.TabIndex = 39;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            this.dgv.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_CellMouseDoubleClick);
            // 
            // mob
            // 
            this.mob.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mob.BackColor = System.Drawing.Color.WhiteSmoke;
            this.mob.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mob.Font = new System.Drawing.Font("splart-h-amana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.mob.ForeColor = System.Drawing.Color.Maroon;
            this.mob.HintForeColor = System.Drawing.Color.Empty;
            this.mob.HintText = "";
            this.mob.isPassword = false;
            this.mob.LineFocusedColor = System.Drawing.Color.Maroon;
            this.mob.LineIdleColor = System.Drawing.Color.Gainsboro;
            this.mob.LineMouseHoverColor = System.Drawing.Color.Maroon;
            this.mob.LineThickness = 4;
            this.mob.Location = new System.Drawing.Point(37, 264);
            this.mob.Margin = new System.Windows.Forms.Padding(4);
            this.mob.Name = "mob";
            this.mob.Size = new System.Drawing.Size(190, 42);
            this.mob.TabIndex = 40;
            this.mob.Text = "الموبايل";
            this.mob.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            this.bunifuThinButton22.ButtonText = "رجوع";
            this.bunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton22.Font = new System.Drawing.Font("splart-h-amana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuThinButton22.ForeColor = System.Drawing.Color.Maroon;
            this.bunifuThinButton22.IdleBorderThickness = 1;
            this.bunifuThinButton22.IdleCornerRadius = 20;
            this.bunifuThinButton22.IdleFillColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuThinButton22.IdleForecolor = System.Drawing.Color.Maroon;
            this.bunifuThinButton22.IdleLineColor = System.Drawing.Color.Maroon;
            this.bunifuThinButton22.Location = new System.Drawing.Point(261, 667);
            this.bunifuThinButton22.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.bunifuThinButton22.Name = "bunifuThinButton22";
            this.bunifuThinButton22.Size = new System.Drawing.Size(144, 54);
            this.bunifuThinButton22.TabIndex = 140;
            this.bunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton22.Click += new System.EventHandler(this.bunifuThinButton22_Click);
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
            this.bunifuThinButton26.Location = new System.Drawing.Point(64, 667);
            this.bunifuThinButton26.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.bunifuThinButton26.Name = "bunifuThinButton26";
            this.bunifuThinButton26.Size = new System.Drawing.Size(183, 54);
            this.bunifuThinButton26.TabIndex = 139;
            this.bunifuThinButton26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton26.Click += new System.EventHandler(this.bunifuThinButton26_Click);
            // 
            // dt
            // 
            this.dt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dt.CalendarForeColor = System.Drawing.Color.Maroon;
            this.dt.CalendarTitleForeColor = System.Drawing.Color.Maroon;
            this.dt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt.Location = new System.Drawing.Point(54, 313);
            this.dt.Name = "dt";
            this.dt.Size = new System.Drawing.Size(148, 29);
            this.dt.TabIndex = 151;
            this.dt.Value = new System.DateTime(2022, 5, 27, 6, 13, 21, 0);
            // 
            // employes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.dt);
            this.Controls.Add(this.bunifuThinButton22);
            this.Controls.Add(this.bunifuThinButton26);
            this.Controls.Add(this.mob);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.bunifuThinButton25);
            this.Controls.Add(this.bunifuThinButton24);
            this.Controls.Add(this.bunifuThinButton23);
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.id);
            this.Controls.Add(this.sex);
            this.Controls.Add(this.card_number);
            this.Controls.Add(this.Age);
            this.Controls.Add(this.salary);
            this.Controls.Add(this.name);
            this.Controls.Add(this.Medicin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "employes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "employes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.employes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMaterialTextbox id;
        private System.Windows.Forms.ComboBox sex;
        private Bunifu.Framework.UI.BunifuMaterialTextbox card_number;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Age;
        private Bunifu.Framework.UI.BunifuMaterialTextbox salary;
        private Bunifu.Framework.UI.BunifuMaterialTextbox name;
        private System.Windows.Forms.Label Medicin;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton25;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton24;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton23;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        public Bunifu.Framework.UI.BunifuCustomDataGrid dgv;
        private Bunifu.Framework.UI.BunifuMaterialTextbox mob;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton22;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton26;
        private System.Windows.Forms.DateTimePicker dt;
    }
}