
namespace Work_at_11._03._22
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitter = new System.Windows.Forms.SplitContainer();
            this.tableINFO = new System.Windows.Forms.DataGridView();
            this.IDcolumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Surname_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.TextBox();
            this.POL = new System.Windows.Forms.TextBox();
            this.Palka = new System.Windows.Forms.Label();
            this.Info = new System.Windows.Forms.Button();
            this.AgeDate = new System.Windows.Forms.Label();
            this.Gender = new System.Windows.Forms.Label();
            this.labelNAME = new System.Windows.Forms.Label();
            this.New = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitter)).BeginInit();
            this.splitter.Panel1.SuspendLayout();
            this.splitter.Panel2.SuspendLayout();
            this.splitter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableINFO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // splitter
            // 
            this.splitter.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.splitter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitter.Location = new System.Drawing.Point(0, 0);
            this.splitter.Name = "splitter";
            // 
            // splitter.Panel1
            // 
            this.splitter.Panel1.Controls.Add(this.tableINFO);
            // 
            // splitter.Panel2
            // 
            this.splitter.Panel2.Controls.Add(this.Data);
            this.splitter.Panel2.Controls.Add(this.POL);
            this.splitter.Panel2.Controls.Add(this.Palka);
            this.splitter.Panel2.Controls.Add(this.Info);
            this.splitter.Panel2.Controls.Add(this.AgeDate);
            this.splitter.Panel2.Controls.Add(this.Gender);
            this.splitter.Panel2.Controls.Add(this.labelNAME);
            this.splitter.Panel2.Controls.Add(this.New);
            this.splitter.Panel2.Controls.Add(this.pictureBox);
            this.splitter.Size = new System.Drawing.Size(800, 450);
            this.splitter.SplitterDistance = 431;
            this.splitter.SplitterWidth = 10;
            this.splitter.TabIndex = 0;
            // 
            // tableINFO
            // 
            this.tableINFO.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableINFO.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableINFO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableINFO.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDcolumn,
            this.Surname_column,
            this.Name_column,
            this.Age_column,
            this.Gender_column});
            this.tableINFO.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableINFO.Location = new System.Drawing.Point(3, 0);
            this.tableINFO.Name = "tableINFO";
            this.tableINFO.Size = new System.Drawing.Size(428, 447);
            this.tableINFO.TabIndex = 0;
            // 
            // IDcolumn
            // 
            this.IDcolumn.HeaderText = "ID";
            this.IDcolumn.Name = "IDcolumn";
            // 
            // Surname_column
            // 
            this.Surname_column.HeaderText = "Surname";
            this.Surname_column.Name = "Surname_column";
            // 
            // Name_column
            // 
            this.Name_column.HeaderText = "Name";
            this.Name_column.Name = "Name_column";
            // 
            // Age_column
            // 
            this.Age_column.HeaderText = "Date of Birth";
            this.Age_column.Name = "Age_column";
            // 
            // Gender_column
            // 
            this.Gender_column.HeaderText = "Gender";
            this.Gender_column.Name = "Gender_column";
            // 
            // Data
            // 
            this.Data.Location = new System.Drawing.Point(233, 108);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(69, 20);
            this.Data.TabIndex = 8;
            // 
            // POL
            // 
            this.POL.Location = new System.Drawing.Point(69, 108);
            this.POL.Name = "POL";
            this.POL.Size = new System.Drawing.Size(39, 20);
            this.POL.TabIndex = 7;
            // 
            // Palka
            // 
            this.Palka.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Palka.AutoSize = true;
            this.Palka.Location = new System.Drawing.Point(118, 111);
            this.Palka.Name = "Palka";
            this.Palka.Size = new System.Drawing.Size(9, 13);
            this.Palka.TabIndex = 6;
            this.Palka.Text = "|";
            // 
            // Info
            // 
            this.Info.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Info.Location = new System.Drawing.Point(143, 247);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(200, 23);
            this.Info.TabIndex = 5;
            this.Info.Text = "Информация";
            this.Info.UseVisualStyleBackColor = false;
            this.Info.Click += new System.EventHandler(this.Info_Click);
            // 
            // AgeDate
            // 
            this.AgeDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AgeDate.AutoSize = true;
            this.AgeDate.Location = new System.Drawing.Point(140, 111);
            this.AgeDate.Name = "AgeDate";
            this.AgeDate.Size = new System.Drawing.Size(87, 13);
            this.AgeDate.TabIndex = 4;
            this.AgeDate.Text = "Дата Рождения";
            // 
            // Gender
            // 
            this.Gender.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Gender.AutoSize = true;
            this.Gender.Location = new System.Drawing.Point(18, 111);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(27, 13);
            this.Gender.TabIndex = 3;
            this.Gender.Text = "Пол";
            // 
            // labelNAME
            // 
            this.labelNAME.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNAME.AutoSize = true;
            this.labelNAME.Location = new System.Drawing.Point(18, 81);
            this.labelNAME.Name = "labelNAME";
            this.labelNAME.Size = new System.Drawing.Size(90, 13);
            this.labelNAME.TabIndex = 2;
            this.labelNAME.Text = "Имя и Фамилия";
            // 
            // New
            // 
            this.New.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.New.Location = new System.Drawing.Point(21, 23);
            this.New.Name = "New";
            this.New.Size = new System.Drawing.Size(300, 33);
            this.New.TabIndex = 1;
            this.New.Text = "Добавить нового";
            this.New.UseVisualStyleBackColor = false;
            this.New.Click += new System.EventHandler(this.New_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox.Location = new System.Drawing.Point(21, 150);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(106, 120);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitter);
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.Name = "MainForm";
            this.Text = "Page";
            this.splitter.Panel1.ResumeLayout(false);
            this.splitter.Panel2.ResumeLayout(false);
            this.splitter.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitter)).EndInit();
            this.splitter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tableINFO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitter;
        private System.Windows.Forms.DataGridView tableINFO;
        private System.Windows.Forms.Button New;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label Palka;
        private System.Windows.Forms.Button Info;
        private System.Windows.Forms.Label AgeDate;
        private System.Windows.Forms.Label Gender;
        private System.Windows.Forms.Label labelNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDcolumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surname_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender_column;
        private System.Windows.Forms.TextBox Data;
        private System.Windows.Forms.TextBox POL;
    }
}

