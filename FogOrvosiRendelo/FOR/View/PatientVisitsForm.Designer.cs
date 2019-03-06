namespace FOR.View
{
    partial class PatientVisitsForm
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
            this.labelPacientName = new System.Windows.Forms.Label();
            this.listViewVisits = new MetroFramework.Controls.MetroListView();
            this.Dátum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mTextboxMessage = new MetroFramework.Controls.MetroTextBox();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.metroTile4 = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // labelPacientName
            // 
            this.labelPacientName.AutoSize = true;
            this.labelPacientName.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPacientName.Location = new System.Drawing.Point(212, 17);
            this.labelPacientName.Name = "labelPacientName";
            this.labelPacientName.Size = new System.Drawing.Size(61, 23);
            this.labelPacientName.TabIndex = 0;
            this.labelPacientName.Text = "label1";
            // 
            // listViewVisits
            // 
            this.listViewVisits.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Dátum});
            this.listViewVisits.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.listViewVisits.FullRowSelect = true;
            this.listViewVisits.Location = new System.Drawing.Point(12, 63);
            this.listViewVisits.Name = "listViewVisits";
            this.listViewVisits.OwnerDraw = true;
            this.listViewVisits.Size = new System.Drawing.Size(170, 368);
            this.listViewVisits.TabIndex = 1;
            this.listViewVisits.UseCompatibleStateImageBehavior = false;
            this.listViewVisits.UseSelectable = true;
            this.listViewVisits.View = System.Windows.Forms.View.List;
            this.listViewVisits.SelectedIndexChanged += new System.EventHandler(this.ListViewVisits_SelectedIndexChanged);
            // 
            // Dátum
            // 
            this.Dátum.Text = "Dátum";
            // 
            // mTextboxMessage
            // 
            // 
            // 
            // 
            this.mTextboxMessage.CustomButton.Image = null;
            this.mTextboxMessage.CustomButton.Location = new System.Drawing.Point(250, 2);
            this.mTextboxMessage.CustomButton.Name = "";
            this.mTextboxMessage.CustomButton.Size = new System.Drawing.Size(245, 245);
            this.mTextboxMessage.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mTextboxMessage.CustomButton.TabIndex = 1;
            this.mTextboxMessage.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mTextboxMessage.CustomButton.UseSelectable = true;
            this.mTextboxMessage.CustomButton.Visible = false;
            this.mTextboxMessage.Lines = new string[0];
            this.mTextboxMessage.Location = new System.Drawing.Point(188, 63);
            this.mTextboxMessage.MaxLength = 32767;
            this.mTextboxMessage.Multiline = true;
            this.mTextboxMessage.Name = "mTextboxMessage";
            this.mTextboxMessage.PasswordChar = '\0';
            this.mTextboxMessage.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mTextboxMessage.SelectedText = "";
            this.mTextboxMessage.SelectionLength = 0;
            this.mTextboxMessage.SelectionStart = 0;
            this.mTextboxMessage.ShortcutsEnabled = true;
            this.mTextboxMessage.Size = new System.Drawing.Size(498, 250);
            this.mTextboxMessage.TabIndex = 2;
            this.mTextboxMessage.UseSelectable = true;
            this.mTextboxMessage.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mTextboxMessage.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(314, 331);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(120, 100);
            this.metroTile1.TabIndex = 3;
            this.metroTile1.Text = "Szerkesztés/\r\nMentés";
            this.metroTile1.UseSelectable = true;
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Location = new System.Drawing.Point(440, 331);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(120, 100);
            this.metroTile2.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroTile2.TabIndex = 4;
            this.metroTile2.Text = "Vissza";
            this.metroTile2.UseSelectable = true;
            this.metroTile2.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // metroTile3
            // 
            this.metroTile3.ActiveControl = null;
            this.metroTile3.Location = new System.Drawing.Point(566, 331);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(120, 100);
            this.metroTile3.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTile3.TabIndex = 5;
            this.metroTile3.Text = "Törlés";
            this.metroTile3.UseSelectable = true;
            this.metroTile3.Click += new System.EventHandler(this.metroTile3_Click);
            // 
            // metroTile4
            // 
            this.metroTile4.ActiveControl = null;
            this.metroTile4.Location = new System.Drawing.Point(188, 331);
            this.metroTile4.Name = "metroTile4";
            this.metroTile4.Size = new System.Drawing.Size(120, 100);
            this.metroTile4.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTile4.TabIndex = 6;
            this.metroTile4.Text = "Új bejegyzés";
            this.metroTile4.UseSelectable = true;
            // 
            // PatientVisitsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.metroTile4);
            this.Controls.Add(this.metroTile3);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.mTextboxMessage);
            this.Controls.Add(this.listViewVisits);
            this.Controls.Add(this.labelPacientName);
            this.Name = "PatientVisitsForm";
            this.Text = "Bejegyzések";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPacientName;
        private MetroFramework.Controls.MetroListView listViewVisits;
        private MetroFramework.Controls.MetroTextBox mTextboxMessage;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile metroTile3;
        private MetroFramework.Controls.MetroTile metroTile4;
        private System.Windows.Forms.ColumnHeader Dátum;
    }
}