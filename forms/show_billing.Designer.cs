
namespace pharmacy.forms
{
    partial class show_billing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(show_billing));
            this.dgp = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.id = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.cust = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.Total_Amount = new System.Windows.Forms.Label();
            this.bunifuThinButton23 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bunifuThinButton24 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton25 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.date1 = new System.Windows.Forms.DateTimePicker();
            this.Date = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgp)).BeginInit();
            this.SuspendLayout();
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
            this.dgp.HeaderBgColor = System.Drawing.Color.Maroon;
            this.dgp.HeaderForeColor = System.Drawing.Color.WhiteSmoke;
            this.dgp.Location = new System.Drawing.Point(463, 50);
            this.dgp.MultiSelect = false;
            this.dgp.Name = "dgp";
            this.dgp.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgp.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dgp.Size = new System.Drawing.Size(873, 649);
            this.dgp.TabIndex = 55;
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
            this.id.Location = new System.Drawing.Point(64, 281);
            this.id.Margin = new System.Windows.Forms.Padding(4);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(120, 45);
            this.id.TabIndex = 56;
            this.id.Text = "id";
            this.id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.id.OnValueChanged += new System.EventHandler(this.id_OnValueChanged);
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
            this.bunifuThinButton22.ButtonText = "تحديث";
            this.bunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton22.Font = new System.Drawing.Font("splart-h-amana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuThinButton22.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuThinButton22.IdleBorderThickness = 1;
            this.bunifuThinButton22.IdleCornerRadius = 20;
            this.bunifuThinButton22.IdleFillColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuThinButton22.IdleForecolor = System.Drawing.Color.Maroon;
            this.bunifuThinButton22.IdleLineColor = System.Drawing.Color.Maroon;
            this.bunifuThinButton22.Location = new System.Drawing.Point(144, 519);
            this.bunifuThinButton22.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.bunifuThinButton22.Name = "bunifuThinButton22";
            this.bunifuThinButton22.Size = new System.Drawing.Size(120, 45);
            this.bunifuThinButton22.TabIndex = 59;
            this.bunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton22.Click += new System.EventHandler(this.bunifuThinButton22_Click);
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
            this.bunifuThinButton21.ButtonText = "حذف";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("splart-h-amana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.Maroon;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.Maroon;
            this.bunifuThinButton21.Location = new System.Drawing.Point(144, 464);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(120, 45);
            this.bunifuThinButton21.TabIndex = 61;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click_1);
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
            this.cust.Location = new System.Drawing.Point(230, 281);
            this.cust.Margin = new System.Windows.Forms.Padding(4);
            this.cust.Name = "cust";
            this.cust.Size = new System.Drawing.Size(120, 45);
            this.cust.TabIndex = 62;
            this.cust.Text = "رقم العميل";
            this.cust.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cust.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox1_OnValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("splart-h-amana", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(96, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 64);
            this.label1.TabIndex = 63;
            this.label1.Text = "جميع الفواتير";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Total_Amount
            // 
            this.Total_Amount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Total_Amount.AutoSize = true;
            this.Total_Amount.Font = new System.Drawing.Font("splart-h-amana", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Total_Amount.ForeColor = System.Drawing.Color.Maroon;
            this.Total_Amount.Location = new System.Drawing.Point(85, 581);
            this.Total_Amount.Name = "Total_Amount";
            this.Total_Amount.Size = new System.Drawing.Size(208, 49);
            this.Total_Amount.TabIndex = 65;
            this.Total_Amount.Text = "اجمالي التكلفه";
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
            this.bunifuThinButton23.ButtonText = "بحث";
            this.bunifuThinButton23.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton23.Font = new System.Drawing.Font("splart-h-amana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuThinButton23.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuThinButton23.IdleBorderThickness = 1;
            this.bunifuThinButton23.IdleCornerRadius = 20;
            this.bunifuThinButton23.IdleFillColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuThinButton23.IdleForecolor = System.Drawing.Color.Maroon;
            this.bunifuThinButton23.IdleLineColor = System.Drawing.Color.Maroon;
            this.bunifuThinButton23.Location = new System.Drawing.Point(144, 409);
            this.bunifuThinButton23.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.bunifuThinButton23.Name = "bunifuThinButton23";
            this.bunifuThinButton23.Size = new System.Drawing.Size(120, 45);
            this.bunifuThinButton23.TabIndex = 67;
            this.bunifuThinButton23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton23.Click += new System.EventHandler(this.bunifuThinButton23_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("splart-h-amana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(104, 342);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 20);
            this.label2.TabIndex = 68;
            this.label2.Text = "من";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("splart-h-amana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(273, 342);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 20);
            this.label3.TabIndex = 69;
            this.label3.Text = "الى";
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
            this.bunifuThinButton24.ButtonText = "رجوع";
            this.bunifuThinButton24.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton24.Font = new System.Drawing.Font("splart-h-amana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuThinButton24.ForeColor = System.Drawing.Color.Maroon;
            this.bunifuThinButton24.IdleBorderThickness = 1;
            this.bunifuThinButton24.IdleCornerRadius = 20;
            this.bunifuThinButton24.IdleFillColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuThinButton24.IdleForecolor = System.Drawing.Color.Maroon;
            this.bunifuThinButton24.IdleLineColor = System.Drawing.Color.Maroon;
            this.bunifuThinButton24.Location = new System.Drawing.Point(239, 660);
            this.bunifuThinButton24.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.bunifuThinButton24.Name = "bunifuThinButton24";
            this.bunifuThinButton24.Size = new System.Drawing.Size(144, 54);
            this.bunifuThinButton24.TabIndex = 140;
            this.bunifuThinButton24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton24.Click += new System.EventHandler(this.bunifuThinButton24_Click);
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
            this.bunifuThinButton25.ButtonText = "الصفحه الرئيسيه";
            this.bunifuThinButton25.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton25.Font = new System.Drawing.Font("splart-h-amana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuThinButton25.ForeColor = System.Drawing.Color.Maroon;
            this.bunifuThinButton25.IdleBorderThickness = 1;
            this.bunifuThinButton25.IdleCornerRadius = 20;
            this.bunifuThinButton25.IdleFillColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuThinButton25.IdleForecolor = System.Drawing.Color.Maroon;
            this.bunifuThinButton25.IdleLineColor = System.Drawing.Color.Maroon;
            this.bunifuThinButton25.Location = new System.Drawing.Point(33, 660);
            this.bunifuThinButton25.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.bunifuThinButton25.Name = "bunifuThinButton25";
            this.bunifuThinButton25.Size = new System.Drawing.Size(192, 54);
            this.bunifuThinButton25.TabIndex = 139;
            this.bunifuThinButton25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton25.Click += new System.EventHandler(this.bunifuThinButton25_Click);
            // 
            // date1
            // 
            this.date1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.date1.CalendarForeColor = System.Drawing.Color.Maroon;
            this.date1.CalendarTitleForeColor = System.Drawing.Color.Maroon;
            this.date1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date1.Location = new System.Drawing.Point(216, 372);
            this.date1.Name = "date1";
            this.date1.Size = new System.Drawing.Size(148, 29);
            this.date1.TabIndex = 156;
            this.date1.Value = new System.DateTime(2022, 5, 27, 6, 13, 21, 0);
            // 
            // Date
            // 
            this.Date.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Date.CalendarForeColor = System.Drawing.Color.Maroon;
            this.Date.CalendarTitleForeColor = System.Drawing.Color.Maroon;
            this.Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Date.Location = new System.Drawing.Point(36, 372);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(148, 29);
            this.Date.TabIndex = 157;
            this.Date.Value = new System.DateTime(2022, 5, 27, 6, 13, 21, 0);
            // 
            // show_billing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.date1);
            this.Controls.Add(this.bunifuThinButton24);
            this.Controls.Add(this.bunifuThinButton25);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bunifuThinButton23);
            this.Controls.Add(this.Total_Amount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cust);
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.bunifuThinButton22);
            this.Controls.Add(this.id);
            this.Controls.Add(this.dgp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "show_billing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.show_billing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Bunifu.Framework.UI.BunifuCustomDataGrid dgp;
        private Bunifu.Framework.UI.BunifuMaterialTextbox id;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton22;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private Bunifu.Framework.UI.BunifuMaterialTextbox cust;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Total_Amount;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton23;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton24;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton25;
        private System.Windows.Forms.DateTimePicker date1;
        private System.Windows.Forms.DateTimePicker Date;
    }
}