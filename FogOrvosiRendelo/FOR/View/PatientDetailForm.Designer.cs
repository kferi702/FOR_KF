namespace FOR.View
{
    partial class PatientDetailForm
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
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.labelPatientName = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mTextboxName = new MetroFramework.Controls.MetroTextBox();
            this.mLabelName = new MetroFramework.Controls.MetroLabel();
            this.mTextboxAddress = new MetroFramework.Controls.MetroTextBox();
            this.mLabelAddress = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.mTextboxY = new MetroFramework.Controls.MetroTextBox();
            this.mTextboxM = new MetroFramework.Controls.MetroTextBox();
            this.mTextboxD = new MetroFramework.Controls.MetroTextBox();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(24, 368);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(179, 74);
            this.metroTile1.TabIndex = 0;
            this.metroTile1.Text = "Vissza";
            this.metroTile1.UseSelectable = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // labelPatientName
            // 
            this.labelPatientName.AutoSize = true;
            this.labelPatientName.Location = new System.Drawing.Point(372, 32);
            this.labelPatientName.Name = "labelPatientName";
            this.labelPatientName.Size = new System.Drawing.Size(35, 13);
            this.labelPatientName.TabIndex = 1;
            this.labelPatientName.Text = "label1";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.mTextboxD);
            this.groupBox2.Controls.Add(this.mTextboxM);
            this.groupBox2.Controls.Add(this.mTextboxY);
            this.groupBox2.Controls.Add(this.metroLabel8);
            this.groupBox2.Controls.Add(this.mTextboxAddress);
            this.groupBox2.Controls.Add(this.mLabelAddress);
            this.groupBox2.Controls.Add(this.mTextboxName);
            this.groupBox2.Controls.Add(this.mLabelName);
            this.groupBox2.Location = new System.Drawing.Point(23, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(475, 217);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Név";
            // 
            // mTextboxName
            // 
            // 
            // 
            // 
            this.mTextboxName.CustomButton.Image = null;
            this.mTextboxName.CustomButton.Location = new System.Drawing.Point(384, 1);
            this.mTextboxName.CustomButton.Name = "";
            this.mTextboxName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mTextboxName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mTextboxName.CustomButton.TabIndex = 1;
            this.mTextboxName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mTextboxName.CustomButton.UseSelectable = true;
            this.mTextboxName.CustomButton.Visible = false;
            this.mTextboxName.Lines = new string[0];
            this.mTextboxName.Location = new System.Drawing.Point(63, 19);
            this.mTextboxName.MaxLength = 32767;
            this.mTextboxName.Name = "mTextboxName";
            this.mTextboxName.PasswordChar = '\0';
            this.mTextboxName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mTextboxName.SelectedText = "";
            this.mTextboxName.SelectionLength = 0;
            this.mTextboxName.SelectionStart = 0;
            this.mTextboxName.ShortcutsEnabled = true;
            this.mTextboxName.Size = new System.Drawing.Size(406, 23);
            this.mTextboxName.TabIndex = 2;
            this.mTextboxName.UseSelectable = true;
            this.mTextboxName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mTextboxName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mLabelName
            // 
            this.mLabelName.AutoSize = true;
            this.mLabelName.Location = new System.Drawing.Point(11, 16);
            this.mLabelName.Name = "mLabelName";
            this.mLabelName.Size = new System.Drawing.Size(35, 19);
            this.mLabelName.TabIndex = 0;
            this.mLabelName.Text = "Név:";
            // 
            // mTextboxAddress
            // 
            // 
            // 
            // 
            this.mTextboxAddress.CustomButton.Image = null;
            this.mTextboxAddress.CustomButton.Location = new System.Drawing.Point(384, 1);
            this.mTextboxAddress.CustomButton.Name = "";
            this.mTextboxAddress.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mTextboxAddress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mTextboxAddress.CustomButton.TabIndex = 1;
            this.mTextboxAddress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mTextboxAddress.CustomButton.UseSelectable = true;
            this.mTextboxAddress.CustomButton.Visible = false;
            this.mTextboxAddress.Lines = new string[0];
            this.mTextboxAddress.Location = new System.Drawing.Point(63, 52);
            this.mTextboxAddress.MaxLength = 32767;
            this.mTextboxAddress.Name = "mTextboxAddress";
            this.mTextboxAddress.PasswordChar = '\0';
            this.mTextboxAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mTextboxAddress.SelectedText = "";
            this.mTextboxAddress.SelectionLength = 0;
            this.mTextboxAddress.SelectionStart = 0;
            this.mTextboxAddress.ShortcutsEnabled = true;
            this.mTextboxAddress.Size = new System.Drawing.Size(406, 23);
            this.mTextboxAddress.TabIndex = 4;
            this.mTextboxAddress.UseSelectable = true;
            this.mTextboxAddress.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mTextboxAddress.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mLabelAddress
            // 
            this.mLabelAddress.AutoSize = true;
            this.mLabelAddress.Location = new System.Drawing.Point(11, 49);
            this.mLabelAddress.Name = "mLabelAddress";
            this.mLabelAddress.Size = new System.Drawing.Size(52, 19);
            this.mLabelAddress.TabIndex = 3;
            this.mLabelAddress.Text = "Lakcím:";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(11, 78);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(84, 19);
            this.metroLabel8.TabIndex = 5;
            this.metroLabel8.Text = "Születési idő:";
            // 
            // mTextboxY
            // 
            // 
            // 
            // 
            this.mTextboxY.CustomButton.Image = null;
            this.mTextboxY.CustomButton.Location = new System.Drawing.Point(36, 1);
            this.mTextboxY.CustomButton.Name = "";
            this.mTextboxY.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mTextboxY.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mTextboxY.CustomButton.TabIndex = 1;
            this.mTextboxY.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mTextboxY.CustomButton.UseSelectable = true;
            this.mTextboxY.CustomButton.Visible = false;
            this.mTextboxY.Lines = new string[0];
            this.mTextboxY.Location = new System.Drawing.Point(102, 78);
            this.mTextboxY.MaxLength = 32767;
            this.mTextboxY.Name = "mTextboxY";
            this.mTextboxY.PasswordChar = '\0';
            this.mTextboxY.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mTextboxY.SelectedText = "";
            this.mTextboxY.SelectionLength = 0;
            this.mTextboxY.SelectionStart = 0;
            this.mTextboxY.ShortcutsEnabled = true;
            this.mTextboxY.Size = new System.Drawing.Size(58, 23);
            this.mTextboxY.TabIndex = 6;
            this.mTextboxY.UseSelectable = true;
            this.mTextboxY.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mTextboxY.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mTextboxM
            // 
            // 
            // 
            // 
            this.mTextboxM.CustomButton.Image = null;
            this.mTextboxM.CustomButton.Location = new System.Drawing.Point(12, 1);
            this.mTextboxM.CustomButton.Name = "";
            this.mTextboxM.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mTextboxM.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mTextboxM.CustomButton.TabIndex = 1;
            this.mTextboxM.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mTextboxM.CustomButton.UseSelectable = true;
            this.mTextboxM.CustomButton.Visible = false;
            this.mTextboxM.Lines = new string[0];
            this.mTextboxM.Location = new System.Drawing.Point(206, 78);
            this.mTextboxM.MaxLength = 32767;
            this.mTextboxM.Name = "mTextboxM";
            this.mTextboxM.PasswordChar = '\0';
            this.mTextboxM.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mTextboxM.SelectedText = "";
            this.mTextboxM.SelectionLength = 0;
            this.mTextboxM.SelectionStart = 0;
            this.mTextboxM.ShortcutsEnabled = true;
            this.mTextboxM.Size = new System.Drawing.Size(34, 23);
            this.mTextboxM.TabIndex = 7;
            this.mTextboxM.UseSelectable = true;
            this.mTextboxM.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mTextboxM.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mTextboxD
            // 
            // 
            // 
            // 
            this.mTextboxD.CustomButton.Image = null;
            this.mTextboxD.CustomButton.Location = new System.Drawing.Point(12, 1);
            this.mTextboxD.CustomButton.Name = "";
            this.mTextboxD.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mTextboxD.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mTextboxD.CustomButton.TabIndex = 1;
            this.mTextboxD.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mTextboxD.CustomButton.UseSelectable = true;
            this.mTextboxD.CustomButton.Visible = false;
            this.mTextboxD.Lines = new string[0];
            this.mTextboxD.Location = new System.Drawing.Point(166, 78);
            this.mTextboxD.MaxLength = 32767;
            this.mTextboxD.Name = "mTextboxD";
            this.mTextboxD.PasswordChar = '\0';
            this.mTextboxD.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mTextboxD.SelectedText = "";
            this.mTextboxD.SelectionLength = 0;
            this.mTextboxD.SelectionStart = 0;
            this.mTextboxD.ShortcutsEnabled = true;
            this.mTextboxD.Size = new System.Drawing.Size(34, 23);
            this.mTextboxD.TabIndex = 8;
            this.mTextboxD.UseSelectable = true;
            this.mTextboxD.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mTextboxD.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // PatientDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.labelPatientName);
            this.Controls.Add(this.metroTile1);
            this.Name = "PatientDetailForm";
            this.Text = "Részletes Adatlap";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile metroTile1;
        private System.Windows.Forms.Label labelPatientName;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroTextBox mTextboxName;
        private MetroFramework.Controls.MetroLabel mLabelName;
        private MetroFramework.Controls.MetroTextBox mTextboxAddress;
        private MetroFramework.Controls.MetroLabel mLabelAddress;
        private MetroFramework.Controls.MetroTextBox mTextboxD;
        private MetroFramework.Controls.MetroTextBox mTextboxM;
        private MetroFramework.Controls.MetroTextBox mTextboxY;
        private MetroFramework.Controls.MetroLabel metroLabel8;
    }
}