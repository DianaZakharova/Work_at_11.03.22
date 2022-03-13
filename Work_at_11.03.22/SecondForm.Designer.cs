
namespace Work_at_11._03._22
{
    partial class SecondForm
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
            this.NameBox = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.SurnameBox = new System.Windows.Forms.TextBox();
            this.Female = new System.Windows.Forms.RadioButton();
            this.Male = new System.Windows.Forms.RadioButton();
            this.labelPOL = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.labelDiagnoz = new System.Windows.Forms.Label();
            this.DiagnoxBox = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.DateRoz = new System.Windows.Forms.Label();
            this.photoCHEL = new System.Windows.Forms.PictureBox();
            this.OpenPhoto = new System.Windows.Forms.Button();
            this.NAZ = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.photoCHEL)).BeginInit();
            this.SuspendLayout();
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(226, 9);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(57, 20);
            this.NameBox.TabIndex = 0;
            // 
            // labelName
            // 
            this.labelName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(154, 12);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(29, 13);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Имя";
            // 
            // labelSurname
            // 
            this.labelSurname.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSurname.AutoSize = true;
            this.labelSurname.Location = new System.Drawing.Point(154, 46);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(56, 13);
            this.labelSurname.TabIndex = 2;
            this.labelSurname.Text = "Фамилия";
            // 
            // SurnameBox
            // 
            this.SurnameBox.Location = new System.Drawing.Point(226, 43);
            this.SurnameBox.Name = "SurnameBox";
            this.SurnameBox.Size = new System.Drawing.Size(57, 20);
            this.SurnameBox.TabIndex = 3;
            // 
            // Female
            // 
            this.Female.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Female.AutoSize = true;
            this.Female.Location = new System.Drawing.Point(226, 79);
            this.Female.Name = "Female";
            this.Female.Size = new System.Drawing.Size(33, 17);
            this.Female.TabIndex = 4;
            this.Female.TabStop = true;
            this.Female.Text = "ж";
            this.Female.UseVisualStyleBackColor = true;
            // 
            // Male
            // 
            this.Male.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Male.AutoSize = true;
            this.Male.Location = new System.Drawing.Point(265, 79);
            this.Male.Name = "Male";
            this.Male.Size = new System.Drawing.Size(33, 17);
            this.Male.TabIndex = 5;
            this.Male.TabStop = true;
            this.Male.Text = "м";
            this.Male.UseVisualStyleBackColor = true;
            // 
            // labelPOL
            // 
            this.labelPOL.AutoSize = true;
            this.labelPOL.Location = new System.Drawing.Point(154, 81);
            this.labelPOL.Name = "labelPOL";
            this.labelPOL.Size = new System.Drawing.Size(27, 13);
            this.labelPOL.TabIndex = 6;
            this.labelPOL.Text = "Пол";
            this.labelPOL.Click += new System.EventHandler(this.labelPOL_Click);
            // 
            // labelDiagnoz
            // 
            this.labelDiagnoz.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDiagnoz.AutoSize = true;
            this.labelDiagnoz.Location = new System.Drawing.Point(12, 199);
            this.labelDiagnoz.Name = "labelDiagnoz";
            this.labelDiagnoz.Size = new System.Drawing.Size(51, 13);
            this.labelDiagnoz.TabIndex = 7;
            this.labelDiagnoz.Text = "Диагноз";
            // 
            // DiagnoxBox
            // 
            this.DiagnoxBox.Location = new System.Drawing.Point(12, 215);
            this.DiagnoxBox.Multiline = true;
            this.DiagnoxBox.Name = "DiagnoxBox";
            this.DiagnoxBox.Size = new System.Drawing.Size(453, 100);
            this.DiagnoxBox.TabIndex = 8;
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.buttonSave.Location = new System.Drawing.Point(108, 321);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 9;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.buttonCancel.Location = new System.Drawing.Point(306, 321);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 10;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            // 
            // dateTime
            // 
            this.dateTime.Location = new System.Drawing.Point(265, 111);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(200, 20);
            this.dateTime.TabIndex = 11;
            // 
            // DateRoz
            // 
            this.DateRoz.AutoSize = true;
            this.DateRoz.Location = new System.Drawing.Point(154, 117);
            this.DateRoz.Name = "DateRoz";
            this.DateRoz.Size = new System.Drawing.Size(86, 13);
            this.DateRoz.TabIndex = 12;
            this.DateRoz.Text = "Дата рождения";
            // 
            // photoCHEL
            // 
            this.photoCHEL.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.photoCHEL.Location = new System.Drawing.Point(12, 12);
            this.photoCHEL.Name = "photoCHEL";
            this.photoCHEL.Size = new System.Drawing.Size(128, 139);
            this.photoCHEL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.photoCHEL.TabIndex = 13;
            this.photoCHEL.TabStop = false;
            // 
            // OpenPhoto
            // 
            this.OpenPhoto.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.OpenPhoto.Location = new System.Drawing.Point(12, 157);
            this.OpenPhoto.Name = "OpenPhoto";
            this.OpenPhoto.Size = new System.Drawing.Size(75, 23);
            this.OpenPhoto.TabIndex = 14;
            this.OpenPhoto.Text = ". . .";
            this.OpenPhoto.UseVisualStyleBackColor = false;
            this.OpenPhoto.Click += new System.EventHandler(this.OpenPhoto_Click);
            // 
            // NAZ
            // 
            this.NAZ.Location = new System.Drawing.Point(416, 7);
            this.NAZ.Name = "NAZ";
            this.NAZ.Size = new System.Drawing.Size(75, 23);
            this.NAZ.TabIndex = 15;
            this.NAZ.Text = "Назад";
            this.NAZ.UseVisualStyleBackColor = true;
            this.NAZ.Click += new System.EventHandler(this.NAZ_Click);
            // 
            // SecondForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 356);
            this.Controls.Add(this.NAZ);
            this.Controls.Add(this.OpenPhoto);
            this.Controls.Add(this.photoCHEL);
            this.Controls.Add(this.DateRoz);
            this.Controls.Add(this.dateTime);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.DiagnoxBox);
            this.Controls.Add(this.labelDiagnoz);
            this.Controls.Add(this.labelPOL);
            this.Controls.Add(this.Male);
            this.Controls.Add(this.Female);
            this.Controls.Add(this.SurnameBox);
            this.Controls.Add(this.labelSurname);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.NameBox);
            this.MaximumSize = new System.Drawing.Size(519, 395);
            this.Name = "SecondForm";
            this.Text = "SecondForm";
            ((System.ComponentModel.ISupportInitialize)(this.photoCHEL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.TextBox SurnameBox;
        private System.Windows.Forms.RadioButton Female;
        private System.Windows.Forms.RadioButton Male;
        private System.Windows.Forms.Label labelPOL;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label labelDiagnoz;
        private System.Windows.Forms.TextBox DiagnoxBox;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.DateTimePicker dateTime;
        private System.Windows.Forms.Label DateRoz;
        private System.Windows.Forms.Button OpenPhoto;
        private System.Windows.Forms.PictureBox photoCHEL;
        private System.Windows.Forms.Button NAZ;
    }
}