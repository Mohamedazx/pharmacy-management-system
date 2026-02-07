
namespace pharmacy.forms
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.user = new System.Windows.Forms.RadioButton();
            this.Admin = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.user_name = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.password = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.cb = new Bunifu.Framework.UI.BunifuCheckbox();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuImageButton7 = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton7)).BeginInit();
            this.SuspendLayout();
            // 
            // user
            // 
            this.user.AutoSize = true;
            this.user.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user.ForeColor = System.Drawing.Color.Maroon;
            this.user.Location = new System.Drawing.Point(73, 222);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(65, 28);
            this.user.TabIndex = 6;
            this.user.TabStop = true;
            this.user.Text = "user";
            this.user.UseVisualStyleBackColor = true;
            // 
            // Admin
            // 
            this.Admin.AutoSize = true;
            this.Admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admin.ForeColor = System.Drawing.Color.Maroon;
            this.Admin.Location = new System.Drawing.Point(192, 222);
            this.Admin.Name = "Admin";
            this.Admin.Size = new System.Drawing.Size(83, 28);
            this.Admin.TabIndex = 7;
            this.Admin.TabStop = true;
            this.Admin.Text = "Admin";
            this.Admin.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(133, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 29);
            this.label2.TabIndex = 9;
            this.label2.Text = "Login";
            // 
            // user_name
            // 
            this.user_name.BackColor = System.Drawing.Color.WhiteSmoke;
            this.user_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.user_name.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.user_name.ForeColor = System.Drawing.Color.Maroon;
            this.user_name.HintForeColor = System.Drawing.Color.Empty;
            this.user_name.HintText = "";
            this.user_name.isPassword = false;
            this.user_name.LineFocusedColor = System.Drawing.Color.Maroon;
            this.user_name.LineIdleColor = System.Drawing.Color.Gainsboro;
            this.user_name.LineMouseHoverColor = System.Drawing.Color.Maroon;
            this.user_name.LineThickness = 3;
            this.user_name.Location = new System.Drawing.Point(35, 76);
            this.user_name.Margin = new System.Windows.Forms.Padding(4);
            this.user_name.Name = "user_name";
            this.user_name.Size = new System.Drawing.Size(271, 33);
            this.user_name.TabIndex = 10;
            this.user_name.Text = "User ID";
            this.user_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.Color.WhiteSmoke;
            this.password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.password.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.password.ForeColor = System.Drawing.Color.Maroon;
            this.password.HintForeColor = System.Drawing.Color.Empty;
            this.password.HintText = "";
            this.password.isPassword = false;
            this.password.LineFocusedColor = System.Drawing.Color.Maroon;
            this.password.LineIdleColor = System.Drawing.Color.Gainsboro;
            this.password.LineMouseHoverColor = System.Drawing.Color.Maroon;
            this.password.LineThickness = 3;
            this.password.Location = new System.Drawing.Point(35, 143);
            this.password.Margin = new System.Windows.Forms.Padding(4);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(271, 33);
            this.password.TabIndex = 11;
            this.password.Text = "Password";
            this.password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // cb
            // 
            this.cb.BackColor = System.Drawing.Color.Maroon;
            this.cb.ChechedOffColor = System.Drawing.Color.Maroon;
            this.cb.Checked = false;
            this.cb.CheckedOnColor = System.Drawing.Color.Maroon;
            this.cb.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cb.Location = new System.Drawing.Point(35, 194);
            this.cb.Name = "cb";
            this.cb.Size = new System.Drawing.Size(20, 20);
            this.cb.TabIndex = 12;
            this.cb.OnChange += new System.EventHandler(this.bunifuCheckbox1_OnChange);
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.Maroon;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.Maroon;
            this.bunifuThinButton21.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Login";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.Maroon;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.Maroon;
            this.bunifuThinButton21.Location = new System.Drawing.Point(61, 276);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(199, 45);
            this.bunifuThinButton21.TabIndex = 13;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // bunifuImageButton7
            // 
            this.bunifuImageButton7.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton7.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton7.Image")));
            this.bunifuImageButton7.ImageActive = null;
            this.bunifuImageButton7.Location = new System.Drawing.Point(288, 12);
            this.bunifuImageButton7.Name = "bunifuImageButton7";
            this.bunifuImageButton7.Size = new System.Drawing.Size(30, 30);
            this.bunifuImageButton7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bunifuImageButton7.TabIndex = 16;
            this.bunifuImageButton7.TabStop = false;
            this.bunifuImageButton7.Zoom = 10;
            this.bunifuImageButton7.Click += new System.EventHandler(this.bunifuImageButton7_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 352);
            this.Controls.Add(this.bunifuImageButton7);
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.cb);
            this.Controls.Add(this.password);
            this.Controls.Add(this.user_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Admin);
            this.Controls.Add(this.user);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            this.Load += new System.EventHandler(this.login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.RadioButton user;
        public System.Windows.Forms.RadioButton Admin;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox user_name;
        private Bunifu.Framework.UI.BunifuMaterialTextbox password;
        private Bunifu.Framework.UI.BunifuCheckbox cb;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton7;
    }
}