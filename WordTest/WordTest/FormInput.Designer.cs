namespace WordTest
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
            this.buttonChange = new System.Windows.Forms.Button();
            this.labelImageName = new System.Windows.Forms.Label();
            this.textBoxDes = new System.Windows.Forms.TextBox();
            this.buttonDate = new System.Windows.Forms.Button();
            this.monthCalendarDate = new System.Windows.Forms.MonthCalendar();
            this.textBoxBranchName = new System.Windows.Forms.TextBox();
            this.textBoxDate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBoxView = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxView)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonApply
            // 
            this.buttonApply.Font = new System.Drawing.Font("DFKai-SB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonApply.Location = new System.Drawing.Point(606, 37);
            this.buttonApply.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(78, 38);
            this.buttonApply.TabIndex = 0;
            this.buttonApply.Text = "套用";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("DFKai-SB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonCancel.Location = new System.Drawing.Point(688, 37);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(78, 38);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "取消";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonChange
            // 
            this.buttonChange.Font = new System.Drawing.Font("DFKai-SB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonChange.Location = new System.Drawing.Point(133, 110);
            this.buttonChange.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(74, 38);
            this.buttonChange.TabIndex = 3;
            this.buttonChange.Text = "選擇";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // labelImageName
            // 
            this.labelImageName.AutoSize = true;
            this.labelImageName.Font = new System.Drawing.Font("DFKai-SB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelImageName.Location = new System.Drawing.Point(220, 119);
            this.labelImageName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelImageName.Name = "labelImageName";
            this.labelImageName.Size = new System.Drawing.Size(31, 19);
            this.labelImageName.TabIndex = 4;
            this.labelImageName.Text = "--";
            // 
            // textBoxDes
            // 
            this.textBoxDes.Font = new System.Drawing.Font("PMingLiU", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxDes.Location = new System.Drawing.Point(217, 484);
            this.textBoxDes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxDes.Multiline = true;
            this.textBoxDes.Name = "textBoxDes";
            this.textBoxDes.Size = new System.Drawing.Size(407, 54);
            this.textBoxDes.TabIndex = 5;
            // 
            // buttonDate
            // 
            this.buttonDate.Font = new System.Drawing.Font("DFKai-SB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonDate.Location = new System.Drawing.Point(133, 152);
            this.buttonDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonDate.Name = "buttonDate";
            this.buttonDate.Size = new System.Drawing.Size(74, 38);
            this.buttonDate.TabIndex = 7;
            this.buttonDate.Text = "日期";
            this.buttonDate.UseVisualStyleBackColor = true;
            this.buttonDate.Click += new System.EventHandler(this.buttonDate_Click);
            // 
            // monthCalendarDate
            // 
            this.monthCalendarDate.Location = new System.Drawing.Point(663, 283);
            this.monthCalendarDate.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.monthCalendarDate.Name = "monthCalendarDate";
            this.monthCalendarDate.TabIndex = 10;
            this.monthCalendarDate.Visible = false;
            // 
            // textBoxBranchName
            // 
            this.textBoxBranchName.Font = new System.Drawing.Font("PMingLiU", 14F);
            this.textBoxBranchName.Location = new System.Drawing.Point(217, 45);
            this.textBoxBranchName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxBranchName.Name = "textBoxBranchName";
            this.textBoxBranchName.Size = new System.Drawing.Size(354, 30);
            this.textBoxBranchName.TabIndex = 11;
            // 
            // textBoxDate
            // 
            this.textBoxDate.Font = new System.Drawing.Font("PMingLiU", 14F);
            this.textBoxDate.Location = new System.Drawing.Point(224, 160);
            this.textBoxDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.Size = new System.Drawing.Size(126, 30);
            this.textBoxDate.TabIndex = 12;
            this.textBoxDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxDate_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("DFKai-SB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(97, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 19);
            this.label1.TabIndex = 13;
            this.label1.Text = "支線 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("DFKai-SB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(129, 504);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 19);
            this.label2.TabIndex = 14;
            this.label2.Text = "描述";
            // 
            // pictureBoxView
            // 
            this.pictureBoxView.Location = new System.Drawing.Point(217, 210);
            this.pictureBoxView.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxView.Name = "pictureBoxView";
            this.pictureBoxView.Size = new System.Drawing.Size(407, 235);
            this.pictureBoxView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxView.TabIndex = 6;
            this.pictureBoxView.TabStop = false;
            // 
            // FormInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 604);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxDate);
            this.Controls.Add(this.textBoxBranchName);
            this.Controls.Add(this.monthCalendarDate);
            this.Controls.Add(this.buttonDate);
            this.Controls.Add(this.pictureBoxView);
            this.Controls.Add(this.textBoxDes);
            this.Controls.Add(this.labelImageName);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonApply);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.Label labelImageName;
        private System.Windows.Forms.TextBox textBoxDes;
        private System.Windows.Forms.Button buttonDate;
        private System.Windows.Forms.MonthCalendar monthCalendarDate;
        private System.Windows.Forms.TextBox textBoxBranchName;
        private System.Windows.Forms.TextBox textBoxDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBoxView;
    }
}