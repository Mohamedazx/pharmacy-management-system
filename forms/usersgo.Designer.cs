
namespace pharmacy.forms
{
    partial class usersgo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(usersgo));
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.to_h = new System.Windows.Forms.Label();
            this.dgv = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.note = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.time_go = new System.Windows.Forms.Label();
            this.time_com = new System.Windows.Forms.Label();
            this.id_come = new System.Windows.Forms.Label();
            this.total_h = new System.Windows.Forms.Label();
            this.comboBox_state = new System.Windows.Forms.ComboBox();
            this.bunifuThinButton24 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton25 = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("splart-h-amana", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(80, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 64);
            this.label1.TabIndex = 60;
            this.label1.Text = "انصراف الموظفين";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(114, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 68;
            this.label5.Text = "الوقت الحالي";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(104, 324);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 69;
            this.label6.Text = "عدد ساعات العمل";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(116, 280);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 70;
            this.label7.Text = "وقت الحضور";
            // 
            // to_h
            // 
            this.to_h.AutoSize = true;
            this.to_h.Location = new System.Drawing.Point(720, 572);
            this.to_h.Name = "to_h";
            this.to_h.Size = new System.Drawing.Size(13, 13);
            this.to_h.TabIndex = 74;
            this.to_h.Text = "0";
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.DoubleBuffered = true;
            this.dgv.EnableHeadersVisualStyles = false;
            this.dgv.HeaderBgColor = System.Drawing.Color.Maroon;
            this.dgv.HeaderForeColor = System.Drawing.Color.WhiteSmoke;
            this.dgv.Location = new System.Drawing.Point(450, 106);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dgv.Size = new System.Drawing.Size(845, 577);
            this.dgv.TabIndex = 76;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            this.dgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellDoubleClick);
            this.dgv.MouseHover += new System.EventHandler(this.dgv_MouseHover);
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
            this.bunifuThinButton21.ButtonText = "تسجيل انصراف";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("splart-h-amana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.Maroon;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.Maroon;
            this.bunifuThinButton21.Location = new System.Drawing.Point(157, 462);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(151, 45);
            this.bunifuThinButton21.TabIndex = 82;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // note
            // 
            this.note.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.note.BackColor = System.Drawing.Color.WhiteSmoke;
            this.note.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.note.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.note.ForeColor = System.Drawing.Color.Maroon;
            this.note.HintForeColor = System.Drawing.Color.Empty;
            this.note.HintText = "";
            this.note.isPassword = false;
            this.note.LineFocusedColor = System.Drawing.Color.Maroon;
            this.note.LineIdleColor = System.Drawing.Color.Gainsboro;
            this.note.LineMouseHoverColor = System.Drawing.Color.Maroon;
            this.note.LineThickness = 3;
            this.note.Location = new System.Drawing.Point(138, 410);
            this.note.Margin = new System.Windows.Forms.Padding(4);
            this.note.Name = "note";
            this.note.Size = new System.Drawing.Size(189, 29);
            this.note.TabIndex = 81;
            this.note.Text = "Note";
            this.note.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // time_go
            // 
            this.time_go.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.time_go.AutoSize = true;
            this.time_go.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time_go.ForeColor = System.Drawing.Color.Maroon;
            this.time_go.Location = new System.Drawing.Point(223, 233);
            this.time_go.Name = "time_go";
            this.time_go.Size = new System.Drawing.Size(18, 19);
            this.time_go.TabIndex = 80;
            this.time_go.Text = "0";
            // 
            // time_com
            // 
            this.time_com.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.time_com.AutoSize = true;
            this.time_com.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time_com.ForeColor = System.Drawing.Color.Maroon;
            this.time_com.Location = new System.Drawing.Point(223, 275);
            this.time_com.Name = "time_com";
            this.time_com.Size = new System.Drawing.Size(18, 19);
            this.time_com.TabIndex = 79;
            this.time_com.Text = "0";
            this.time_com.Click += new System.EventHandler(this.time_com_Click);
            // 
            // id_come
            // 
            this.id_come.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.id_come.AutoSize = true;
            this.id_come.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_come.ForeColor = System.Drawing.Color.Maroon;
            this.id_come.Location = new System.Drawing.Point(220, 191);
            this.id_come.Name = "id_come";
            this.id_come.Size = new System.Drawing.Size(25, 19);
            this.id_come.TabIndex = 78;
            this.id_come.Text = "ID";
            // 
            // total_h
            // 
            this.total_h.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.total_h.AutoSize = true;
            this.total_h.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_h.ForeColor = System.Drawing.Color.Maroon;
            this.total_h.Location = new System.Drawing.Point(223, 317);
            this.total_h.Name = "total_h";
            this.total_h.Size = new System.Drawing.Size(18, 19);
            this.total_h.TabIndex = 83;
            this.total_h.Text = "0";
            // 
            // comboBox_state
            // 
            this.comboBox_state.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox_state.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_state.ForeColor = System.Drawing.Color.Maroon;
            this.comboBox_state.FormattingEnabled = true;
            this.comboBox_state.Location = new System.Drawing.Point(144, 359);
            this.comboBox_state.Name = "comboBox_state";
            this.comboBox_state.Size = new System.Drawing.Size(177, 28);
            this.comboBox_state.TabIndex = 84;
            this.comboBox_state.Text = "موظف";
            this.comboBox_state.SelectedIndexChanged += new System.EventHandler(this.comboBox_state_SelectedIndexChanged_1);
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
            this.bunifuThinButton24.Location = new System.Drawing.Point(226, 674);
            this.bunifuThinButton24.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.bunifuThinButton24.Name = "bunifuThinButton24";
            this.bunifuThinButton24.Size = new System.Drawing.Size(145, 69);
            this.bunifuThinButton24.TabIndex = 144;
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
            this.bunifuThinButton25.Location = new System.Drawing.Point(29, 674);
            this.bunifuThinButton25.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.bunifuThinButton25.Name = "bunifuThinButton25";
            this.bunifuThinButton25.Size = new System.Drawing.Size(145, 69);
            this.bunifuThinButton25.TabIndex = 143;
            this.bunifuThinButton25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton25.Click += new System.EventHandler(this.bunifuThinButton25_Click);
            // 
            // usersgo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.bunifuThinButton24);
            this.Controls.Add(this.bunifuThinButton25);
            this.Controls.Add(this.comboBox_state);
            this.Controls.Add(this.total_h);
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.note);
            this.Controls.Add(this.time_go);
            this.Controls.Add(this.time_com);
            this.Controls.Add(this.id_come);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.to_h);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "usersgo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "usersgooo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.usersgooo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label to_h;
        public Bunifu.Framework.UI.BunifuCustomDataGrid dgv;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private Bunifu.Framework.UI.BunifuMaterialTextbox note;
        private System.Windows.Forms.Label time_go;
        private System.Windows.Forms.Label time_com;
        private System.Windows.Forms.Label id_come;
        private System.Windows.Forms.Label total_h;
        private System.Windows.Forms.ComboBox comboBox_state;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton24;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton25;
    }
}