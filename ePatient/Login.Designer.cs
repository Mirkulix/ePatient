namespace ePatient
{
    partial class frm_ePatient
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
            this.lbl_ = new MetroSet_UI.Controls.MetroSetLabel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.metroSetLabel1 = new MetroSet_UI.Controls.MetroSetLabel();
            this.tbx_Login = new MetroSet_UI.Controls.MetroSetTextBox();
            this.lbl_Beschreibung = new MetroSet_UI.Controls.MetroSetLabel();
            this.tbx_password = new MetroSet_UI.Controls.MetroSetTextBox();
            this.btn_Anmelden = new MetroSet_UI.Controls.MetroSetButton();
            this.tbx_regUsername = new MetroSet_UI.Controls.MetroSetTextBox();
            this.tbx_regPassword = new MetroSet_UI.Controls.MetroSetTextBox();
            this.tbx_regConirmPassword = new MetroSet_UI.Controls.MetroSetTextBox();
            this.lbl_reg_username = new MetroSet_UI.Controls.MetroSetLabel();
            this.lbl_reg_password = new MetroSet_UI.Controls.MetroSetLabel();
            this.lbl_regConfirm_password = new MetroSet_UI.Controls.MetroSetLabel();
            this.btn_Registrieren = new MetroSet_UI.Controls.MetroSetButton();
            this.pic_Login = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Login)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_
            // 
            this.lbl_.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_.Location = new System.Drawing.Point(338, 7);
            this.lbl_.Name = "lbl_";
            this.lbl_.Size = new System.Drawing.Size(179, 17);
            this.lbl_.Style = MetroSet_UI.Design.Style.Custom;
            this.lbl_.StyleManager = null;
            this.lbl_.TabIndex = 0;
            this.lbl_.Text = "EMail oder Telefonnummer";
            this.lbl_.ThemeAuthor = "Narwin";
            this.lbl_.ThemeName = "MetroLite";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // metroSetLabel1
            // 
            this.metroSetLabel1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel1.Location = new System.Drawing.Point(523, 7);
            this.metroSetLabel1.Name = "metroSetLabel1";
            this.metroSetLabel1.Size = new System.Drawing.Size(179, 15);
            this.metroSetLabel1.Style = MetroSet_UI.Design.Style.Custom;
            this.metroSetLabel1.StyleManager = null;
            this.metroSetLabel1.TabIndex = 5;
            this.metroSetLabel1.Text = "Passwort";
            this.metroSetLabel1.ThemeAuthor = "Narwin";
            this.metroSetLabel1.ThemeName = "MetroLite";
            // 
            // tbx_Login
            // 
            this.tbx_Login.AutoCompleteCustomSource = null;
            this.tbx_Login.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbx_Login.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbx_Login.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.tbx_Login.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.tbx_Login.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.tbx_Login.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.tbx_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbx_Login.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.tbx_Login.Image = null;
            this.tbx_Login.Lines = null;
            this.tbx_Login.Location = new System.Drawing.Point(338, 27);
            this.tbx_Login.MaxLength = 32767;
            this.tbx_Login.Multiline = false;
            this.tbx_Login.Name = "tbx_Login";
            this.tbx_Login.ReadOnly = false;
            this.tbx_Login.Size = new System.Drawing.Size(179, 22);
            this.tbx_Login.Style = MetroSet_UI.Design.Style.Light;
            this.tbx_Login.StyleManager = null;
            this.tbx_Login.TabIndex = 6;
            this.tbx_Login.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbx_Login.ThemeAuthor = "Narwin";
            this.tbx_Login.ThemeName = "MetroLite";
            this.tbx_Login.UseSystemPasswordChar = false;
            this.tbx_Login.WatermarkText = "";
            // 
            // lbl_Beschreibung
            // 
            this.lbl_Beschreibung.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_Beschreibung.Location = new System.Drawing.Point(15, 91);
            this.lbl_Beschreibung.Name = "lbl_Beschreibung";
            this.lbl_Beschreibung.Size = new System.Drawing.Size(268, 66);
            this.lbl_Beschreibung.Style = MetroSet_UI.Design.Style.Light;
            this.lbl_Beschreibung.StyleManager = null;
            this.lbl_Beschreibung.TabIndex = 9;
            this.lbl_Beschreibung.Text = "Hier kommt die Beschreibung";
            this.lbl_Beschreibung.ThemeAuthor = "Narwin";
            this.lbl_Beschreibung.ThemeName = "MetroLite";
            // 
            // tbx_password
            // 
            this.tbx_password.AutoCompleteCustomSource = null;
            this.tbx_password.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbx_password.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbx_password.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.tbx_password.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.tbx_password.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.tbx_password.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.tbx_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbx_password.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.tbx_password.Image = null;
            this.tbx_password.Lines = null;
            this.tbx_password.Location = new System.Drawing.Point(523, 27);
            this.tbx_password.MaxLength = 32767;
            this.tbx_password.Multiline = false;
            this.tbx_password.Name = "tbx_password";
            this.tbx_password.ReadOnly = false;
            this.tbx_password.Size = new System.Drawing.Size(179, 22);
            this.tbx_password.Style = MetroSet_UI.Design.Style.Light;
            this.tbx_password.StyleManager = null;
            this.tbx_password.TabIndex = 11;
            this.tbx_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbx_password.ThemeAuthor = "Narwin";
            this.tbx_password.ThemeName = "MetroLite";
            this.tbx_password.UseSystemPasswordChar = false;
            this.tbx_password.WatermarkText = "";
            // 
            // btn_Anmelden
            // 
            this.btn_Anmelden.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btn_Anmelden.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btn_Anmelden.DisabledForeColor = System.Drawing.Color.Gray;
            this.btn_Anmelden.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_Anmelden.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btn_Anmelden.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btn_Anmelden.HoverTextColor = System.Drawing.Color.White;
            this.btn_Anmelden.Location = new System.Drawing.Point(751, 27);
            this.btn_Anmelden.Name = "btn_Anmelden";
            this.btn_Anmelden.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btn_Anmelden.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btn_Anmelden.NormalTextColor = System.Drawing.Color.White;
            this.btn_Anmelden.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btn_Anmelden.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btn_Anmelden.PressTextColor = System.Drawing.Color.White;
            this.btn_Anmelden.Size = new System.Drawing.Size(138, 23);
            this.btn_Anmelden.Style = MetroSet_UI.Design.Style.Light;
            this.btn_Anmelden.StyleManager = null;
            this.btn_Anmelden.TabIndex = 12;
            this.btn_Anmelden.Text = "Anmelden";
            this.btn_Anmelden.ThemeAuthor = "Narwin";
            this.btn_Anmelden.ThemeName = "MetroLite";
            this.btn_Anmelden.Click += new System.EventHandler(this.click_anmelden);
            // 
            // tbx_regUsername
            // 
            this.tbx_regUsername.AutoCompleteCustomSource = null;
            this.tbx_regUsername.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbx_regUsername.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbx_regUsername.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.tbx_regUsername.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.tbx_regUsername.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.tbx_regUsername.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.tbx_regUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbx_regUsername.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.tbx_regUsername.Image = null;
            this.tbx_regUsername.Lines = null;
            this.tbx_regUsername.Location = new System.Drawing.Point(30, 340);
            this.tbx_regUsername.MaxLength = 32767;
            this.tbx_regUsername.Multiline = false;
            this.tbx_regUsername.Name = "tbx_regUsername";
            this.tbx_regUsername.ReadOnly = false;
            this.tbx_regUsername.Size = new System.Drawing.Size(179, 22);
            this.tbx_regUsername.Style = MetroSet_UI.Design.Style.Light;
            this.tbx_regUsername.StyleManager = null;
            this.tbx_regUsername.TabIndex = 13;
            this.tbx_regUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbx_regUsername.ThemeAuthor = "Narwin";
            this.tbx_regUsername.ThemeName = "MetroLite";
            this.tbx_regUsername.UseSystemPasswordChar = false;
            this.tbx_regUsername.WatermarkText = "";
            // 
            // tbx_regPassword
            // 
            this.tbx_regPassword.AutoCompleteCustomSource = null;
            this.tbx_regPassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbx_regPassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbx_regPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.tbx_regPassword.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.tbx_regPassword.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.tbx_regPassword.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.tbx_regPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbx_regPassword.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.tbx_regPassword.Image = null;
            this.tbx_regPassword.Lines = null;
            this.tbx_regPassword.Location = new System.Drawing.Point(30, 390);
            this.tbx_regPassword.MaxLength = 32767;
            this.tbx_regPassword.Multiline = false;
            this.tbx_regPassword.Name = "tbx_regPassword";
            this.tbx_regPassword.ReadOnly = false;
            this.tbx_regPassword.Size = new System.Drawing.Size(179, 22);
            this.tbx_regPassword.Style = MetroSet_UI.Design.Style.Light;
            this.tbx_regPassword.StyleManager = null;
            this.tbx_regPassword.TabIndex = 14;
            this.tbx_regPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbx_regPassword.ThemeAuthor = "Narwin";
            this.tbx_regPassword.ThemeName = "MetroLite";
            this.tbx_regPassword.UseSystemPasswordChar = false;
            this.tbx_regPassword.WatermarkText = "";
            // 
            // tbx_regConirmPassword
            // 
            this.tbx_regConirmPassword.AutoCompleteCustomSource = null;
            this.tbx_regConirmPassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbx_regConirmPassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbx_regConirmPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.tbx_regConirmPassword.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.tbx_regConirmPassword.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.tbx_regConirmPassword.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.tbx_regConirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbx_regConirmPassword.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.tbx_regConirmPassword.Image = null;
            this.tbx_regConirmPassword.Lines = null;
            this.tbx_regConirmPassword.Location = new System.Drawing.Point(30, 443);
            this.tbx_regConirmPassword.MaxLength = 32767;
            this.tbx_regConirmPassword.Multiline = false;
            this.tbx_regConirmPassword.Name = "tbx_regConirmPassword";
            this.tbx_regConirmPassword.ReadOnly = false;
            this.tbx_regConirmPassword.Size = new System.Drawing.Size(179, 22);
            this.tbx_regConirmPassword.Style = MetroSet_UI.Design.Style.Light;
            this.tbx_regConirmPassword.StyleManager = null;
            this.tbx_regConirmPassword.TabIndex = 15;
            this.tbx_regConirmPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbx_regConirmPassword.ThemeAuthor = "Narwin";
            this.tbx_regConirmPassword.ThemeName = "MetroLite";
            this.tbx_regConirmPassword.UseSystemPasswordChar = false;
            this.tbx_regConirmPassword.WatermarkText = "";
            // 
            // lbl_reg_username
            // 
            this.lbl_reg_username.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_reg_username.Location = new System.Drawing.Point(30, 316);
            this.lbl_reg_username.Name = "lbl_reg_username";
            this.lbl_reg_username.Size = new System.Drawing.Size(179, 17);
            this.lbl_reg_username.Style = MetroSet_UI.Design.Style.Custom;
            this.lbl_reg_username.StyleManager = null;
            this.lbl_reg_username.TabIndex = 16;
            this.lbl_reg_username.Text = "EMail oder Telefonnummer";
            this.lbl_reg_username.ThemeAuthor = "Narwin";
            this.lbl_reg_username.ThemeName = "MetroLite";
            // 
            // lbl_reg_password
            // 
            this.lbl_reg_password.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_reg_password.Location = new System.Drawing.Point(30, 372);
            this.lbl_reg_password.Name = "lbl_reg_password";
            this.lbl_reg_password.Size = new System.Drawing.Size(179, 15);
            this.lbl_reg_password.Style = MetroSet_UI.Design.Style.Custom;
            this.lbl_reg_password.StyleManager = null;
            this.lbl_reg_password.TabIndex = 17;
            this.lbl_reg_password.Text = "Passwort";
            this.lbl_reg_password.ThemeAuthor = "Narwin";
            this.lbl_reg_password.ThemeName = "MetroLite";
            // 
            // lbl_regConfirm_password
            // 
            this.lbl_regConfirm_password.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_regConfirm_password.Location = new System.Drawing.Point(30, 425);
            this.lbl_regConfirm_password.Name = "lbl_regConfirm_password";
            this.lbl_regConfirm_password.Size = new System.Drawing.Size(179, 15);
            this.lbl_regConfirm_password.Style = MetroSet_UI.Design.Style.Custom;
            this.lbl_regConfirm_password.StyleManager = null;
            this.lbl_regConfirm_password.TabIndex = 18;
            this.lbl_regConfirm_password.Text = "Confirm";
            this.lbl_regConfirm_password.ThemeAuthor = "Narwin";
            this.lbl_regConfirm_password.ThemeName = "MetroLite";
            // 
            // btn_Registrieren
            // 
            this.btn_Registrieren.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btn_Registrieren.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btn_Registrieren.DisabledForeColor = System.Drawing.Color.Gray;
            this.btn_Registrieren.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_Registrieren.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btn_Registrieren.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btn_Registrieren.HoverTextColor = System.Drawing.Color.White;
            this.btn_Registrieren.Location = new System.Drawing.Point(30, 502);
            this.btn_Registrieren.Name = "btn_Registrieren";
            this.btn_Registrieren.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btn_Registrieren.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btn_Registrieren.NormalTextColor = System.Drawing.Color.White;
            this.btn_Registrieren.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btn_Registrieren.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btn_Registrieren.PressTextColor = System.Drawing.Color.White;
            this.btn_Registrieren.Size = new System.Drawing.Size(179, 23);
            this.btn_Registrieren.Style = MetroSet_UI.Design.Style.Light;
            this.btn_Registrieren.StyleManager = null;
            this.btn_Registrieren.TabIndex = 19;
            this.btn_Registrieren.Text = "Registrierung";
            this.btn_Registrieren.ThemeAuthor = "Narwin";
            this.btn_Registrieren.ThemeName = "MetroLite";
            this.btn_Registrieren.Click += new System.EventHandler(this.Click_Registrierung);
            // 
            // pic_Login
            // 
            this.pic_Login.BackColor = System.Drawing.SystemColors.Window;
            this.pic_Login.Image = global::ePatient.Properties.Resources.Hintergrund;
            this.pic_Login.Location = new System.Drawing.Point(338, 70);
            this.pic_Login.Margin = new System.Windows.Forms.Padding(0);
            this.pic_Login.Name = "pic_Login";
            this.pic_Login.Size = new System.Drawing.Size(639, 675);
            this.pic_Login.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Login.TabIndex = 4;
            this.pic_Login.TabStop = false;
            // 
            // frm_ePatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 594);
            this.Controls.Add(this.btn_Registrieren);
            this.Controls.Add(this.lbl_regConfirm_password);
            this.Controls.Add(this.lbl_reg_password);
            this.Controls.Add(this.lbl_reg_username);
            this.Controls.Add(this.tbx_regConirmPassword);
            this.Controls.Add(this.tbx_regPassword);
            this.Controls.Add(this.tbx_regUsername);
            this.Controls.Add(this.btn_Anmelden);
            this.Controls.Add(this.tbx_password);
            this.Controls.Add(this.lbl_Beschreibung);
            this.Controls.Add(this.tbx_Login);
            this.Controls.Add(this.metroSetLabel1);
            this.Controls.Add(this.lbl_);
            this.Controls.Add(this.pic_Login);
            this.Name = "frm_ePatient";
            this.Text = "ePatient";
            this.Load += new System.EventHandler(this.FormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Login)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroSet_UI.Controls.MetroSetLabel lbl_;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pic_Login;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel1;
        private MetroSet_UI.Controls.MetroSetTextBox tbx_Login;
        private MetroSet_UI.Controls.MetroSetLabel lbl_Beschreibung;
        private MetroSet_UI.Controls.MetroSetTextBox tbx_password;
        private MetroSet_UI.Controls.MetroSetButton btn_Anmelden;
        private MetroSet_UI.Controls.MetroSetTextBox tbx_regUsername;
        private MetroSet_UI.Controls.MetroSetTextBox tbx_regPassword;
        private MetroSet_UI.Controls.MetroSetTextBox tbx_regConirmPassword;
        private MetroSet_UI.Controls.MetroSetLabel lbl_reg_username;
        private MetroSet_UI.Controls.MetroSetLabel lbl_reg_password;
        private MetroSet_UI.Controls.MetroSetLabel lbl_regConfirm_password;
        private MetroSet_UI.Controls.MetroSetButton btn_Registrieren;
    }
}