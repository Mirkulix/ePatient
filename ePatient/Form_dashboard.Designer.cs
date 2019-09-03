namespace ePatient
{
    partial class Form_Dashboard
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
            this.metroSetTabControl1 = new MetroSet_UI.Controls.MetroSetTabControl();
            this.tab_persoenlich = new System.Windows.Forms.TabPage();
            this.tab_med_daten = new System.Windows.Forms.TabPage();
            this.tab_notfall_kon = new System.Windows.Forms.TabPage();
            this.tab_notfallaktion = new System.Windows.Forms.TabPage();
            this.tab_dokumente = new System.Windows.Forms.TabPage();
            this.metroSetTabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroSetTabControl1
            // 
            this.metroSetTabControl1.Controls.Add(this.tab_persoenlich);
            this.metroSetTabControl1.Controls.Add(this.tab_med_daten);
            this.metroSetTabControl1.Controls.Add(this.tab_notfall_kon);
            this.metroSetTabControl1.Controls.Add(this.tab_notfallaktion);
            this.metroSetTabControl1.Controls.Add(this.tab_dokumente);
            this.metroSetTabControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.metroSetTabControl1.ItemSize = new System.Drawing.Size(100, 38);
            this.metroSetTabControl1.Location = new System.Drawing.Point(46, 97);
            this.metroSetTabControl1.Name = "metroSetTabControl1";
            this.metroSetTabControl1.SelectedIndex = 4;
            this.metroSetTabControl1.Size = new System.Drawing.Size(894, 538);
            this.metroSetTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.metroSetTabControl1.Speed = 20;
            this.metroSetTabControl1.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetTabControl1.StyleManager = null;
            this.metroSetTabControl1.TabIndex = 0;
            this.metroSetTabControl1.TabStyle = MetroSet_UI.Enums.TabStyle.Style1;
            this.metroSetTabControl1.ThemeAuthor = "Narwin";
            this.metroSetTabControl1.ThemeName = "MetroLite";
            this.metroSetTabControl1.UseAnimation = true;
            // 
            // tab_persoenlich
            // 
            this.tab_persoenlich.Location = new System.Drawing.Point(4, 42);
            this.tab_persoenlich.Name = "tab_persoenlich";
            this.tab_persoenlich.Size = new System.Drawing.Size(864, 418);
            this.tab_persoenlich.TabIndex = 0;
            this.tab_persoenlich.Text = "Persönliche Daten";
            // 
            // tab_med_daten
            // 
            this.tab_med_daten.Location = new System.Drawing.Point(4, 42);
            this.tab_med_daten.Name = "tab_med_daten";
            this.tab_med_daten.Size = new System.Drawing.Size(864, 418);
            this.tab_med_daten.TabIndex = 1;
            this.tab_med_daten.Text = "Medizinische Daten";
            // 
            // tab_notfall_kon
            // 
            this.tab_notfall_kon.Location = new System.Drawing.Point(4, 42);
            this.tab_notfall_kon.Name = "tab_notfall_kon";
            this.tab_notfall_kon.Size = new System.Drawing.Size(864, 418);
            this.tab_notfall_kon.TabIndex = 2;
            this.tab_notfall_kon.Text = "Notfallkontakt";
            // 
            // tab_notfallaktion
            // 
            this.tab_notfallaktion.Location = new System.Drawing.Point(4, 42);
            this.tab_notfallaktion.Name = "tab_notfallaktion";
            this.tab_notfallaktion.Size = new System.Drawing.Size(864, 418);
            this.tab_notfallaktion.TabIndex = 3;
            this.tab_notfallaktion.Text = "Notfallaktionen";
            // 
            // tab_dokumente
            // 
            this.tab_dokumente.Location = new System.Drawing.Point(4, 42);
            this.tab_dokumente.Name = "tab_dokumente";
            this.tab_dokumente.Size = new System.Drawing.Size(886, 492);
            this.tab_dokumente.TabIndex = 4;
            this.tab_dokumente.Text = "Dokumente";
            // 
            // Form_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 670);
            this.Controls.Add(this.metroSetTabControl1);
            this.Name = "Form_Dashboard";
            this.Text = "Dashboard";
            this.metroSetTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroSet_UI.Controls.MetroSetTabControl metroSetTabControl1;
        private System.Windows.Forms.TabPage tab_persoenlich;
        private System.Windows.Forms.TabPage tab_med_daten;
        private System.Windows.Forms.TabPage tab_notfall_kon;
        private System.Windows.Forms.TabPage tab_notfallaktion;
        private System.Windows.Forms.TabPage tab_dokumente;
    }
}