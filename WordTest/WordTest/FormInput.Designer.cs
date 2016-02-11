﻿namespace WordTest
{
    partial class FormInput
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
            this.buttonApply = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelBranchName = new System.Windows.Forms.Label();
            this.buttonChange = new System.Windows.Forms.Button();
            this.labelImageName = new System.Windows.Forms.Label();
            this.textBoxDes = new System.Windows.Forms.TextBox();
            this.pictureBoxView = new System.Windows.Forms.PictureBox();
            this.buttonDate = new System.Windows.Forms.Button();
            this.labelDate = new System.Windows.Forms.Label();
            this.monthCalendarDate = new System.Windows.Forms.MonthCalendar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxView)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonApply
            // 
            this.buttonApply.Font = new System.Drawing.Font("DFKai-SB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonApply.Location = new System.Drawing.Point(662, 26);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(104, 47);
            this.buttonApply.TabIndex = 0;
            this.buttonApply.Text = "套用";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("DFKai-SB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonCancel.Location = new System.Drawing.Point(794, 26);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(104, 47);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "取消";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelBranchName
            // 
            this.labelBranchName.AutoSize = true;
            this.labelBranchName.Font = new System.Drawing.Font("DFKai-SB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelBranchName.Location = new System.Drawing.Point(62, 38);
            this.labelBranchName.Name = "labelBranchName";
            this.labelBranchName.Size = new System.Drawing.Size(36, 24);
            this.labelBranchName.TabIndex = 2;
            this.labelBranchName.Text = "--";
            // 
            // buttonChange
            // 
            this.buttonChange.Font = new System.Drawing.Font("DFKai-SB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonChange.Location = new System.Drawing.Point(81, 101);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(99, 47);
            this.buttonChange.TabIndex = 3;
            this.buttonChange.Text = "選擇";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // labelImageName
            // 
            this.labelImageName.AutoSize = true;
            this.labelImageName.Font = new System.Drawing.Font("DFKai-SB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelImageName.Location = new System.Drawing.Point(198, 113);
            this.labelImageName.Name = "labelImageName";
            this.labelImageName.Size = new System.Drawing.Size(36, 24);
            this.labelImageName.TabIndex = 4;
            this.labelImageName.Text = "--";
            // 
            // textBoxDes
            // 
            this.textBoxDes.Font = new System.Drawing.Font("PMingLiU", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxDes.Location = new System.Drawing.Point(101, 496);
            this.textBoxDes.Multiline = true;
            this.textBoxDes.Name = "textBoxDes";
            this.textBoxDes.Size = new System.Drawing.Size(541, 66);
            this.textBoxDes.TabIndex = 5;
            // 
            // pictureBoxView
            // 
            this.pictureBoxView.Location = new System.Drawing.Point(143, 213);
            this.pictureBoxView.Name = "pictureBoxView";
            this.pictureBoxView.Size = new System.Drawing.Size(448, 266);
            this.pictureBoxView.TabIndex = 6;
            this.pictureBoxView.TabStop = false;
            // 
            // buttonDate
            // 
            this.buttonDate.Font = new System.Drawing.Font("DFKai-SB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonDate.Location = new System.Drawing.Point(81, 154);
            this.buttonDate.Name = "buttonDate";
            this.buttonDate.Size = new System.Drawing.Size(99, 47);
            this.buttonDate.TabIndex = 7;
            this.buttonDate.Text = "日期";
            this.buttonDate.UseVisualStyleBackColor = true;
            this.buttonDate.Click += new System.EventHandler(this.buttonDate_Click);
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("DFKai-SB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelDate.Location = new System.Drawing.Point(198, 166);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(36, 24);
            this.labelDate.TabIndex = 9;
            this.labelDate.Text = "--";
            // 
            // monthCalendarDate
            // 
            this.monthCalendarDate.Location = new System.Drawing.Point(636, 308);
            this.monthCalendarDate.Name = "monthCalendarDate";
            this.monthCalendarDate.TabIndex = 10;
            this.monthCalendarDate.Visible = false;
            // 
            // FormInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 589);
            this.Controls.Add(this.monthCalendarDate);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.buttonDate);
            this.Controls.Add(this.pictureBoxView);
            this.Controls.Add(this.textBoxDes);
            this.Controls.Add(this.labelImageName);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.labelBranchName);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonApply);
            this.Name = "FormInput";
            this.Text = "FormInput";
            this.Load += new System.EventHandler(this.FormInput_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelBranchName;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.Label labelImageName;
        private System.Windows.Forms.TextBox textBoxDes;
        private System.Windows.Forms.PictureBox pictureBoxView;
        private System.Windows.Forms.Button buttonDate;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.MonthCalendar monthCalendarDate;
    }
}