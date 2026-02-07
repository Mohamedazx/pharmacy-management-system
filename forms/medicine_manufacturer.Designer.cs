
namespace pharmacy.forms
{
    partial class medicine_manufacturer
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(medicine_manufacturer));
            this.mob = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.dgv = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.bunifuThinButton25 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton24 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton23 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.id = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Adress = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.name = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Medicin = new System.Windows.Forms.Label();
            this.bunifuThinButton26 = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
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
            this.mob.Location = new System.Drawing.Point(254, 377);
            this.mob.Margin = new System.Windows.Forms.Padding(4);
            this.mob.Name = "mob";
            this.mob.Size = new System.Drawing.Size(190, 42);
            this.mob.TabIndex = 55;
            this.mob.Text = "التليفون";
            this.mob.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.DoubleBuffered = true;
            this.dgv.EnableHeadersVisualStyles = false;
            this.dgv.HeaderBgColor = System.Drawing.Color.Maroon;
            this.dgv.HeaderForeColor = System.Drawing.Color.WhiteSmoke;
            this.dgv.Location = new System.Drawing.Point(732, 114);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dgv.Size = new System.Drawing.Size(432, 560);
            this.dgv.TabIndex = 54;
            this.dgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellDoubleClick);
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
            this.bunifuThinButton25.Location = new System.Drawing.Point(188, 510);
            this.bunifuThinButton25.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.bunifuThinButton25.Name = "bunifuThinButton25";
            this.bunifuThinButton25.Size = new System.Drawing.Size(151, 45);
            this.bunifuThinButton25.TabIndex = 52;
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
            this.bunifuThinButton24.Location = new System.Drawing.Point(360, 455);
            this.bunifuThinButton24.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.bunifuThinButton24.Name = "bunifuThinButton24";
            this.bunifuThinButton24.Size = new System.Drawing.Size(151, 45);
            this.bunifuThinButton24.TabIndex = 51;
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
            this.bunifuThinButton23.Location = new System.Drawing.Point(360, 510);
            this.bunifuThinButton23.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.bunifuThinButton23.Name = "bunifuThinButton23";
            this.bunifuThinButton23.Size = new System.Drawing.Size(151, 45);
            this.bunifuThinButton23.TabIndex = 50;
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
            this.bunifuThinButton21.ButtonText = "اضافه";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("splart-h-amana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.Maroon;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.Maroon;
            this.bunifuThinButton21.Location = new System.Drawing.Point(188, 455);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(151, 45);
            this.bunifuThinButton21.TabIndex = 48;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
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
            this.id.Location = new System.Drawing.Point(255, 162);
            this.id.Margin = new System.Windows.Forms.Padding(4);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(189, 29);
            this.id.TabIndex = 47;
            this.id.Text = "id";
            this.id.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Adress
            // 
            this.Adress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Adress.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Adress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Adress.Font = new System.Drawing.Font("splart-h-amana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Adress.ForeColor = System.Drawing.Color.Maroon;
            this.Adress.HintForeColor = System.Drawing.Color.Empty;
            this.Adress.HintText = "";
            this.Adress.isPassword = false;
            this.Adress.LineFocusedColor = System.Drawing.Color.Maroon;
            this.Adress.LineIdleColor = System.Drawing.Color.Gainsboro;
            this.Adress.LineMouseHoverColor = System.Drawing.Color.Maroon;
            this.Adress.LineThickness = 4;
            this.Adress.Location = new System.Drawing.Point(254, 300);
            this.Adress.Margin = new System.Windows.Forms.Padding(4);
            this.Adress.Name = "Adress";
            this.Adress.Size = new System.Drawing.Size(190, 42);
            this.Adress.TabIndex = 45;
            this.Adress.Text = "الموقع";
            this.Adress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Adress.OnValueChanged += new System.EventHandler(this.Adress_OnValueChanged);
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
            this.name.Location = new System.Drawing.Point(255, 226);
            this.name.Margin = new System.Windows.Forms.Padding(4);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(189, 42);
            this.name.TabIndex = 42;
            this.name.Text = "الاسم ";
            this.name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Medicin
            // 
            this.Medicin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Medicin.AutoSize = true;
            this.Medicin.Font = new System.Drawing.Font("splart-h-amana", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Medicin.ForeColor = System.Drawing.Color.Maroon;
            this.Medicin.Location = new System.Drawing.Point(170, 58);
            this.Medicin.Name = "Medicin";
            this.Medicin.Size = new System.Drawing.Size(341, 64);
            this.Medicin.TabIndex = 41;
            this.Medicin.Text = "اضافه شركه مورده";
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
            this.bunifuThinButton26.Location = new System.Drawing.Point(45, 691);
            this.bunifuThinButton26.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.bunifuThinButton26.Name = "bunifuThinButton26";
            this.bunifuThinButton26.Size = new System.Drawing.Size(154, 47);
            this.bunifuThinButton26.TabIndex = 143;
            this.bunifuThinButton26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton26.Click += new System.EventHandler(this.bunifuThinButton26_Click);
            // 
            // medicine_manufacturer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.bunifuThinButton26);
            this.Controls.Add(this.mob);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.bunifuThinButton25);
            this.Controls.Add(this.bunifuThinButton24);
            this.Controls.Add(this.bunifuThinButton23);
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.id);
            this.Controls.Add(this.Adress);
            this.Controls.Add(this.name);
            this.Controls.Add(this.Medicin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "medicine_manufacturer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "medicine_manufacturer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.medicine_manufacturer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMaterialTextbox mob;
        public Bunifu.Framework.UI.BunifuCustomDataGrid dgv;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton25;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton24;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton23;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private Bunifu.Framework.UI.BunifuMaterialTextbox id;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Adress;
        private Bunifu.Framework.UI.BunifuMaterialTextbox name;
        private System.Windows.Forms.Label Medicin;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton26;
    }
}