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
            this.mTextboxMessage = new MetroFramework.Controls.MetroTextBox();
            this.mTileVisitsEditSave = new MetroFramework.Controls.MetroTile();
            this.mTileCancel = new MetroFramework.Controls.MetroTile();
            this.mTileDelete = new MetroFramework.Controls.MetroTile();
            this.mTileNewVisits = new MetroFramework.Controls.MetroTile();
            this.listViewVisits = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            // mTileVisitsEditSave
            // 
            this.mTileVisitsEditSave.ActiveControl = null;
            this.mTileVisitsEditSave.Location = new System.Drawing.Point(314, 331);
            this.mTileVisitsEditSave.Name = "mTileVisitsEditSave";
            this.mTileVisitsEditSave.Size = new System.Drawing.Size(120, 100);
            this.mTileVisitsEditSave.TabIndex = 3;
            this.mTileVisitsEditSave.Text = "Szerkesztés/\r\nMentés";
            this.mTileVisitsEditSave.UseSelectable = true;
            // 
            // mTileCancel
            // 
            this.mTileCancel.ActiveControl = null;
            this.mTileCancel.Location = new System.Drawing.Point(440, 331);
            this.mTileCancel.Name = "mTileCancel";
            this.mTileCancel.Size = new System.Drawing.Size(120, 100);
            this.mTileCancel.Style = MetroFramework.MetroColorStyle.Silver;
            this.mTileCancel.TabIndex = 4;
            this.mTileCancel.Text = "Vissza";
            this.mTileCancel.UseSelectable = true;
            this.mTileCancel.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // mTileDelete
            // 
            this.mTileDelete.ActiveControl = null;
            this.mTileDelete.Location = new System.Drawing.Point(566, 331);
            this.mTileDelete.Name = "mTileDelete";
            this.mTileDelete.Size = new System.Drawing.Size(120, 100);
            this.mTileDelete.Style = MetroFramework.MetroColorStyle.Red;
            this.mTileDelete.TabIndex = 5;
            this.mTileDelete.Text = "Törlés";
            this.mTileDelete.UseSelectable = true;
            this.mTileDelete.Click += new System.EventHandler(this.mTileDelete_Click);
            // 
            // mTileNewVisits
            // 
            this.mTileNewVisits.ActiveControl = null;
            this.mTileNewVisits.Location = new System.Drawing.Point(188, 331);
            this.mTileNewVisits.Name = "mTileNewVisits";
            this.mTileNewVisits.Size = new System.Drawing.Size(120, 100);
            this.mTileNewVisits.Style = MetroFramework.MetroColorStyle.Green;
            this.mTileNewVisits.TabIndex = 6;
            this.mTileNewVisits.Text = "Új bejegyzés";
            this.mTileNewVisits.UseSelectable = true;
            this.mTileNewVisits.Click += new System.EventHandler(this.mTileNewVisits_Click);
            // 
            // listViewVisits
            // 
            this.listViewVisits.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.date});
            this.listViewVisits.FullRowSelect = true;
            this.listViewVisits.LabelWrap = false;
            this.listViewVisits.Location = new System.Drawing.Point(6, 63);
            this.listViewVisits.MultiSelect = false;
            this.listViewVisits.Name = "listViewVisits";
            this.listViewVisits.Size = new System.Drawing.Size(176, 368);
            this.listViewVisits.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listViewVisits.TabIndex = 7;
            this.listViewVisits.UseCompatibleStateImageBehavior = false;
            this.listViewVisits.View = System.Windows.Forms.View.Details;
            this.listViewVisits.SelectedIndexChanged += new System.EventHandler(this.listViewVisits_SelectedIndexChanged);
            this.listViewVisits.Click += new System.EventHandler(this.listViewVisits_Click);
            // 
            // id
            // 
            this.id.Text = "id";
            this.id.Width = 0;
            // 
            // date
            // 
            this.date.Text = "dt";
            this.date.Width = 168;
            // 
            // PatientVisitsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 450);
            this.Controls.Add(this.listViewVisits);
            this.Controls.Add(this.mTileNewVisits);
            this.Controls.Add(this.mTileDelete);
            this.Controls.Add(this.mTileCancel);
            this.Controls.Add(this.mTileVisitsEditSave);
            this.Controls.Add(this.mTextboxMessage);
            this.Controls.Add(this.labelPacientName);
            this.Name = "PatientVisitsForm";
            this.Text = "Bejegyzések";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPacientName;
        private MetroFramework.Controls.MetroTextBox mTextboxMessage;
        private MetroFramework.Controls.MetroTile mTileVisitsEditSave;
        private MetroFramework.Controls.MetroTile mTileCancel;
        private MetroFramework.Controls.MetroTile mTileDelete;
        private MetroFramework.Controls.MetroTile mTileNewVisits;
        private System.Windows.Forms.ListView listViewVisits;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader date;
    }
}