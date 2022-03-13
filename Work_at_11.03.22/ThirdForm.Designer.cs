
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
            // ThirdForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 328);
            this.Controls.Add(this.labelInformacia);
            this.Name = "ThirdForm";
            this.Text = "ThirdForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInformacia;
    }
}