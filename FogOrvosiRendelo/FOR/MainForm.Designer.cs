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
            this.TabPagePatient = new MetroFramework.Controls.MetroTabPage();
            this.mTileDelete = new MetroFramework.Controls.MetroTile();
            this.mTileDetail2 = new MetroFramework.Controls.MetroTile();
            this.mTileNewPatient = new MetroFramework.Controls.MetroTile();
            this.mTileDetail = new MetroFramework.Controls.MetroTile();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.textBoxSearch = new MetroFramework.Controls.MetroTextBox();
            this.listViewPatient = new MetroFramework.Controls.MetroListView();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.birthDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPageMessage = new MetroFramework.Controls.MetroTabPage();
            this.tabPageCalender = new MetroFramework.Controls.MetroTabPage();
            this.tabControl.SuspendLayout();
            this.TabPagePatient.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Location = new System.Drawing.Point(268, 11);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(120, 19);
            this.labelWelcome.TabIndex = 0;
            this.labelWelcome.Text = "Bejelentekező neve";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.TabPagePatient);
            this.tabControl.Controls.Add(this.tabPageMessage);
            this.tabControl.Controls.Add(this.tabPageCalender);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(20, 60);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(912, 514);
            this.tabControl.TabIndex = 2;
            this.tabControl.UseSelectable = true;
            // 
            // TabPagePatient
            // 
            this.TabPagePatient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.TabPagePatient.Controls.Add(this.mTileDelete);
            this.TabPagePatient.Controls.Add(this.mTileDetail2);
            this.TabPagePatient.Controls.Add(this.mTileNewPatient);
            this.TabPagePatient.Controls.Add(this.mTileDetail);
            this.TabPagePatient.Controls.Add(this.metroTile1);
            this.TabPagePatient.Controls.Add(this.metroLabel1);
            this.TabPagePatient.Controls.Add(this.textBoxSearch);
            this.TabPagePatient.Controls.Add(this.listViewPatient);
            this.TabPagePatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TabPagePatient.HorizontalScrollbarBarColor = true;
            this.TabPagePatient.HorizontalScrollbarHighlightOnWheel = false;
            this.TabPagePatient.HorizontalScrollbarSize = 20;
            this.TabPagePatient.Location = new System.Drawing.Point(4, 38);
            this.TabPagePatient.Name = "TabPagePatient";
            this.TabPagePatient.Size = new System.Drawing.Size(904, 472);
            this.TabPagePatient.TabIndex = 0;
            this.TabPagePatient.Text = "Páciensek";
            this.TabPagePatient.VerticalScrollbarBarColor = true;
            this.TabPagePatient.VerticalScrollbarHighlightOnWheel = false;
            this.TabPagePatient.VerticalScrollbarSize = 10;
            // 
            // mTileDelete
            // 
            this.mTileDelete.ActiveControl = null;
            this.mTileDelete.Location = new System.Drawing.Point(633, 370);
            this.mTileDelete.Name = "mTileDelete";
            this.mTileDelete.Size = new System.Drawing.Size(268, 102);
            this.mTileDelete.Style = MetroFramework.MetroColorStyle.Red;
            this.mTileDelete.TabIndex = 11;
            this.mTileDelete.Text = "Páciens Törlése";
            this.mTileDelete.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mTileDelete.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.mTileDelete.UseSelectable = true;
            this.mTileDelete.Click += new System.EventHandler(this.mTileDelete_Click);
            // 
            // mTileDetail2
            // 
            this.mTileDetail2.ActiveControl = null;
            this.mTileDetail2.Location = new System.Drawing.Point(633, 152);
            this.mTileDetail2.Name = "mTileDetail2";
            this.mTileDetail2.Size = new System.Drawing.Size(268, 102);
            this.mTileDetail2.Style = MetroFramework.MetroColorStyle.Teal;
            this.mTileDetail2.TabIndex = 10;
            this.mTileDetail2.Text = "Páciens kórtörténet";
            this.mTileDetail2.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mTileDetail2.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.mTileDetail2.UseSelectable = true;
            // 
            // mTileNewPatient
            // 
            this.mTileNewPatient.ActiveControl = null;
            this.mTileNewPatient.Location = new System.Drawing.Point(633, 262);
            this.mTileNewPatient.Name = "mTileNewPatient";
            this.mTileNewPatient.Size = new System.Drawing.Size(268, 102);
            this.mTileNewPatient.TabIndex = 9;
            this.mTileNewPatient.Text = "Új páciens felvétele";
            this.mTileNewPatient.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mTileNewPatient.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.mTileNewPatient.UseSelectable = true;
            // 
            // mTileDetail
            // 
            this.mTileDetail.ActiveControl = null;
            this.mTileDetail.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.mTileDetail.Location = new System.Drawing.Point(633, 43);
            this.mTileDetail.Name = "mTileDetail";
            this.mTileDetail.Size = new System.Drawing.Size(268, 102);
            this.mTileDetail.Style = MetroFramework.MetroColorStyle.Brown;
            this.mTileDetail.TabIndex = 8;
            this.mTileDetail.Text = "Páciens részletes Adatai";
            this.mTileDetail.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mTileDetail.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.mTileDetail.UseSelectable = true;
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(442, 3);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(138, 34);
            this.metroTile1.TabIndex = 7;
            this.metroTile1.Text = "Szűrés törlése";
            this.metroTile1.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.metroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile1.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(0, 3);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(49, 19);
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Text = "Szűrés:";
            // 
            // textBoxSearch
            // 
            // 
            // 
            // 
            this.textBoxSearch.CustomButton.Image = null;
            this.textBoxSearch.CustomButton.Location = new System.Drawing.Point(270, 1);
            this.textBoxSearch.CustomButton.Name = "";
            this.textBoxSearch.CustomButton.Size = new System.Drawing.Size(16, 17);
            this.textBoxSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBoxSearch.CustomButton.TabIndex = 1;
            this.textBoxSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBoxSearch.CustomButton.UseSelectable = true;
            this.textBoxSearch.CustomButton.Visible = false;
            this.textBoxSearch.Lines = new string[0];
            this.textBoxSearch.Location = new System.Drawing.Point(55, 3);
            this.textBoxSearch.MaxLength = 32767;
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.PasswordChar = '\0';
            this.textBoxSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxSearch.SelectedText = "";
            this.textBoxSearch.SelectionLength = 0;
            this.textBoxSearch.SelectionStart = 0;
            this.textBoxSearch.ShortcutsEnabled = true;
            this.textBoxSearch.Size = new System.Drawing.Size(382, 23);
            this.textBoxSearch.TabIndex = 3;
            this.textBoxSearch.UseSelectable = true;
            this.textBoxSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBoxSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // listViewPatient
            // 
            this.listViewPatient.AllowSorting = true;
            this.listViewPatient.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.listViewPatient.AutoArrange = false;
            this.listViewPatient.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.birthDate,
            this.tbNumber});
            this.listViewPatient.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.listViewPatient.FullRowSelect = true;
            this.listViewPatient.Location = new System.Drawing.Point(0, 43);
            this.listViewPatient.Name = "listViewPatient";
            this.listViewPatient.OwnerDraw = true;
            this.listViewPatient.Size = new System.Drawing.Size(624, 426);
            this.listViewPatient.Sorting = System.Windows.Forms.SortOrder.Ascending;
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
            // tabPageMessage
            // 
            this.tabPageMessage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tabPageMessage.HorizontalScrollbarBarColor = true;
            this.tabPageMessage.HorizontalScrollbarHighlightOnWheel = false;
            this.tabPageMessage.HorizontalScrollbarSize = 20;
            this.tabPageMessage.Location = new System.Drawing.Point(4, 38);
            this.tabPageMessage.Name = "tabPageMessage";
            this.tabPageMessage.Size = new System.Drawing.Size(904, 472);
            this.tabPageMessage.TabIndex = 1;
            this.tabPageMessage.Text = "Üzenetek";
            this.tabPageMessage.VerticalScrollbarBarColor = true;
            this.tabPageMessage.VerticalScrollbarHighlightOnWheel = false;
            this.tabPageMessage.VerticalScrollbarSize = 10;
            // 
            // tabPageCalender
            // 
            this.tabPageCalender.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tabPageCalender.HorizontalScrollbarBarColor = true;
            this.tabPageCalender.HorizontalScrollbarHighlightOnWheel = false;
            this.tabPageCalender.HorizontalScrollbarSize = 10;
            this.tabPageCalender.Location = new System.Drawing.Point(4, 38);
            this.tabPageCalender.Name = "tabPageCalender";
            this.tabPageCalender.Size = new System.Drawing.Size(904, 472);
            this.tabPageCalender.TabIndex = 2;
            this.tabPageCalender.Text = "Naptár";
            this.tabPageCalender.VerticalScrollbarBarColor = true;
            this.tabPageCalender.VerticalScrollbarHighlightOnWheel = false;
            this.tabPageCalender.VerticalScrollbarSize = 10;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 594);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.labelWelcome);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Name = "MainForm";
            this.Text = "FogOrvosi Rendelő";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.tabControl.ResumeLayout(false);
            this.TabPagePatient.ResumeLayout(false);
            this.TabPagePatient.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel labelWelcome;
        private MetroFramework.Controls.MetroTabControl tabControl;
        private MetroFramework.Controls.MetroTabPage TabPagePatient;
        private MetroFramework.Controls.MetroTabPage tabPageMessage;
        private MetroFramework.Controls.MetroTabPage tabPageCalender;
        private MetroFramework.Controls.MetroListView listViewPatient;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader birthDate;
        private System.Windows.Forms.ColumnHeader tbNumber;
        private MetroFramework.Controls.MetroTextBox textBoxSearch;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTile mTileDelete;
        private MetroFramework.Controls.MetroTile mTileDetail2;
        private MetroFramework.Controls.MetroTile mTileNewPatient;
        private MetroFramework.Controls.MetroTile mTileDetail;
        private MetroFramework.Controls.MetroTile metroTile1;
    }
}