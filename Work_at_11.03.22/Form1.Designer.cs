﻿
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.New = new System.Windows.Forms.Button();
            this.labelNAME = new System.Windows.Forms.Label();
            this.Gender = new System.Windows.Forms.Label();
            this.AgeDate = new System.Windows.Forms.Label();
            this.Info = new System.Windows.Forms.Button();
            this.Palka = new System.Windows.Forms.Label();
            this.IDcolumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Surname_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitter)).BeginInit();
            this.splitter.Panel1.SuspendLayout();
            this.splitter.Panel2.SuspendLayout();
            this.splitter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableINFO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitter
            // 
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
            this.splitter.Panel2.Controls.Add(this.Palka);
            this.splitter.Panel2.Controls.Add(this.Info);
            this.splitter.Panel2.Controls.Add(this.AgeDate);
            this.splitter.Panel2.Controls.Add(this.Gender);
            this.splitter.Panel2.Controls.Add(this.labelNAME);
            this.splitter.Panel2.Controls.Add(this.New);
            this.splitter.Panel2.Controls.Add(this.pictureBox1);
            this.splitter.Size = new System.Drawing.Size(800, 450);
            this.splitter.SplitterDistance = 434;
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
            this.tableINFO.Location = new System.Drawing.Point(0, 0);
            this.tableINFO.Name = "tableINFO";
            this.tableINFO.Size = new System.Drawing.Size(431, 150);
            this.tableINFO.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(21, 196);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(106, 120);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
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
            // AgeDate
            // 
            this.AgeDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AgeDate.AutoSize = true;
            this.AgeDate.Location = new System.Drawing.Point(169, 111);
            this.AgeDate.Name = "AgeDate";
            this.AgeDate.Size = new System.Drawing.Size(87, 13);
            this.AgeDate.TabIndex = 4;
            this.AgeDate.Text = "Дата Рождения";
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitter);
            this.Name = "MainForm";
            this.Text = "Page";
            this.splitter.Panel1.ResumeLayout(false);
            this.splitter.Panel2.ResumeLayout(false);
            this.splitter.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitter)).EndInit();
            this.splitter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tableINFO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitter;
        private System.Windows.Forms.DataGridView tableINFO;
        private System.Windows.Forms.Button New;
        private System.Windows.Forms.PictureBox pictureBox1;
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
    }
}

