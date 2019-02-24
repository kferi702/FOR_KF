namespace FOR
{
    partial class MainForm
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
            this.labelWelcome = new MetroFramework.Controls.MetroLabel();
            this.tabControl = new MetroFramework.Controls.MetroTabControl();
            this.TabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.tabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.tabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage4 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabControl2 = new MetroFramework.Controls.MetroTabControl();
            this.listViewPatient = new MetroFramework.Controls.MetroListView();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.birthDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxSearch = new MetroFramework.Controls.MetroTextBox();
            this.buttonNullazas = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.tabControl.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this.metroTabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Location = new System.Drawing.Point(241, 14);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(120, 19);
            this.labelWelcome.TabIndex = 0;
            this.labelWelcome.Text = "Bejelentekező neve";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.TabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Controls.Add(this.metroTabPage4);
            this.tabControl.Location = new System.Drawing.Point(24, 63);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(905, 562);
            this.tabControl.TabIndex = 2;
            this.tabControl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tabControl.UseSelectable = true;
            // 
            // TabPage1
            // 
            this.TabPage1.Controls.Add(this.metroLabel1);
            this.TabPage1.Controls.Add(this.buttonNullazas);
            this.TabPage1.Controls.Add(this.textBoxSearch);
            this.TabPage1.Controls.Add(this.listViewPatient);
            this.TabPage1.HorizontalScrollbarBarColor = true;
            this.TabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.TabPage1.HorizontalScrollbarSize = 10;
            this.TabPage1.Location = new System.Drawing.Point(4, 38);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Size = new System.Drawing.Size(897, 520);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "TabPage1";
            this.TabPage1.VerticalScrollbarBarColor = true;
            this.TabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.TabPage1.VerticalScrollbarSize = 10;
            // 
            // tabPage2
            // 
            this.tabPage2.HorizontalScrollbarBarColor = true;
            this.tabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.tabPage2.HorizontalScrollbarSize = 10;
            this.tabPage2.Location = new System.Drawing.Point(4, 38);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(897, 520);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "TabPage2";
            this.tabPage2.VerticalScrollbarBarColor = true;
            this.tabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.tabPage2.VerticalScrollbarSize = 10;
            // 
            // tabPage3
            // 
            this.tabPage3.HorizontalScrollbarBarColor = true;
            this.tabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.tabPage3.HorizontalScrollbarSize = 10;
            this.tabPage3.Location = new System.Drawing.Point(4, 38);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(897, 520);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "TabPage3";
            this.tabPage3.VerticalScrollbarBarColor = true;
            this.tabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.tabPage3.VerticalScrollbarSize = 10;
            // 
            // metroTabPage4
            // 
            this.metroTabPage4.Controls.Add(this.metroTabControl2);
            this.metroTabPage4.HorizontalScrollbarBarColor = true;
            this.metroTabPage4.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage4.HorizontalScrollbarSize = 10;
            this.metroTabPage4.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage4.Name = "metroTabPage4";
            this.metroTabPage4.Size = new System.Drawing.Size(897, 520);
            this.metroTabPage4.TabIndex = 3;
            this.metroTabPage4.Text = "metroTabPage4";
            this.metroTabPage4.VerticalScrollbarBarColor = true;
            this.metroTabPage4.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage4.VerticalScrollbarSize = 10;
            // 
            // metroTabControl2
            // 
            this.metroTabControl2.Location = new System.Drawing.Point(666, 57);
            this.metroTabControl2.Name = "metroTabControl2";
            this.metroTabControl2.Size = new System.Drawing.Size(200, 100);
            this.metroTabControl2.TabIndex = 2;
            this.metroTabControl2.UseSelectable = true;
            // 
            // listViewPatient
            // 
            this.listViewPatient.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.birthDate,
            this.tbNumber});
            this.listViewPatient.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.listViewPatient.FullRowSelect = true;
            this.listViewPatient.Location = new System.Drawing.Point(3, 43);
            this.listViewPatient.Name = "listViewPatient";
            this.listViewPatient.OwnerDraw = true;
            this.listViewPatient.Size = new System.Drawing.Size(425, 517);
            this.listViewPatient.TabIndex = 2;
            this.listViewPatient.UseCompatibleStateImageBehavior = false;
            this.listViewPatient.UseSelectable = true;
            this.listViewPatient.View = System.Windows.Forms.View.Details;
            this.listViewPatient.SelectedIndexChanged += new System.EventHandler(this.listViewPatient_SelectedIndexChanged);
            // 
            // name
            // 
            this.name.Text = "Név";
            this.name.Width = 166;
            // 
            // birthDate
            // 
            this.birthDate.Text = "Születési Dátum";
            this.birthDate.Width = 142;
            // 
            // tbNumber
            // 
            this.tbNumber.Text = "TB-szám";
            this.tbNumber.Width = 91;
            // 
            // textBoxSearch
            // 
            // 
            // 
            // 
            this.textBoxSearch.CustomButton.Image = null;
            this.textBoxSearch.CustomButton.Location = new System.Drawing.Point(143, 1);
            this.textBoxSearch.CustomButton.Name = "";
            this.textBoxSearch.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textBoxSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBoxSearch.CustomButton.TabIndex = 1;
            this.textBoxSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBoxSearch.CustomButton.UseSelectable = true;
            this.textBoxSearch.CustomButton.Visible = false;
            this.textBoxSearch.Lines = new string[0];
            this.textBoxSearch.Location = new System.Drawing.Point(59, 10);
            this.textBoxSearch.MaxLength = 32767;
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.PasswordChar = '\0';
            this.textBoxSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxSearch.SelectedText = "";
            this.textBoxSearch.SelectionLength = 0;
            this.textBoxSearch.SelectionStart = 0;
            this.textBoxSearch.ShortcutsEnabled = true;
            this.textBoxSearch.Size = new System.Drawing.Size(165, 23);
            this.textBoxSearch.TabIndex = 3;
            this.textBoxSearch.UseSelectable = true;
            this.textBoxSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBoxSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // buttonNullazas
            // 
            this.buttonNullazas.Location = new System.Drawing.Point(230, 10);
            this.buttonNullazas.Name = "buttonNullazas";
            this.buttonNullazas.Size = new System.Drawing.Size(50, 23);
            this.buttonNullazas.TabIndex = 5;
            this.buttonNullazas.Text = "Nullázás";
            this.buttonNullazas.UseSelectable = true;
            this.buttonNullazas.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(4, 10);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(55, 19);
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Text = "Keresés:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 684);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.labelWelcome);
            this.Name = "MainForm";
            this.Text = "FogOrvosi Rendelő";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.tabControl.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.TabPage1.PerformLayout();
            this.metroTabPage4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel labelWelcome;
        private MetroFramework.Controls.MetroTabControl tabControl;
        private MetroFramework.Controls.MetroTabPage TabPage1;
        private MetroFramework.Controls.MetroTabPage tabPage2;
        private MetroFramework.Controls.MetroTabPage tabPage3;
        private MetroFramework.Controls.MetroTabPage metroTabPage4;
        private MetroFramework.Controls.MetroTabControl metroTabControl2;
        private MetroFramework.Controls.MetroListView listViewPatient;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader birthDate;
        private System.Windows.Forms.ColumnHeader tbNumber;
        private MetroFramework.Controls.MetroButton buttonNullazas;
        private MetroFramework.Controls.MetroTextBox textBoxSearch;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}