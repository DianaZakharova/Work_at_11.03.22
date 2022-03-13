
namespace Work_at_11._03._22
{
    partial class ThirdForm
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
            this.labelInformacia = new System.Windows.Forms.Label();
            this.picture = new System.Windows.Forms.PictureBox();
            this.IMIA = new System.Windows.Forms.TextBox();
            this.Familia = new System.Windows.Forms.TextBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageONE = new System.Windows.Forms.TabPage();
            this.tabPageTWO = new System.Windows.Forms.TabPage();
            this.Nazad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelInformacia
            // 
            this.labelInformacia.AutoSize = true;
            this.labelInformacia.Location = new System.Drawing.Point(22, 26);
            this.labelInformacia.Name = "labelInformacia";
            this.labelInformacia.Size = new System.Drawing.Size(252, 13);
            this.labelInformacia.TabIndex = 0;
            this.labelInformacia.Text = "Информация о пациенте (Фото, Фамилия, Имя)";
            // 
            // picture
            // 
            this.picture.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.picture.Location = new System.Drawing.Point(25, 62);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(94, 125);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture.TabIndex = 1;
            this.picture.TabStop = false;
            // 
            // IMIA
            // 
            this.IMIA.Location = new System.Drawing.Point(160, 62);
            this.IMIA.Name = "IMIA";
            this.IMIA.Size = new System.Drawing.Size(100, 20);
            this.IMIA.TabIndex = 2;
            // 
            // Familia
            // 
            this.Familia.Location = new System.Drawing.Point(266, 62);
            this.Familia.Name = "Familia";
            this.Familia.Size = new System.Drawing.Size(100, 20);
            this.Familia.TabIndex = 3;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageONE);
            this.tabControl.Controls.Add(this.tabPageTWO);
            this.tabControl.Location = new System.Drawing.Point(160, 113);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(363, 203);
            this.tabControl.TabIndex = 4;
            // 
            // tabPageONE
            // 
            this.tabPageONE.Location = new System.Drawing.Point(4, 22);
            this.tabPageONE.Name = "tabPageONE";
            this.tabPageONE.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageONE.Size = new System.Drawing.Size(355, 177);
            this.tabPageONE.TabIndex = 0;
            this.tabPageONE.Text = "Диагноз";
            this.tabPageONE.UseVisualStyleBackColor = true;
            // 
            // tabPageTWO
            // 
            this.tabPageTWO.Location = new System.Drawing.Point(4, 22);
            this.tabPageTWO.Name = "tabPageTWO";
            this.tabPageTWO.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTWO.Size = new System.Drawing.Size(355, 177);
            this.tabPageTWO.TabIndex = 1;
            this.tabPageTWO.Text = "История";
            this.tabPageTWO.UseVisualStyleBackColor = true;
            // 
            // Nazad
            // 
            this.Nazad.Location = new System.Drawing.Point(25, 289);
            this.Nazad.Name = "Nazad";
            this.Nazad.Size = new System.Drawing.Size(75, 23);
            this.Nazad.TabIndex = 5;
            this.Nazad.Text = "Назад";
            this.Nazad.UseVisualStyleBackColor = true;
            this.Nazad.Click += new System.EventHandler(this.Nazad_Click);
            // 
            // ThirdForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 328);
            this.Controls.Add(this.Nazad);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.Familia);
            this.Controls.Add(this.IMIA);
            this.Controls.Add(this.picture);
            this.Controls.Add(this.labelInformacia);
            this.MaximumSize = new System.Drawing.Size(551, 367);
            this.Name = "ThirdForm";
            this.Text = "ThirdForm";
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInformacia;
        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.TextBox IMIA;
        private System.Windows.Forms.TextBox Familia;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageONE;
        private System.Windows.Forms.TabPage tabPageTWO;
        private System.Windows.Forms.Button Nazad;
    }
}