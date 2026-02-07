
namespace pharmacy.forms
{
    partial class serch_outs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(serch_outs));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.to_h = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.comboBox_state = new System.Windows.Forms.ComboBox();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.hor_cost = new System.Windows.Forms.Label();
            this.bunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.salary_id = new System.Windows.Forms.Label();
            this.bunifuThinButton25 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton24 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.salary = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.date2 = new System.Windows.Forms.DateTimePicker();
            this.date1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("splart-h-amana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(72, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "من ";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("splart-h-amana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(72, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "الى";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // to_h
            // 
            this.to_h.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.to_h.AutoSize = true;
            this.to_h.Font = new System.Drawing.Font("splart-h-amana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.to_h.ForeColor = System.Drawing.Color.Maroon;
            this.to_h.Location = new System.Drawing.Point(124, 428);
            this.to_h.Name = "to_h";
            this.to_h.Size = new System.Drawing.Size(22, 32);
            this.to_h.TabIndex = 6;
            this.to_h.Text = "0";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("splart-h-amana", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(115, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 64);
            this.label3.TabIndex = 61;
            this.label3.Text = "بحث الانصراف";
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
            this.dgv.Location = new System.Drawing.Point(478, 106);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dgv.Size = new System.Drawing.Size(845, 577);
            this.dgv.TabIndex = 77;
            // 
            // comboBox_state
            // 
            this.comboBox_state.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox_state.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_state.ForeColor = System.Drawing.Color.Maroon;
            this.comboBox_state.FormattingEnabled = true;
            this.comboBox_state.Location = new System.Drawing.Point(119, 272);
            this.comboBox_state.Name = "comboBox_state";
            this.comboBox_state.Size = new System.Drawing.Size(229, 28);
            this.comboBox_state.TabIndex = 87;
            this.comboBox_state.Text = "موظف";
            this.comboBox_state.SelectedIndexChanged += new System.EventHandler(this.comboBox_state_SelectedIndexChanged);
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
            this.bunifuThinButton21.ButtonText = "بحث";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("splart-h-amana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.Maroon;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.Maroon;
            this.bunifuThinButton21.Location = new System.Drawing.Point(174, 334);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(118, 45);
            this.bunifuThinButton21.TabIndex = 90;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // hor_cost
            // 
            this.hor_cost.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.hor_cost.AutoSize = true;
            this.hor_cost.Font = new System.Drawing.Font("splart-h-amana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.hor_cost.ForeColor = System.Drawing.Color.Maroon;
            this.hor_cost.Location = new System.Drawing.Point(124, 488);
            this.hor_cost.Name = "hor_cost";
            this.hor_cost.Size = new System.Drawing.Size(22, 32);
            this.hor_cost.TabIndex = 92;
            this.hor_cost.Text = "0";
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
            this.bunifuThinButton22.ButtonText = "صرف المرتب";
            this.bunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton22.Font = new System.Drawing.Font("splart-h-amana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuThinButton22.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuThinButton22.IdleBorderThickness = 1;
            this.bunifuThinButton22.IdleCornerRadius = 20;
            this.bunifuThinButton22.IdleFillColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuThinButton22.IdleForecolor = System.Drawing.Color.Maroon;
            this.bunifuThinButton22.IdleLineColor = System.Drawing.Color.Maroon;
            this.bunifuThinButton22.Location = new System.Drawing.Point(174, 607);
            this.bunifuThinButton22.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.bunifuThinButton22.Name = "bunifuThinButton22";
            this.bunifuThinButton22.Size = new System.Drawing.Size(118, 45);
            this.bunifuThinButton22.TabIndex = 94;
            this.bunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton22.Click += new System.EventHandler(this.bunifuThinButton22_Click);
            // 
            // salary_id
            // 
            this.salary_id.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.salary_id.AutoSize = true;
            this.salary_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salary_id.ForeColor = System.Drawing.Color.Maroon;
            this.salary_id.Location = new System.Drawing.Point(398, 698);
            this.salary_id.Name = "salary_id";
            this.salary_id.Size = new System.Drawing.Size(25, 25);
            this.salary_id.TabIndex = 95;
            this.salary_id.Text = "0";
            this.salary_id.Visible = false;
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
            this.bunifuThinButton25.Location = new System.Drawing.Point(227, 698);
            this.bunifuThinButton25.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.bunifuThinButton25.Name = "bunifuThinButton25";
            this.bunifuThinButton25.Size = new System.Drawing.Size(161, 67);
            this.bunifuThinButton25.TabIndex = 134;
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
            this.bunifuThinButton24.Location = new System.Drawing.Point(34, 698);
            this.bunifuThinButton24.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.bunifuThinButton24.Name = "bunifuThinButton24";
            this.bunifuThinButton24.Size = new System.Drawing.Size(161, 67);
            this.bunifuThinButton24.TabIndex = 133;
            this.bunifuThinButton24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton24.Click += new System.EventHandler(this.bunifuThinButton24_Click);
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
            this.salary.Location = new System.Drawing.Point(119, 555);
            this.salary.Margin = new System.Windows.Forms.Padding(4);
            this.salary.Name = "salary";
            this.salary.Size = new System.Drawing.Size(227, 43);
            this.salary.TabIndex = 135;
            this.salary.Text = "المبلغ";
            this.salary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // date2
            // 
            this.date2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.date2.CalendarForeColor = System.Drawing.Color.Maroon;
            this.date2.CalendarTitleForeColor = System.Drawing.Color.Maroon;
            this.date2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date2.Location = new System.Drawing.Point(174, 208);
            this.date2.Name = "date2";
            this.date2.Size = new System.Drawing.Size(148, 29);
            this.date2.TabIndex = 155;
            this.date2.Value = new System.DateTime(2022, 5, 27, 6, 13, 21, 0);
            // 
            // date1
            // 
            this.date1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.date1.CalendarForeColor = System.Drawing.Color.Maroon;
            this.date1.CalendarTitleForeColor = System.Drawing.Color.Maroon;
            this.date1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date1.Location = new System.Drawing.Point(174, 134);
            this.date1.Name = "date1";
            this.date1.Size = new System.Drawing.Size(148, 29);
            this.date1.TabIndex = 156;
            this.date1.Value = new System.DateTime(2022, 5, 27, 6, 13, 21, 0);
            // 
            // serch_outs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.date1);
            this.Controls.Add(this.date2);
            this.Controls.Add(this.salary);
            this.Controls.Add(this.bunifuThinButton25);
            this.Controls.Add(this.bunifuThinButton24);
            this.Controls.Add(this.salary_id);
            this.Controls.Add(this.bunifuThinButton22);
            this.Controls.Add(this.hor_cost);
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.comboBox_state);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.to_h);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "serch_outs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "serch_outs";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.serch_outs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label to_h;
        private System.Windows.Forms.Label label3;
        public Bunifu.Framework.UI.BunifuCustomDataGrid dgv;
        private System.Windows.Forms.ComboBox comboBox_state;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        public System.Windows.Forms.Label hor_cost;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton22;
        public System.Windows.Forms.Label salary_id;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton25;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton24;
        private Bunifu.Framework.UI.BunifuMaterialTextbox salary;
        private System.Windows.Forms.DateTimePicker date2;
        private System.Windows.Forms.DateTimePicker date1;
    }
}