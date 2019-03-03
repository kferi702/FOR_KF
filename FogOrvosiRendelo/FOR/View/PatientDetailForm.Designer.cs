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
            this.mTileCancel = new MetroFramework.Controls.MetroTile();
            this.labelPatientName = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mTextboxEmail = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.mTextboxComment = new MetroFramework.Controls.MetroTextBox();
            this.mTextboxPhone = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.mTextboxTB = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.mTextboxMother = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.mTextboxBirthName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.mTextboxBirthPlace = new MetroFramework.Controls.MetroTextBox();
            this.mLabelBirthP = new MetroFramework.Controls.MetroLabel();
            this.mTextboxBirthDate = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.mTextboxAddress = new MetroFramework.Controls.MetroTextBox();
            this.mLabelAddress = new MetroFramework.Controls.MetroLabel();
            this.mTextboxName = new MetroFramework.Controls.MetroTextBox();
            this.mLabelName = new MetroFramework.Controls.MetroLabel();
            this.mTileEditSave = new MetroFramework.Controls.MetroTile();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // mTileCancel
            // 
            this.mTileCancel.ActiveControl = null;
            this.mTileCancel.Location = new System.Drawing.Point(23, 606);
            this.mTileCancel.Name = "mTileCancel";
            this.mTileCancel.Size = new System.Drawing.Size(179, 74);
            this.mTileCancel.Style = MetroFramework.MetroColorStyle.Red;
            this.mTileCancel.TabIndex = 0;
            this.mTileCancel.Text = "Vissza";
            this.mTileCancel.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mTileCancel.UseSelectable = true;
            this.mTileCancel.Click += new System.EventHandler(this.metroTile1_Click);
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
            this.groupBox2.Controls.Add(this.mTextboxEmail);
            this.groupBox2.Controls.Add(this.metroLabel14);
            this.groupBox2.Controls.Add(this.metroLabel13);
            this.groupBox2.Controls.Add(this.mTextboxComment);
            this.groupBox2.Controls.Add(this.mTextboxPhone);
            this.groupBox2.Controls.Add(this.metroLabel12);
            this.groupBox2.Controls.Add(this.mTextboxTB);
            this.groupBox2.Controls.Add(this.metroLabel11);
            this.groupBox2.Controls.Add(this.mTextboxMother);
            this.groupBox2.Controls.Add(this.metroLabel2);
            this.groupBox2.Controls.Add(this.mTextboxBirthName);
            this.groupBox2.Controls.Add(this.metroLabel1);
            this.groupBox2.Controls.Add(this.mTextboxBirthPlace);
            this.groupBox2.Controls.Add(this.mLabelBirthP);
            this.groupBox2.Controls.Add(this.mTextboxBirthDate);
            this.groupBox2.Controls.Add(this.metroLabel8);
            this.groupBox2.Controls.Add(this.mTextboxAddress);
            this.groupBox2.Controls.Add(this.mLabelAddress);
            this.groupBox2.Controls.Add(this.mTextboxName);
            this.groupBox2.Controls.Add(this.mLabelName);
            this.groupBox2.Location = new System.Drawing.Point(23, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(607, 537);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Személyes adatok";
            // 
            // mTextboxEmail
            // 
            // 
            // 
            // 
            this.mTextboxEmail.CustomButton.Image = null;
            this.mTextboxEmail.CustomButton.Location = new System.Drawing.Point(120, 1);
            this.mTextboxEmail.CustomButton.Name = "";
            this.mTextboxEmail.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mTextboxEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mTextboxEmail.CustomButton.TabIndex = 1;
            this.mTextboxEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mTextboxEmail.CustomButton.UseSelectable = true;
            this.mTextboxEmail.CustomButton.Visible = false;
            this.mTextboxEmail.Lines = new string[0];
            this.mTextboxEmail.Location = new System.Drawing.Point(102, 260);
            this.mTextboxEmail.MaxLength = 32767;
            this.mTextboxEmail.Name = "mTextboxEmail";
            this.mTextboxEmail.PasswordChar = '\0';
            this.mTextboxEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mTextboxEmail.SelectedText = "";
            this.mTextboxEmail.SelectionLength = 0;
            this.mTextboxEmail.SelectionStart = 0;
            this.mTextboxEmail.ShortcutsEnabled = true;
            this.mTextboxEmail.Size = new System.Drawing.Size(142, 23);
            this.mTextboxEmail.TabIndex = 20;
            this.mTextboxEmail.UseSelectable = true;
            this.mTextboxEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mTextboxEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.Location = new System.Drawing.Point(11, 292);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(81, 19);
            this.metroLabel14.TabIndex = 16;
            this.metroLabel14.Text = "Megjegyzés:";
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(11, 264);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(75, 19);
            this.metroLabel13.TabIndex = 19;
            this.metroLabel13.Text = "E-mail cím:";
            // 
            // mTextboxComment
            // 
            // 
            // 
            // 
            this.mTextboxComment.CustomButton.Image = null;
            this.mTextboxComment.CustomButton.Location = new System.Drawing.Point(138, 1);
            this.mTextboxComment.CustomButton.Name = "";
            this.mTextboxComment.CustomButton.Size = new System.Drawing.Size(215, 215);
            this.mTextboxComment.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mTextboxComment.CustomButton.TabIndex = 1;
            this.mTextboxComment.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mTextboxComment.CustomButton.UseSelectable = true;
            this.mTextboxComment.CustomButton.Visible = false;
            this.mTextboxComment.Lines = new string[0];
            this.mTextboxComment.Location = new System.Drawing.Point(11, 314);
            this.mTextboxComment.MaxLength = 32767;
            this.mTextboxComment.Multiline = true;
            this.mTextboxComment.Name = "mTextboxComment";
            this.mTextboxComment.PasswordChar = '\0';
            this.mTextboxComment.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mTextboxComment.SelectedText = "";
            this.mTextboxComment.SelectionLength = 0;
            this.mTextboxComment.SelectionStart = 0;
            this.mTextboxComment.ShortcutsEnabled = true;
            this.mTextboxComment.Size = new System.Drawing.Size(354, 217);
            this.mTextboxComment.TabIndex = 17;
            this.mTextboxComment.UseSelectable = true;
            this.mTextboxComment.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mTextboxComment.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mTextboxPhone
            // 
            // 
            // 
            // 
            this.mTextboxPhone.CustomButton.Image = null;
            this.mTextboxPhone.CustomButton.Location = new System.Drawing.Point(120, 1);
            this.mTextboxPhone.CustomButton.Name = "";
            this.mTextboxPhone.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mTextboxPhone.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mTextboxPhone.CustomButton.TabIndex = 1;
            this.mTextboxPhone.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mTextboxPhone.CustomButton.UseSelectable = true;
            this.mTextboxPhone.CustomButton.Visible = false;
            this.mTextboxPhone.Lines = new string[0];
            this.mTextboxPhone.Location = new System.Drawing.Point(102, 232);
            this.mTextboxPhone.MaxLength = 32767;
            this.mTextboxPhone.Name = "mTextboxPhone";
            this.mTextboxPhone.PasswordChar = '\0';
            this.mTextboxPhone.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mTextboxPhone.SelectedText = "";
            this.mTextboxPhone.SelectionLength = 0;
            this.mTextboxPhone.SelectionStart = 0;
            this.mTextboxPhone.ShortcutsEnabled = true;
            this.mTextboxPhone.Size = new System.Drawing.Size(142, 23);
            this.mTextboxPhone.TabIndex = 18;
            this.mTextboxPhone.UseSelectable = true;
            this.mTextboxPhone.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mTextboxPhone.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(11, 236);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(83, 19);
            this.metroLabel12.TabIndex = 17;
            this.metroLabel12.Text = "Telefonszám:";
            // 
            // mTextboxTB
            // 
            // 
            // 
            // 
            this.mTextboxTB.CustomButton.Image = null;
            this.mTextboxTB.CustomButton.Location = new System.Drawing.Point(120, 1);
            this.mTextboxTB.CustomButton.Name = "";
            this.mTextboxTB.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mTextboxTB.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mTextboxTB.CustomButton.TabIndex = 1;
            this.mTextboxTB.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mTextboxTB.CustomButton.UseSelectable = true;
            this.mTextboxTB.CustomButton.Visible = false;
            this.mTextboxTB.Lines = new string[0];
            this.mTextboxTB.Location = new System.Drawing.Point(102, 199);
            this.mTextboxTB.MaxLength = 32767;
            this.mTextboxTB.Name = "mTextboxTB";
            this.mTextboxTB.PasswordChar = '\0';
            this.mTextboxTB.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mTextboxTB.SelectedText = "";
            this.mTextboxTB.SelectionLength = 0;
            this.mTextboxTB.SelectionStart = 0;
            this.mTextboxTB.ShortcutsEnabled = true;
            this.mTextboxTB.Size = new System.Drawing.Size(142, 23);
            this.mTextboxTB.TabIndex = 16;
            this.mTextboxTB.UseSelectable = true;
            this.mTextboxTB.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mTextboxTB.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(11, 203);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(63, 19);
            this.metroLabel11.TabIndex = 15;
            this.metroLabel11.Text = "TB-szám:";
            // 
            // mTextboxMother
            // 
            // 
            // 
            // 
            this.mTextboxMother.CustomButton.Image = null;
            this.mTextboxMother.CustomButton.Location = new System.Drawing.Point(200, 1);
            this.mTextboxMother.CustomButton.Name = "";
            this.mTextboxMother.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mTextboxMother.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mTextboxMother.CustomButton.TabIndex = 1;
            this.mTextboxMother.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mTextboxMother.CustomButton.UseSelectable = true;
            this.mTextboxMother.CustomButton.Visible = false;
            this.mTextboxMother.Lines = new string[0];
            this.mTextboxMother.Location = new System.Drawing.Point(143, 171);
            this.mTextboxMother.MaxLength = 32767;
            this.mTextboxMother.Name = "mTextboxMother";
            this.mTextboxMother.PasswordChar = '\0';
            this.mTextboxMother.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mTextboxMother.SelectedText = "";
            this.mTextboxMother.SelectionLength = 0;
            this.mTextboxMother.SelectionStart = 0;
            this.mTextboxMother.ShortcutsEnabled = true;
            this.mTextboxMother.Size = new System.Drawing.Size(222, 23);
            this.mTextboxMother.TabIndex = 14;
            this.mTextboxMother.UseSelectable = true;
            this.mTextboxMother.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mTextboxMother.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(11, 175);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(126, 19);
            this.metroLabel2.TabIndex = 13;
            this.metroLabel2.Text = "Anyja születési neve:";
            // 
            // mTextboxBirthName
            // 
            // 
            // 
            // 
            this.mTextboxBirthName.CustomButton.Image = null;
            this.mTextboxBirthName.CustomButton.Location = new System.Drawing.Point(241, 1);
            this.mTextboxBirthName.CustomButton.Name = "";
            this.mTextboxBirthName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mTextboxBirthName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mTextboxBirthName.CustomButton.TabIndex = 1;
            this.mTextboxBirthName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mTextboxBirthName.CustomButton.UseSelectable = true;
            this.mTextboxBirthName.CustomButton.Visible = false;
            this.mTextboxBirthName.Lines = new string[0];
            this.mTextboxBirthName.Location = new System.Drawing.Point(102, 140);
            this.mTextboxBirthName.MaxLength = 32767;
            this.mTextboxBirthName.Name = "mTextboxBirthName";
            this.mTextboxBirthName.PasswordChar = '\0';
            this.mTextboxBirthName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mTextboxBirthName.SelectedText = "";
            this.mTextboxBirthName.SelectionLength = 0;
            this.mTextboxBirthName.SelectionStart = 0;
            this.mTextboxBirthName.ShortcutsEnabled = true;
            this.mTextboxBirthName.Size = new System.Drawing.Size(263, 23);
            this.mTextboxBirthName.TabIndex = 12;
            this.mTextboxBirthName.UseSelectable = true;
            this.mTextboxBirthName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mTextboxBirthName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(11, 144);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(85, 19);
            this.metroLabel1.TabIndex = 11;
            this.metroLabel1.Text = "Születési név:";
            // 
            // mTextboxBirthPlace
            // 
            // 
            // 
            // 
            this.mTextboxBirthPlace.CustomButton.Image = null;
            this.mTextboxBirthPlace.CustomButton.Location = new System.Drawing.Point(116, 1);
            this.mTextboxBirthPlace.CustomButton.Name = "";
            this.mTextboxBirthPlace.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mTextboxBirthPlace.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mTextboxBirthPlace.CustomButton.TabIndex = 1;
            this.mTextboxBirthPlace.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mTextboxBirthPlace.CustomButton.UseSelectable = true;
            this.mTextboxBirthPlace.CustomButton.Visible = false;
            this.mTextboxBirthPlace.Lines = new string[0];
            this.mTextboxBirthPlace.Location = new System.Drawing.Point(102, 108);
            this.mTextboxBirthPlace.MaxLength = 32767;
            this.mTextboxBirthPlace.Name = "mTextboxBirthPlace";
            this.mTextboxBirthPlace.PasswordChar = '\0';
            this.mTextboxBirthPlace.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mTextboxBirthPlace.SelectedText = "";
            this.mTextboxBirthPlace.SelectionLength = 0;
            this.mTextboxBirthPlace.SelectionStart = 0;
            this.mTextboxBirthPlace.ShortcutsEnabled = true;
            this.mTextboxBirthPlace.Size = new System.Drawing.Size(138, 23);
            this.mTextboxBirthPlace.TabIndex = 10;
            this.mTextboxBirthPlace.UseSelectable = true;
            this.mTextboxBirthPlace.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mTextboxBirthPlace.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mLabelBirthP
            // 
            this.mLabelBirthP.AutoSize = true;
            this.mLabelBirthP.Location = new System.Drawing.Point(11, 112);
            this.mLabelBirthP.Name = "mLabelBirthP";
            this.mLabelBirthP.Size = new System.Drawing.Size(88, 19);
            this.mLabelBirthP.TabIndex = 9;
            this.mLabelBirthP.Text = "Születési hely:";
            // 
            // mTextboxBirthDate
            // 
            // 
            // 
            // 
            this.mTextboxBirthDate.CustomButton.Image = null;
            this.mTextboxBirthDate.CustomButton.Location = new System.Drawing.Point(116, 1);
            this.mTextboxBirthDate.CustomButton.Name = "";
            this.mTextboxBirthDate.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mTextboxBirthDate.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mTextboxBirthDate.CustomButton.TabIndex = 1;
            this.mTextboxBirthDate.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mTextboxBirthDate.CustomButton.UseSelectable = true;
            this.mTextboxBirthDate.CustomButton.Visible = false;
            this.mTextboxBirthDate.Lines = new string[0];
            this.mTextboxBirthDate.Location = new System.Drawing.Point(102, 78);
            this.mTextboxBirthDate.MaxLength = 32767;
            this.mTextboxBirthDate.Name = "mTextboxBirthDate";
            this.mTextboxBirthDate.PasswordChar = '\0';
            this.mTextboxBirthDate.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mTextboxBirthDate.SelectedText = "";
            this.mTextboxBirthDate.SelectionLength = 0;
            this.mTextboxBirthDate.SelectionStart = 0;
            this.mTextboxBirthDate.ShortcutsEnabled = true;
            this.mTextboxBirthDate.Size = new System.Drawing.Size(138, 23);
            this.mTextboxBirthDate.TabIndex = 6;
            this.mTextboxBirthDate.UseSelectable = true;
            this.mTextboxBirthDate.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mTextboxBirthDate.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            // mTextboxAddress
            // 
            // 
            // 
            // 
            this.mTextboxAddress.CustomButton.Image = null;
            this.mTextboxAddress.CustomButton.Location = new System.Drawing.Point(280, 1);
            this.mTextboxAddress.CustomButton.Name = "";
            this.mTextboxAddress.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mTextboxAddress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mTextboxAddress.CustomButton.TabIndex = 1;
            this.mTextboxAddress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mTextboxAddress.CustomButton.UseSelectable = true;
            this.mTextboxAddress.CustomButton.Visible = false;
            this.mTextboxAddress.Lines = new string[0];
            this.mTextboxAddress.Location = new System.Drawing.Point(63, 49);
            this.mTextboxAddress.MaxLength = 32767;
            this.mTextboxAddress.Name = "mTextboxAddress";
            this.mTextboxAddress.PasswordChar = '\0';
            this.mTextboxAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mTextboxAddress.SelectedText = "";
            this.mTextboxAddress.SelectionLength = 0;
            this.mTextboxAddress.SelectionStart = 0;
            this.mTextboxAddress.ShortcutsEnabled = true;
            this.mTextboxAddress.Size = new System.Drawing.Size(302, 23);
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
            // mTextboxName
            // 
            // 
            // 
            // 
            this.mTextboxName.CustomButton.Image = null;
            this.mTextboxName.CustomButton.Location = new System.Drawing.Point(280, 1);
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
            this.mTextboxName.Size = new System.Drawing.Size(302, 23);
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
            // mTileEditSave
            // 
            this.mTileEditSave.ActiveControl = null;
            this.mTileEditSave.Location = new System.Drawing.Point(209, 606);
            this.mTileEditSave.Name = "mTileEditSave";
            this.mTileEditSave.Size = new System.Drawing.Size(179, 74);
            this.mTileEditSave.Style = MetroFramework.MetroColorStyle.Blue;
            this.mTileEditSave.TabIndex = 5;
            this.mTileEditSave.Text = "Szerkesztés\r\nMentés";
            this.mTileEditSave.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mTileEditSave.UseSelectable = true;
            this.mTileEditSave.Click += new System.EventHandler(this.mTileEditSave_Click);
            // 
            // PatientDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 703);
            this.Controls.Add(this.mTileEditSave);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.labelPatientName);
            this.Controls.Add(this.mTileCancel);
            this.Name = "PatientDetailForm";
            this.Text = "Részletes Adatlap";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile mTileCancel;
        private System.Windows.Forms.Label labelPatientName;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroTextBox mTextboxName;
        private MetroFramework.Controls.MetroLabel mLabelName;
        private MetroFramework.Controls.MetroTextBox mTextboxAddress;
        private MetroFramework.Controls.MetroLabel mLabelAddress;
        private MetroFramework.Controls.MetroTextBox mTextboxBirthDate;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel mLabelBirthP;
        private MetroFramework.Controls.MetroTextBox mTextboxBirthPlace;
        private MetroFramework.Controls.MetroTextBox mTextboxMother;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox mTextboxBirthName;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox mTextboxTB;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroTextBox mTextboxPhone;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroTextBox mTextboxEmail;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroTextBox mTextboxComment;
        private MetroFramework.Controls.MetroTile mTileEditSave;
    }
}